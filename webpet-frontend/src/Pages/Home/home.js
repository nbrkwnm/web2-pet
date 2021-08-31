import React from 'react';
import Inputfield from '../../Components/inputfield';
import SubmitField from '../../Components/submitfield';

function Home() {
  return (
    <div className="mb-3">
      <form className="login">
        <h1 className="form-title">Logar</h1>
        <Inputfield name="Email" type="email" />
        <Inputfield name="Senha" type="password" />
        <Inputfield name="Repita a sua senha" type="password" />
        <SubmitField name="Logar" />
      </form>
    </div>
  );
}

export default Home;
