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

export class AddCustomer extends Component {
    static displayName = AddCustomer.name;


    constructor(props) {
        debugger;
        super(props);
        this.state = { Customer: {}, loading: true, status: '' };
        this.handleAddCustomer = this.handleAddCustomer.bind(this);
    }


    render() {
        return (
            <div>
                <Form
                    layout="vertical"
                    onFinish={this.handleAddCustomer}

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
                                <Input
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
                                    { required: true, message: "Please Enter Last Name!" },
                                 
                                ]}
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
                                    Add
                                        </button>

                            </Space>
                        </Col>
                    </Row>
                </Form>
            </div>
        );
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
        }).then(() => this.setState({ status: 'Saved successful' }));

    }
}
