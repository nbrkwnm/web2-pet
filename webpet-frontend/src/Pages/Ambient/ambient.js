import React, { useEffect } from 'react';
import Inputfield from '../../Components/inputfield';
import Submitfield from '../../Components/submitfield';
import API from '../../api/base';

function Ambient() {
  let form = {
    description: '',
    isOccupied: '',
  };

  async function handleOnSubmit(data) {
    if (typeof data !== 'undefined') {
      form = {
        description: data.Description.value,
        isOccupied: data.IsOccupied.checked,
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
  return (
    <div className="mb-3">
      <form onSubmit={stopDefAction}>
        <h1 className="form-title">Cadastro de Ambiente</h1>
        <Inputfield name="Description" type="text" />
        <Inputfield name="Ocupado ?" type="checkbox" />
        <Submitfield name="Confirmar" />
      </form>
    </div>
  );
}

export default Ambient;
