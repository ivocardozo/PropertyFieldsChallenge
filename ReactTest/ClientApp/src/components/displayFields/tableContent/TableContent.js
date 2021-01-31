import React from 'react';
import { Table, Button } from 'react-bootstrap';

const tableContent = (props) => {

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
        myRows =
            props.dataRows.map((row, i = 0) => {
                return (
                    <tbody key={i++}>
                        <tr>
                            <td>{row.address}</td>
                            <td>{row.yearBuild}</td>
                            <td>{`\$ ${row.listPrice.toFixed(2)}`}</td>
                            <td>{`\$ ${row.monthlyPrice.toFixed(2)}`}</td>
                            <td>{`${row.grossYield.toFixed(2)} %`}</td>
                            <td>
                                <Button
                                    onClick={() => props.buttonEvent(row.id)}
                                    id={row.id} variant="success"
                                >
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