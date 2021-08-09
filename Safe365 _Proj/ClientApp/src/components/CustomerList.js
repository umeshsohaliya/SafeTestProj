import React, { Component } from 'react';

export class CustomerList extends Component {
    static displayName = CustomerList.name;


    constructor(props) {
        super(props);
        this.state = { Customers: [], selectedCustomer: 0, loading: true, status:''};
        this.AddCustomer = this.AddCustomer.bind(this);
    }

    componentDidMount() {
        debugger;
        this.populateCustomerData();
    }

    deleteCustomer = (customerId) => {
        const response = fetch('Customer/Delete/' + customerId)
            .then(() => this.populateCustomerData());
    };

    EditCustomer = (customerId) => {
        this.props.history.push('/EditCustomer', { id: customerId });
    };

     renderCustomerList(customers) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Date</th>
                        <th>DOB</th>
                        <th>Business Name </th>
                        <th>Date Created</th>
                        <th>Delete</th>
                        <th>Edit</th>
                    </tr>
                </thead>
                <tbody>
                    {customers.map(customers =>
                        <tr key={customers.customerId}>
                            <td>{customers.firstName}</td>
                            <td>{customers.lastName}</td>
                            <td>{customers.dateOfBirth}</td>
                            <td>{customers.BusinessName}</td>
                            <td>{customers.DateCreated}</td>
                            <td> <button className="btn btn-primary" onClick={() => this.deleteCustomer(customers.customerId)}  >Delete customer</button>
                            </td>   <td> <button className="btn btn-primary" onClick={() => this.EditCustomer(customers.customerId)}  >Edit customer</button>
                               
                            </td>
                        </tr>
                    )}
                </tbody>
            </table >
        );
    }

    render() {

        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderCustomerList(this.state.Customers);

        return (
            <div>
                <button className="btn btn-primary" onClick={this.AddCustomer}>Add customer</button>
                <div>
                    {contents}
                </div>
               
            </div>
        );
    }


    async populateCustomerData() {
        const response = await fetch('Customer');
        const data = await response.json();
        this.setState({ Customers: data, loading: false });
    }

    AddCustomer() {
      this.props.history.push('/AddCustomer');
    }
}
