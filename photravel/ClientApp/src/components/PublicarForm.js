import React from 'react'
import {Link} from "react-router-dom"
import {Button,Form,Row,Col,Container,Media} from 'react-bootstrap'
import User from '../images/user-big.png'

 function PublicarForm() {
    return (
        <div>
            <center>
        <Button variant="dark" className="mt-5" size="lg">Arraste e largue ou carregue a fortografia</Button>
        </center>
        <Container className="mt-5">
            <Row>
                <Col sm="6">
                    <Media>
                        <img className="mx-auto"
                        max-height={200}
                        min-height={100} 
                        max-width={200}
                        min-width={100}
                        src={User}
                        />
                    </Media>
                </Col>
                <Col sm="6">
                    <Form>
                        <Form.Group>
                            <Form.Label >Adicionar uma descrição</Form.Label>
                                <Form.Control as="textarea" row="3" className="form-textarea" placeholder="Descrição">
                            </Form.Control>
                        </Form.Group>
                    </Form>
                    <Form>
                        <Form.Group className="mt-5">
                            <Form.Label>Faça com que os viajantes encontrem a sua fotografia facilmente</Form.Label>
                            <Form.Control type="text" placeholder="Cidade"/>
                        </Form.Group>
                    </Form>
                </Col>
            </Row>
        </Container>
        <Link to="/dashboard">
            <Button variant="dark" className="btn-signup">
                Confirmar
            </Button>
            </Link>
        </div>
    )
}
export default PublicarForm