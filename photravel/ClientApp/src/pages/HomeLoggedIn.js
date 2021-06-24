import React from 'react'
import Navigt from '../components/Navigt'
import LeftPane4Btn from '../components/LeftPane4Btn'
import {Row, Col, Container, Form} from 'react-bootstrap'
import Photo from '../components/Photo'
import { Component } from 'react'

class HomeLoggedIn extends Component {
    render() {
        return (
            <div>
                <Navigt log={true} username={this.props.usernmae}/>
                <Row style={{ margin: "0" }}>
                    <Col sm="3">
                        <LeftPane4Btn>
                        </LeftPane4Btn>
                    </Col>
                    <Col sm="9" className="mt-3">
                        <div className="mycontainer-70per-about">
                            <Form className="ml-5">
                                <Form.Group>
                                    <Form.Label>Filtrar: 4</Form.Label>
                                </Form.Group>
                            </Form>
                            <Row className="justify-content-between">
                                <Col>
                                    <Photo />
                                </Col>
                                <Col>
                                    <Photo />
                                </Col>
                            </Row>
                            <Row className="justify-content-between" className="mt-3">
                                <Col>
                                    <Photo />
                                </Col>
                                <Col>
                                    <Photo />
                                </Col>
                            </Row>
                        </div>
                    </Col>
                </Row>
            </div>
        )
    }
}export default HomeLoggedIn