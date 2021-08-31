import React from 'react';

function SubmitField(props) {
  return (
    <>
      {/* eslint-disable-next-line max-len */}
      {/* eslint-disable-next-line react/destructuring-assignment,jsx-a11y/control-has-associated-label */}
      <button className="btn btn-primary" type="submit">
        {' '}
        {/* eslint-disable-next-line react/destructuring-assignment */}
        {props.name}
        {' '}
      </button>
    </>
  );
}

export default SubmitField;
