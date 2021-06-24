import React from 'react'
import Navigt from "../components/Navigt"
import { Container, FormGroup, Form,Col,Row,Button } from 'react-bootstrap'
import User from "../images/user-big.png"
import { Link } from "react-router-dom"
import {Component} from 'react'

class SignUp extends Component {

    constructor() {
        super();
        this.state = {
            name: "",
            username: "",
            email: "",
            password: "",
            bio: "",
            telemovel: "",
            score: 0,
            isAdmin: 0
        }
        this.onChange = this.onChange.bind(this);
    }


    onChange(e) {
        this.setState({ [e.target.name]: e.target.value });
    }

    signup = () =>{
        fetch('https://localhost:44392/signup', {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify(this.state)
        }).then(function (response) {
            console.log(response.json())
        });
    }

    render() {
        return (
            <div>
                <Navigt />
                <center>
                    <Container className="mt-5">
                        <Row className="row">
                            <Col sm={6} className="mt-1">
                                <Form className="form-signup">
                                    <Form.Group controlId="Nome">
                                        <Form.Control syze="lg" name="name" type="text" placeholder="Nome" onChange={this.onChange}/>
                                        <Form.Text className="text-muted">
                                        </Form.Text>
                                    </Form.Group>
                                    <Form.Group controlId="UserName">
                                        <Form.Control syze="lg" name="username" type="text" placeholder="Username" onChange={this.onChange}/>
                                    </Form.Group>
                                    <Form.Group controlId="Email">
                                        <Form.Control syze="lg" name="email" type="text" placeholder="Email" onChange={this.onChange}/>
                                    </Form.Group>
                                    <Form.Group controlId="Password">
                                        <Form.Control syze="lg" name="password" type="password" placeholder="Palavra Passe" onChange={this.onChange} />
                                    </Form.Group>
                                </Form>
                            </Col>
                            <Col sm={6}>
                                <FormGroup>
                                    <img src={User} />
                                </FormGroup>
                                <Button variant="dark">
                                    Carregar Foto
                            </Button>
                            </Col>
                        </Row>
                    </Container>
                    <Link to="/dashboard" username={this.state.username}>
                        <Button variant="dark" className="btn-signup" onClick={this.signup}>
                            Confirmar
                    </Button>
                    </Link>
                </center>
            </div>
        )
    }
}
export default SignUp