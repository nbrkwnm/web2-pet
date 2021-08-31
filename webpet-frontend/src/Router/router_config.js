import Home from '../Pages/Home/home';

// eslint-disable-next-line import/prefer-default-export
export const BASIC_ROUTER_CONFIG = [
  {
    path: '/',
    exact: true,
    component: Home,
    auth: [],
  },
  // {
  //   path: '/create-account',
  //   exact: false,
  //   component: CreateAccount,
  //   auth: [],
  // },
  // {
  //   path: '/login',
  //   exact: false,
  //   component: Login,
  //   auth: [],
  // },
];
