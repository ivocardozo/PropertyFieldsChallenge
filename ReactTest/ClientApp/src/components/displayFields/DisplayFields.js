import React, { Component } from 'react';
import { Row, Container, Col, Button } from 'react-bootstrap';

import axios from 'axios';
import TableContent from './tableContent/TableContent';

class DisplayFields extends Component {
    state = {
        data: null
    }

    componentDidMount() {
        axios.get('/properties/properties')
            .then(response => {
                this.setState({data: response.data})
            })
            .catch(e => {
                console.log("error" + e)
            })
    }

    saveRowHandler = (rowId) => {
        let row = this.state.data.find(property => property.id === rowId)
        axios.post('/properties/property', row)
            .then(response => {
                alert("Succesfully stored:" + response.data.address)
            })
            .catch(error => {
                alert("Error when trying to store")
            });
    }

    render() {
        return (
            <div>
                <TableContent
                    dataRows={this.state.data}
                    buttonEvent={this.saveRowHandler}
                />
            </div>
        )
    }
}

export default DisplayFields;

