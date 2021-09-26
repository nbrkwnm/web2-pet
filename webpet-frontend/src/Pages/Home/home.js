import React from 'react';
import Inputfield from '../../Components/inputfield';
import SubmitField from '../../Components/submitfield';

function Home() {
  return (
    <div className="mb-3">
      <form className="cadastro_usuario" method="POST">
        <h1 className="form-title">Cadastro de cliente</h1>
        <Inputfield name="Name" type="text" />
        <Inputfield name="Email" type="email" />
        <Inputfield name="Birthdata" type="data" />
        <Inputfield name="Document" type="number" />
        <Inputfield name="Username" type="text" />
        <Inputfield name="Password" type="password" />
        <SubmitField name="Logar" />
      </form>
    </div>
  );
}

export default Home;
