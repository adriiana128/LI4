import React from 'react'
import {Col,Row, Button,Form, Container} from 'react-bootstrap'
import User from '../images/paris.jpg'
import {IoIosThumbsUp,IoIosChatbubbles,IoMdStar} from 'react-icons/io'
import {Link} from 'react-router-dom'
import LeftPane4Btn from '../components/LeftPane4Btn'




function ComentarForm() {
    return (
            <Row style={{marginRight: "0"}}>
                <Col sm="3">
                   <LeftPane4Btn>
                   </LeftPane4Btn>
                </Col>
                <Col sm="9" className="mt-5">
                    <div className="mycontainer-50per">
                    <Row className="justify-content-between">
                        <Col sm="4">
                            <Form.Label>
                                França, Paris
                            </Form.Label>
                        </Col>
                        <Col sm="2">
                            <Form.Label>
                                Denunciar
                            </Form.Label>
                        </Col>
                    </Row>
                    <img className="photo-res-max" src={User}/>
                    <Row className="justify-content-between">
                    <Col sm="4">
                        <IoIosThumbsUp size={50}/>
                        <IoIosChatbubbles size={50}/>
                    </Col>
                    <Col sm="2">
                        <IoMdStar className="mx-auto"/>
                    </Col>    
                    </Row>
                    <Row>
                        <Col sm="3">
                            <IoMdStar className="mx-auto"/>
                            <IoMdStar className="mx-auto"/>
                            <IoMdStar className="mx-auto"/>
                            <IoMdStar className="mx-auto"/>
                            <IoMdStar className="mx-auto"/>
                        </Col>
                        <Col sm="4">
                            <Form.Label>
                                4564 visualizações
                            </Form.Label>
                         </Col>
                    </Row>
                    <Row className="border-bottom">
                        <Form.Label>
                            pacs_53 Paris, a casta dos deuses
                        </Form.Label>
                    </Row>
                    <Row className="justify-content-between">
                        <Col sm="10">
                            <Form.Control className="mt-2" syze="lg" type="standar-basic" placeholder="Adiconar um comentário">
                            </Form.Control>
                        </Col>
                        <Col sm="2" className="mt-3">
                            <Link >Publicar</Link>
                        </Col>
                    </Row>
                    </div> 
                </Col>
            </Row>
    )
}
export default ComentarForm

