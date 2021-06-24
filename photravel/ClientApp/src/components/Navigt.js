import React, { Component } from 'react'
import {Navbar,Nav, NavDropdown} from 'react-bootstrap'
import User from '../images/user.png'
import Add from '../images/add.png'
import About from '../images/about.png'
import Fav from '../images/favorite.png'
import Lang from '../images/country.png'
import SignOut from '../images/signout.png'
import {Link} from "react-router-dom"


class Navigt extends Component {
        /*{
          colocar com variáveis o if
         }*/


    render() {
        if (!this.props.log) {
            return (
                <Navbar collapseOnSelect expand="lg" className="nav-border" style={{ padding: "0" }}>
                    <Navbar.Brand style={{ padding: "0" }}>
                        <Link to="/">
                            <Nav className="logo-nav" style={{ color: "black" }}>PHOTRAVEL</Nav>
                        </Link>
                    </Navbar.Brand>
                    <Navbar.Toggle aria-controls="responsive-navbar-nav" />
                    <Navbar.Collapse id="responsive-navbar-nav">
                        <Nav className="mr-auto">

                        </Nav>
                        <Nav>
                            <Link to="/signin">
                                <Nav.Item className="icons-nav" ><img src={User} />
                                    <figcaption style={{color: "black"}}>Iniciar Sessão</figcaption></Nav.Item>
                            </Link>
                            <Link to="/signup">
                                <Nav.Item className="icons-nav" ><img src={Add} />
                                    <figcaption style={{ color: "black" }}>Registar-se</figcaption></Nav.Item>
                            </Link>
                            <Link to="/About">
                                <Nav.Item className="icons-nav" ><img src={About} />
                                    <figcaption style={{ color: "black" }}>Sobre</figcaption></Nav.Item>
                            </Link>
                            <Nav.Item className="icons-nav" ><img src={Lang} /></Nav.Item>
                        </Nav>
                    </Navbar.Collapse>
                </Navbar>
            )
        }
        return (
            <Navbar collapseOnSelect expand="lg" className="nav-border" style={{ padding: "0" }}>
                <Navbar.Brand style={{ padding: "0" }}>
                    <Link to="/">
                        <Nav.Item className="logo-nav" style={{ color: "black" }} >PHOTRAVEL</Nav.Item>
                    </Link>
                </Navbar.Brand>
                <Navbar.Toggle aria-controls="responsive-navbar-nav" />
                <Navbar.Collapse id="responsive-navbar-nav">
                    <Nav className="mr-auto">

                    </Nav>
                    <Nav>
                        <Link to="/signin">
                            <Nav.Item className="icons-nav" ><img src={SignOut} />
                                <figcaption style={{ color: "black" }}>Terminar Sessão</figcaption></Nav.Item>
                        </Link>
                        <Link to="/edituser" username={this.props.username}>
                            <Nav.Item className="icons-nav" ><img src={User} />
                                <figcaption style={{ color: "black" }}>Editar Info</figcaption></Nav.Item>
                        </Link>
                        <Link to="/About">
                            <Nav.Item className="icons-nav" ><img src={About} />
                                <figcaption style={{ color: "black" }}>Sobre</figcaption></Nav.Item>
                        </Link>
                        <Nav.Item className="icons-nav" ><img src={Lang} /></Nav.Item>
                    </Nav>
                </Navbar.Collapse>
            </Navbar>
        )
    }
} export default Navigt