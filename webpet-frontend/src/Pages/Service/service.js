import React, { useEffect } from 'react';
import Inputfield from '../../Components/inputfield';
import Submitfield from '../../Components/submitfield';
import API from '../../api/base';

function Service() {
  async function handleOnSubmit(data) {
    let form = {
      description: '',
      executionTime: '',
    };
    if (typeof data !== 'undefined') {
      form = {
        description: data.Description.value,
        executionTime: {},
      };
    }
    if (form) {
      const response = await API.post('/service', form);
    }
  }

  function stopDefAction(evt) {
    evt.preventDefault();
    handleOnSubmit(evt.target);
  }
  return (
    <div className="mb-3">
      <form onSubmit={stopDefAction}>
        <h1 className="form-title">Cadastro de Serviço</h1>
        <Inputfield name="Description" type="text" />
        <Submitfield name="Cadastrar" />
      </form>
    </div>
  );
}

export default Service;
