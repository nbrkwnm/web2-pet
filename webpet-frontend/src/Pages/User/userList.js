/* eslint-disable react/jsx-one-expression-per-line */
import React, { useEffect, useState } from 'react';
import API from '../../api/base';

export default function ambientList() {
  const [user, setUser] = useState();

  useEffect(async () => {
    const response = await API.get('/user');
    setUser(response);
  }, []);

  if (!user) {
    return (<div>carregando</div>);
  }

  // eslint-disable-next-line no-shadow
  function printUser(user) {
    return (
      <div>
        <>
          <h1> Nome: {user.username ? user.username : 'Sem nome'} </h1>
          <h1> Senha: {user.password} </h1>
          --------------------------------------------------------------------------------------
        </>
      </div>
    );
  }

  return (
    <>
      {user.data.map(printUser)}
    </>
  );
}
