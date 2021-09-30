import React, { useEffect } from 'react';
import API from '../../api/base';
import Inputfield from '../../Components/inputfield';
import Submitfield from '../../Components/submitfield';

export default function License() {
  let form = {
    title: '',
    numberServices: 0,
    numberOrders: 0,
  };

  async function handleOnSubmit(data) {
    if (typeof data !== 'undefined') {
      form = {
        title: data.title.value,
        numberServices: data.numberServices.value,
        numberOrders: data.numberOrders.value,
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
  // document.getElementsByName('Logar').preventDefault();
  return (
    <div className="mb-3">
      <form onSubmit={stopDefAction}>
        <h1 className="form-title">Lincença</h1>
        <Inputfield name="title" type="text" />
        <Inputfield name="numberServices" type="number" />
        <Inputfield name="numberOrders" type="number" />
        <Submitfield name="Logar" />
      </form>
    </div>
  );
}
