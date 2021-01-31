import React, { Component } from 'react';
import axios from 'axios';

class DisplayFields extends Component {
    componentDidMount() {
        axios.get('/WeatherForecast')
            .then(response => {
                console.log(response)
            })
            .catch(e => {
                console.log("error" + e)
            })
    }

    render() {
        return (
            <div>
                <h1>
                    TestReactApp testing on local environment
                </h1>
            </div>
        )
    }
}

export default DisplayFields;

