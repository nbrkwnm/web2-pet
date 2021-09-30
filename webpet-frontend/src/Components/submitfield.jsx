import React from 'react';

function Submitfield(props) {
  return (
    <>
      <button className="btn btn-primary" type="submit">
        {props.name}
      </button>
    </>
  );
}

export default Submitfield;
