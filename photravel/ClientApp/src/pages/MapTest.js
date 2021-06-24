import React, { Component } from 'react'

class MapTest extends Component{
    constructor(props) {
        super(props);
        this.state = {
            login: false
        };
    };

    render() {
        return(
            <div>
                <h3>Google Maps Demo</h3>
                <iframe width="600" height="450" frameborder="0" style="border:0"
                src="https://www.google.com/maps/embed/v1/view?center=48.8584%2C2.2945&zoom=17&key=AIzaSyBud44pZ-hANwarjl5BuddGULRFhajbwsg" allowfullscreen></iframe>
            </div>
            )
    }
}export default Home

/*
<!DOCTYPE html>
<html>
  <body>
    <h3>Google Maps Demo</h3>
    <!--Esta demo faz aparecer um mapa centrado na torre eiffel -->
    <iframe width="600" height="450" frameborder="0" style="border:0"
src="https://www.google.com/maps/embed/v1/view?center=48.8584%2C2.2945&zoom=17&key=AIzaSyBud44pZ-hANwarjl5BuddGULRFhajbwsg" allowfullscreen></iframe>
  </body>
</html>
*/
