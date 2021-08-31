import React from 'react';

function SubmitField(props) {
  return (
    <>
      <button className="btn btn-primary" type="submit">
        {' '}
        {props.name}
        {' '}
      </button>
    </>
  );
}

export default SubmitField;
