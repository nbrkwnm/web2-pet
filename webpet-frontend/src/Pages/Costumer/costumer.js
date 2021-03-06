import React, { useEffect } from 'react';
import Inputfield from '../../Components/inputfield';
import Submitfield from '../../Components/submitfield';
import API from '../../api/base';

function Costumer() {
  let form = {
    name: '',
    email: '',
    birthDate: '',
    documents: [''],
    username: '',
    password: '',
  };

  async function handleOnSubmit(data) {
    if (typeof data !== 'undefined') {
      form = {
        name: data.Name.value,
        email: data.Email.value,
        birthDate: data.Birthdate.value,
        documents: [data.documento.value],
        username: data.Username.value,
        password: data.Password.value,
      };
    }
    const response = await API.post('/user', form);
  }

  function stopDefAction(evt) {
    evt.preventDefault();
    handleOnSubmit();
  }

  useEffect(() => {
    handleOnSubmit();
  }, []);
  return (
    <div className="mb-3">
      <form onSubmit={stopDefAction}>
        <h1 className="form-title">Cadastro de cliente</h1>
        <Inputfield name="Name" type="text" />
        <Inputfield name="Email" type="email" />
        <Inputfield name="Birthdate" type="data" />
        <Inputfield name="documento" type="number" />
        <Inputfield name="Username" type="text" />
        <Inputfield name="Password" type="password" />
        <Submitfield name="Logar" />
      </form>
    </div>
  );
}

export default Costumer;
