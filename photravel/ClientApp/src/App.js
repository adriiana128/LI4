import React from 'react'
import './App.css'
import {Button} from 'react-bootstrap';
import Home from "./pages/Home"
import HomeLoggedIn from "./pages/HomeLoggedIn"
import SignIn from "./pages/SignIn"
import SignUp from "./pages/SignUp"
import EditUser from "./pages/EditUser"
import Photo from "./pages/Photo"
import About from "./pages/About"
import Error from "./pages/Error"
import Password from "./pages/Password"
import {Route,Switch} from 'react-router-dom'
import PublicarFoto from "./pages/PublicarFoto"
import Ranking from "./pages/Ranking"



function App() {
  return (
  <Switch>  
  <Route exact path="/" component={Home} />
  <Route exact path="/dashboard" component={HomeLoggedIn} />
  <Route exact path="/signin/" component={SignIn}/>
  <Route exact path="/signup/" component={SignUp} />
  <Route exact path="/edituser/" component={EditUser} />
  <Route exact path="/password/" component={Password} />
  <Route exact path="/photo/" component={Photo} />
  <Route exact path="/about/" component={About} />
  <Route exact path="/error/" component={Error} />
  <Route exact path="/publicar/" component={PublicarFoto} />
  <Route exact path="/ranking/" component={Ranking} />  
  </Switch>
  );
}

export default App;

