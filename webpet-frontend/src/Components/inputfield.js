import React from 'react';

function Inputfield(props) {
  return (
    <>
      {/* eslint-disable-next-line max-len */}
      {/* eslint-disable-next-line react/destructuring-assignment,jsx-a11y/label-has-associated-control */}
      <label htmlFor={props.name}>
        {/* eslint-disable-next-line react/destructuring-assignment */}
        {props.name}
        :
        {' '}
      </label>
      {/* eslint-disable-next-line react/destructuring-assignment */}
      <input type={props.type} name={props.name} />
      <br />
    </>

  );
}

export default Inputfield;
