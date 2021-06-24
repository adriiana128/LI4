import React from 'react'
import { Form, Button } from 'react-bootstrap'
import { Link } from 'react-router-dom'


export default function LeftPane4Btn() {
    return (
        <div>
        <Form className="mt-5">
                <Form.Group>
                    <Form.Control syze="lg" type="text" placeholder="Cidade">
                    </Form.Control>
                </Form.Group>
                <Form.Group>
                    <Link to="/ranking">
                        <Button variant="dark" className="cont-max-width">
                            Ranking Por Local
                        </Button>
                    </Link>
                </Form.Group>
                <Form.Group>
                    <Link to="/publicar">
                    <Button variant="dark" className="cont-max-width">
                        Upload Foto
                    </Button>
                    </Link>
                </Form.Group>
        </Form>
        
        </div>
    )
}
