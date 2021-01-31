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
                console.log(response)
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
                <h1>
                    TestReactApp testing on local environment
                </h1>
                <TableContent dataRows={this.state.data} />
                <Button variant="success">
                    Consultar
                </Button>
            </div>
        )
    }
}

export default DisplayFields;

