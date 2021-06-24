import React from 'react'
import Navigt from "../components/Navigt"
import { Form,Button } from 'react-bootstrap'
import {Link} from 'react-router-dom'
import { Component } from 'react'

class SignIn extends Component {

    constructor(props) {
        super(props);
        this.state = {
            login: false,
            email: "",
            password:""
        }
        this.onChange = this.onChange.bind(this);
    };


    onChange(e) {
        this.setState({ [e.target.name]: e.target.value });
    };

        login = () => {

            fetch('https://localhost:44392/signin', {
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
                <Navigt log={this.state.login}/>
                <center className="backcolor">
                    <Form className="form-signin">
                        <Form.Group controlId="email">
                            <Form.Control syze="lg" type="email" name="email" placeholder="Email" onChange={this.onChange}/>
                        </Form.Group>
                        <Form.Group controlId="password">
                            <Form.Control type="password" name="password" placeholder="Palavra Passe" onChange={this.onChange}/>
                        </Form.Group>
                    </Form>
                    <Form className="btn-form">
                        <Link to ="/dashboard">
                            <Button variant="dark" onClick={this.login}>
                             Iniciar Sessão
                    </Button>
                       </Link>
                    </Form>
                    <Link to="/password">
                        <div className="a-form">Esqueceu-se da palavra passe?</div>
                    </Link>
                </center>
            </div>
        )
    }
}
export default SignIn