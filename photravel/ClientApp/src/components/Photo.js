import React from 'react'
import {Col,Row,Form} from 'react-bootstrap'
import {IoMdStar,IoIosThumbsUp,IoIosChatbubbles} from 'react-icons/io'
import User from '../images/paris.jpg'

export default function Photo() {
    return (
            
        <div className="mycontainer-70per">
            <img className="photo-res-min" src={User}/>
                <Row className="justify-content-between">
                    <Col sm="4">
                        <IoIosThumbsUp size={25}/>
                        <IoIosChatbubbles size={25}/>
                    </Col>
                    <Col sm="1"  className="mr-3">
                        <IoMdStar className="mx-auto"/>
                    </Col>    
                    </Row>
                    <Row>
                        <Col sm="4" style={{paddingRight: "0"}}>
                            <IoMdStar size={11}/>
                            <IoMdStar size={11}/>
                            <IoMdStar size={11}/>
                            <IoMdStar size={11}/>
                            <IoMdStar size={11}/>
                        </Col>
                        <Col sm="6" style={{paddingLeft: "0"}}>
                            <Form.Label className="text-reduce">
                                4564 visualizações
                            </Form.Label>
                         </Col>
                </Row>
        </div>
    )
}
