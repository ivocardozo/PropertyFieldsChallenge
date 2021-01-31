import React from 'react';
import { Table, Button } from 'react-bootstrap';

const tableContent = (props) => {
    console.log(props.dataRows)

    let myRows = null;
    let headRow = null;
    
        headRow =
            <thead>
                <tr>
                <th>Address</th>
                <th>YearBuild</th>
                <th>ListPrice</th>
                <th>MonthlyPrice</th>
                <th>GrossYield</th>
                <th>Options </th>
                </tr>
            </thead>
        myRows = <tbody>
            <tr>
                <td> body</td>
            </tr>
        </tbody>
    if (props.dataRows != null) {
        console.log("data row is not null")

        myRows =
            props.dataRows.map((row, i = 0) => {
                return (
                    <tbody key={i++}>
                        <tr>
                            <td>{row.address}</td>
                            <td>{row.yearBuild}</td>
                            <td>{row.listPrice}</td>
                            <td>{row.monthlyPrice}</td>
                            <td>{row.grossYield}</td>
                            <td>
                                <Button variant="success">
                                    save
                                </Button>
                            </td>
                        </tr>
                    </tbody>
                )
            });
    }
    
    return (
        <Table striped bordered hover>
            {headRow}
            {myRows}
        </Table>
        )
}

export default tableContent;