import React, { useEffect } from 'react';
import Inputfield from '../../Components/inputfield';
import Submitfield from '../../Components/submitfield';
import API from '../../api/base';

function Ambient() {
  async function handleOnSubmit(data) {
    let form = {
      description: '',
      isOccupied: '',
    };
    if (typeof data !== 'undefined') {
      form = {
        description: data.Description.value,
        isOccupied: data.Ocupado.checked,
      };
    }
    if (form) {
      const response = await API.post('/ambient', form);
    }
  }

  function stopDefAction(evt) {
    evt.preventDefault();
    handleOnSubmit(evt.target);
  }
  return (
    <div className="mb-3">
      <form onSubmit={stopDefAction}>
        <h1 className="form-title">Cadastro de Ambiente</h1>
        <Inputfield name="Description" type="text" />
        <Inputfield name="Ocupado" type="checkbox" />
        <Submitfield name="Confirmar" />
      </form>
    </div>
  );
}

export default Ambient;
