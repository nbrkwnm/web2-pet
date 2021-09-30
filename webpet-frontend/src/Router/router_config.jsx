/* eslint-disable react/react-in-jsx-scope */
import { BrowserRouter as Router, Route } from 'react-router-dom';
import User from '../Pages/User/user';
import Costumer from '../Pages/Costumer/costumer';
import Ambient from '../Pages/Ambient/ambient';

// eslint-disable-next-line import/prefer-default-export
export default function Routers() {
  return (
    <Router>
      <>
        <Route exact path="/">
          <User />
        </Route>
        <Route exact path="/ambient">
          <Ambient />
        </Route>
        <Route exact path="/user">
          <User />
        </Route>
      </>
    </Router>
  );
}
