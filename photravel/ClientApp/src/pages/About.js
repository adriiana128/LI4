import React from 'react'
import {Row,Col,Form} from 'react-bootstrap'
import LeftPane2Btn from '../components/LeftPane2Btn'
import PubBar from '../components/Navigt'

export const About = () => {
    return (
        <div>
            <PubBar/>
            <Row style={{marginRight: "0"}}>
                <LeftPane2Btn/>
                <Col sm="9" className="mt-5">
                    <div className="mycontainer-70per-about">
                    <Form.Text align="justify" className="margin-top-15per">O propósito do Photravel visa a partilha de fotografias num determinado local, com um sistema de classificação atribuída pelos seus utilizadores. Sendo que os utilizadores não só podem consultar a qualidade fotográfica de um utilizador, como o ficar a conhecer, melhor, o próprio local que pretendem visitar. O Photravel, o melhor companheiro de viagem, está ainda disponível em diversos idiomas para assim facilitar a utilização de todos os utilizadores que a esta pretendam aceder.
                    </Form.Text>
                    </div>  
                </Col>
            </Row>
        </div>
    )
}

export default About
