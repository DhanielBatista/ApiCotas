# Api
Api construída para o processo seletivo 

## Pre-requisitos

<br>

- Visual Studio 2019/2022
- NET Core 5.0
- SQL Server

<br>

## Detalhes

- TrinusAPi: serviço back-end para controle de cotistas e compra e
vendas de cotas da ação

<br>

## Configuração para execução da Api

- Abra a solução no visual studio
- Caso necessário, altere a string de conexão no arquivo appSettings.json para  usuario e senha do Servidor Sql local.

<br>

## Observações

- Exemplo de valor de schema para Cotista:

{<br>
  "nome": "string",<br>
  "cpf": "string",<br>
  "dataNascimento": "2022-06-11T20:37:29.712Z"<br>
}
- Exemplo de valor de schema para Operação:

{<br>
  "cotistaId": 0,<br>
  "tipoOperacao": 0,<br>
  "cotas": 0<br>
}
