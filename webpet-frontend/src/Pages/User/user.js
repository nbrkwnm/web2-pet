import React from 'react';
import Inputfield from '../../Components/inputfield';
import Submitfield from '../../Components/submitfield';
import API from '../../api/base';

function User() {
  let form = {
    person: {
      name: '',
      email: '',
      birthDate: '',
      documents: [],
    },
    username: '',
    password: '',
  };

  async function handleOnSubmit(data) {
    if (typeof data !== 'undefined') {
      form = {

        person: {
          name: data.Name.value,
          email: data.Email.value,
          birthDate: data.Birthdate.value,
          documents: [],
        },
        username: data.Username.value,
        password: data.Password.value,
      };
    }
    const response = await API.post('/user', form);
  }

  function stopDefAction(evt) {
    evt.preventDefault();
    handleOnSubmit(evt.target);
  }
  return (
    <div className="mb-3">
      <form onSubmit={stopDefAction}>
        <h1 className="form-title">Cadastro de cliente</h1>
        <Inputfield name="Name" type="text" />
        <Inputfield name="Email" type="email" />
        <Inputfield name="Birthdate" type="date" />
        <Inputfield name="Username" type="text" />
        <Inputfield name="Password" type="password" />
        <Submitfield name="Cadastrar" />
      </form>
    </div>
  );
}

export default User;
