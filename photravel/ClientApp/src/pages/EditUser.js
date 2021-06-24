import React, { Component } from 'react'
import PubBar from '../components/Navigt'
import EditUserForm from '../components/EditUserForm'

class EditUser extends Component {
    render() {
    return (
        <div>
           <PubBar/>
               <EditUserForm/>                 
        </div>
        )
        }
}

export default EditUser