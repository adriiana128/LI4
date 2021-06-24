import React from 'react'
import NBar from '../components/Navigt'
import Img from '../images/user-big.png'
import LeftPane2Btn from '../components/LeftPane2Btn'
import {Row,Col,Form,Container,Media,Button} from 'react-bootstrap'
import {Link} from 'react-router-dom'

export const Password = () => {
    return (
        <div>
            <NBar/>
            <Row style={{marginRight: "0"}}>
                <LeftPane2Btn/>
            <Col sm="9" className="mt-5">
                <Row className="justify-content-center">
                    <Col sm="5">
               <Form>
                <Form.Group>
                    <h5>Nome utilizador</h5>
                </Form.Group> 
                </Form>
                <Form className="form-signup" className="mt-5">
                <Form.Group controlId="PassAntiga">
                    <Form.Control type="password" placeholder="Palavra Passe Antiga" />
                        <Form.Text className="text-muted">
                        </Form.Text>
                </Form.Group>

                <Form.Group controlId="PassNova" className="mt-3">
                    <Form.Control type="password" placeholder="Palavra Passe Nova" />
                </Form.Group>

                <Form.Group controlId="PassNova2" className="mt-3">
                    <Form.Control type="password" placeholder="Confirmar Passe"/>
                </Form.Group>
                <Form className="mt-2">
                <Button variant="dark">
                        Alterar Palavra Passe
                        </Button>
                </Form>
                
                <Form className="mt-2">
                    <Link to="/recuperar" className="a-form">
                    Esqueceu-se da palavra-passe?
                    </Link>
                </Form>
            </Form>
            </Col>
            </Row>
            </Col>
        </Row>  
        </div>
    )
}
export default Password