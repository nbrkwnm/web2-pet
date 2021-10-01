/* eslint-disable react/react-in-jsx-scope */
import { BrowserRouter as Router, Route } from 'react-router-dom';
import User from '../Pages/User/user';
import Userlist from '../Pages/User/userList';
import Ambient from '../Pages/Ambient/ambient';
import AmbientList from '../Pages/Ambient/ambientList';
import Home from '../Pages/Home/home';
import License from '../Pages/License/license';
import Service from '../Pages/Service/service';
import ServiceList from '../Pages/Service/serviceList';

export default function Routers() {
  return (
    <Router>
      <>
        <Route exact path="/">
          <Home />
        </Route>
        <Route exact path="/ambient">
          <Ambient />
        </Route>
        <Route exact path="/ambient_list">
          <AmbientList />
        </Route>
        <Route exact path="/user">
          <User />
        </Route>
        <Route exact path="/user_list">
          <Userlist />
        </Route>
        <Route exact path="/services">
          <Service />
        </Route>
        <Route exact path="/services_list">
          <ServiceList />
        </Route>
        <Route exact path="/license">
          <License />
        </Route>
      </>
    </Router>
  );
}
