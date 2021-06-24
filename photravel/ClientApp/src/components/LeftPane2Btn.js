import React from 'react'
import {Container,Form,Button,Col} from 'react-bootstrap'

export default function LeftPane2Btn() {
    return (
            <Col sm="3">
                    <Container>
                    <Form className="mt-5">
                        <Form.Group>
                            <Button className="cont-max-width" variant="dark">
                                Quem Somos
                            </Button>
                        </Form.Group>
                        <Form.Group>
                            <Button className="cont-max-width" variant="dark">
                                Proprietários
                            </Button>
                        </Form.Group>
                    </Form>
                </Container>
                </Col>
    )
}
