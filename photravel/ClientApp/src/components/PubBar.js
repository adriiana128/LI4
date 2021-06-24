import React from 'react'
import { Navbar,Nav } from 'react-bootstrap';
import aboutA from '../images/icon.png'
import {Link} from 'react-router-dom'

function PubBar() {
    return (
        <Navbar.Brand className="mr-auto">
            <Link to="/">
              <Nav.Link className="logo-nav" style={{color: "black"}} href="#home">PHOTRAVEL</Nav.Link>
            </Link>
          </Navbar.Brand>
    )
}
export default PubBar;