/* eslint-disable react/jsx-one-expression-per-line */
import React, { useEffect, useState } from 'react';
import API from '../../api/base';

export default function ambientList() {
  const [services, setServices] = useState();

  useEffect(async () => {
    const response = await API.get('/ambient');
    setServices(response);
  }, []);

  if (!services) {
    return (<div>carregando</div>);
  }

  // eslint-disable-next-line no-shadow
  function printAmbient(services) {
    return (
      <div>
        <>
          <h1> {services.description ? services.description : 'sem nome'} </h1>
          --------------------------------------------------------------------------------------
        </>
      </div>
    );
  }

  return (
    <>
      {services.data.map(printAmbient)}
    </>
  );
}
