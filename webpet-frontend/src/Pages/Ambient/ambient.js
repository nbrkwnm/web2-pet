import React, { useEffect } from 'react';
import Inputfield from '../../Components/inputfield';
import SubmitField from '../../Components/submitfield';
import API from '../../api/base';

function Ambient() {
  let form = {
    name: '',
    email: '',
  };

  async function handleOnSubmit(data) {
    if (typeof data !== 'undefined') {
      form = {
        name: data.Name.value,
        email: data.Email.value,
      };
    }
    const response = await API.post('/ambient', form);
  }

  function stopDefAction(evt) {
    evt.preventDefault();
    handleOnSubmit();
  }

  useEffect(() => {
    handleOnSubmit();
  }, []);
  // document.getElementsByName('Logar').preventDefault();
  return (
    <div className="mb-3">
      <form onSubmit={stopDefAction}>
        <h1 className="form-title">Cadastro de cliente</h1>
        <Inputfield name="Name" type="text" />
        <Inputfield name="Email" type="email" />
        <SubmitField name="Confirmar" />
      </form>
    </div>
  );
}

export default Ambient;
