import React from 'react';
import { Button } from 'antd';
import { useHistory } from 'react-router-dom';

export default function Home() {
  const history = useHistory();
  const routeChange = (rota) => {
    const path = `/${rota}`;
    history.push(path);
  };

  const pages = [
    {
      nome: 'Cadastrar Cliente',
      rota: 'user',
    },
    {
      nome: 'Ver Cliente',
      rota: 'user_list',
    },
    {
      nome: 'Ambiente',
      rota: 'ambient',
    },
    {
      nome: 'Ver ambientes',
      rota: 'ambient_list',
    },
    {
      nome: 'Licença',
      rota: 'license',
    },
    {
      nome: 'Serviços',
      rota: 'services',
    },
    {
      nome: 'Ver Serviços',
      rota: 'services_list',
    },
  ];

  function renderPages(page) {
    return (
      <>
        <Button onClick={() => routeChange(page.rota)}>{page.nome}</Button>
        <br />
      </>
    );
  }

  return (
  // eslint-disable-next-line react/no-this-in-sfc
    <h1>{pages.map(renderPages)}</h1>
  );
}
