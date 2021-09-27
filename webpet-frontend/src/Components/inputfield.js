import React from 'react';

function Inputfield(props) {
  return (
    <>
      <label htmlFor={props.name}>
        {/* eslint-disable-next-line react/jsx-one-expression-per-line */}
        {props.name}:{' '}
      </label>
      <input type={props.type} name={props.name} />
      <br />
    </>

  );
}

export default Inputfield;
