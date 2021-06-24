import React, { Component } from 'react'
import {Row,Col,Form,Container,Media,Button} from 'react-bootstrap'
import {Link} from 'react-router-dom'
import Img from '../images/user-big.png'
import LeftPane2Btn from '../components/LeftPane2Btn'

class EditUserForm extends Component{

    constructor() {
        super();
        this.state = {
            name: "",
            username: "",
            email: "",
            bio: "",
            telemovel: "",
            local: "",
        }
        this.onChange = this.onChange.bind(this);
    }


    onChange(e) {
        this.setState({ [e.target.name]: e.target.value });
    }

    signup = () => {
        fetch('https://localhost:44392/edituser', {
            method: "PUT",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify(this.state)
        }).then(function (response) {
            console.log(response.json())
        });
    }

    render() {
        this.state.username = this.props.username
        return (
            <Row style={{ margin: "0" }}>
                <LeftPane2Btn />
                <Col sm="9" className="mt-5">
                    <Row className="justify-content-center">
                        <Col sm="5">
                            <Form>
                                <Form.Group>
                                    <h5>Nome utilizador</h5>
                                    <p> Complete apenas o que pretende alterar</p>
                                </Form.Group>
                            </Form>
                            <Form >
                                <Form.Group controlId="Nome">
                                    <Form.Control type="text" name="name" placeholder="Nome Próprio" onChange={this.onChange}/>
                                    
                                </Form.Group>

                                <Form.Group controlId="Username">
                                    <Form.Control type="text" name="username" placeholder="Nome Utilizador" onChange={this.onChange}/>
                                </Form.Group>

                                <Form.Group controlId="Email">
                                    <Form.Control type="text" name="email" placeholder="E-mail" onChange={this.onChange}/>
                                </Form.Group>

                                <Form.Group controlId="Localidade">
                                    <Form.Control type="text" name="local" placeholder="Localidade" onChange={this.onChange} />
                                </Form.Group>
                            </Form>
                            <Form>
                                <Form>
                                    <Row className="justify-content-between">
                                        <Col>
                                            <Link to="/password">
                                            <Button variant="dark">
                                                Mudar Password
                                            </Button>
                                                </Link>
                                        </Col>
                                        <Col>
                                            <Button variant="dark" className="float-right">
                                                Confirmar
                                            </Button>
                                        </Col>
                                    </Row>
                                </Form>
                            </Form>
                        </Col>
                    </Row>
                </Col>
            </Row>
        )
        
    }
}export default EditUserForm
