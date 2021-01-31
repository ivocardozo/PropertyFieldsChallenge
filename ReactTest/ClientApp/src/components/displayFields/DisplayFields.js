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

    render() {
        console.log(this.state.data)
        return (
            <div>
                <TableContent dataRows={this.state.data} />
            </div>
        )
    }
}

export default DisplayFields;

