import React, { Component } from 'react';
import {
    PageHeader,
    Input,
    Row,
    Col,
    Select,
    Form,
    Space,
    Popconfirm,
    Table,
    Modal,
    notification,
    Tooltip,
    Spin,
} from "antd";

export class EditCustomer extends Component {
    static displayName = EditCustomer.name;


    constructor(props) {
        debugger;
        super(props);
        this.state = { Customer: {}, loading: true };
        this.handleAddCustomer = this.handleAddCustomer.bind(this);
    }

    componentDidMount() {
        debugger;
         this.populateCustomerData();
    }

    render() {
        return (
            <div>

                <h1 id="tabelLabel" > {this.state.Customer.firstName}</h1>
                <Form
                    layout="vertical"
                    onFinish={this.handleUpdateCustomer}
                >
                    <Row gutter={24}>
                        <Col xs={24}>
                            <Form.Item
                                label="First Name"
                                name="FirstName"
                                rules={[
                                    { required: true, message: "Please Enter First Name!" },
                                ]}
                            >
                                <Input value={this.state.Customer.firstName}
                                    placeholder="Enter First Name"
                                    disabled={this.state.isEnabled}
                                    onChange={this.handleBrandName}
                                />
                            </Form.Item>
                        </Col>

                        <Col xs={24}>
                            <Form.Item
                                label="Last Name"
                                name="LastName"
                                rules={[
                                    { required: true, message: "Please Enter Last Name!" },]}
                                  
                            >
                                <Input
                                    placeholder="Enter Last Name"
                                    disabled={this.state.isEnabled}
                                    onChange={this.handleBrandName}
                                />
                            </Form.Item>
                        </Col>

                        <Col xs={24}>
                            <Form.Item
                                label="Date Of Birth"
                                name="DateOfBirth"
                                rules={[
                                    { required: true, message: "Please Enter Date Of Birth!" },
                                ]}
                            >
                                <Input
                                    placeholder="Enter Date Of Birth"
                                    disabled={this.state.isEnabled}
                                    onChange={this.handleBrandName}
                                />
                            </Form.Item>
                        </Col>

                        <Col xs={24}>
                            <Form.Item
                                label="Business Name"
                                name="BusinessName"
                                rules={[
                                    { required: true, message: "Please Enter BusinessName!" },
                                ]}
                            >
                                <Input
                                    placeholder="Enter BusinessName"
                                    disabled={this.state.isEnabled}
                                    onChange={this.handleBrandName}
                                />
                            </Form.Item>
                        </Col>
                        <Col xs={24} className="custom-modal-footer">
                            <Space>
                               
                                        <button htmlType="submit" variant="purple">
                                             Update
                                        </button>
                            </Space>
                        </Col>
                    </Row>
                </Form>
            </div>
        );
    }

    async populateCustomerData() {
        const response = await fetch('Customer/Details/' + this.props.location.state.id);
        const data = await response.json();
        this.setState({ Customer: data, loading: false });
    }
    handleAddCustomer = (event) => {

        var data = new FormData();
        data.append("json", JSON.stringify(event));

        fetch('Customer/Create', {
            method: 'POST',
            body: JSON.stringify(event),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
        })
    }
}
