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
      nome: 'Cliente',
      rota: 'user',
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
      nome: 'Linceça',
      rota: 'license',
    },
  ];

  function renderPages(page) {
    return <Button onClick={() => routeChange(page.rota)}>{page.nome}</Button>;
  }

  return (
  // eslint-disable-next-line react/no-this-in-sfc
    <h1>{pages.map(renderPages)}</h1>
  );
}
