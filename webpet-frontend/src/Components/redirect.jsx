import React from 'react';
import { Redirect } from 'react-router-dom';

export default function redirectTo(props) {
  return (<Redirect to={`/${props}`} />);
}
