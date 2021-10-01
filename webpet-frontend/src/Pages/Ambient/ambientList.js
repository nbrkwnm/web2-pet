/* eslint-disable react/jsx-one-expression-per-line */
import React, { useEffect, useState } from 'react';
import API from '../../api/base';

export default function ambientList() {
  const [ambients, setAmbients] = useState();

  useEffect(async () => {
    const response = await API.get('/ambient');
    setAmbients(response);
  }, []);

  if (!ambients) {
    return (<div>carregando</div>);
  }

  function printAmbient(ambient) {
    return (
      <div>
        {ambient.isActive
          ? (
            <>
              <h1> {ambient.description ? ambient.description : 'sem nome'} </h1>
              <h1> Ocupado: {ambient.isOccupied ? 'sim' : 'não'} </h1>
              --------------------------------------------------------------------------------------
            </>
          ) : ''}
      </div>
    );
  }

  return (
    <>
      {ambients.data.map(printAmbient)}
    </>
  );
}
