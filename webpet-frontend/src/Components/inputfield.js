import React from 'react';

function Inputfield(props) {
  return (
    <>
      <label htmlFor={props.name}>
        {props.name}
        :
        {' '}
      </label>
      <input type={props.type} name={props.name} />
      <br />
    </>

  );
}

export default Inputfield;
