import React, { Component } from 'react'
import AppBar from '../components/Navigt'
import LeftPane4Btn from '../components/LeftPane4Btn'
import { Row, Col, Container, Form } from 'react-bootstrap'
import User from '../images/paris.jpg'

class Home extends Component {
    constructor(props) {
        super(props);
        this.state = {
            login: false
        };
    };

    render() {
        return (

            <div>
                <AppBar />
                <Row style={{ margin: "0" }}>
                    <Col sm="3">
                        <LeftPane4Btn/>
                    </Col>
                    <Col sm="9" className="mt-5">
                        <div className="mycontainer-70per">
                            <Row className="justify-content-between">
                                <Col sm="5">
                                    <img className="photo-res-left-top" src={User} />
                                </Col>
                                <Col sm="6" style={{ padding: "0" }}>
                                    <img className="photo-res-right-top" src={User} />
                                </Col>
                            </Row>
                            <Row className="justify-content-between" className="mt-3">
                                <Col sm="5">
                                    <img className="photo-res-bot" src={User} />
                                </Col>
                                <Col sm={{ span: 3, offset: 1 }} style={{ padding: "0" }}>
                                    <img className="photo-res-bot" src={User} />
                                </Col>
                                <Col sm="3" style={{ paddingRight: "0" }}>
                                    <img className="photo-res-bot" src={User} />
                                </Col>
                            </Row>
                        </div>
                    </Col>
                </Row>
            </div>
        )
    }
} export default Home
