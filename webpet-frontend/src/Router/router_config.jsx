/* eslint-disable react/react-in-jsx-scope */
import { BrowserRouter as Router, Route } from 'react-router-dom';
import User from '../Pages/User/user';
import Ambient from '../Pages/Ambient/ambient';
import AmbientList from '../Pages/Ambient/ambientList';
import Home from '../Pages/Home/home';
import License from '../Pages/License/license';

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
        <Route exact path="/user">
          <User />
        </Route>
        <Route exact path="/license">
          <License />
        </Route>
        <Route exact path="/ambient_list">
          <AmbientList />
        </Route>
      </>
    </Router>
  );
}
