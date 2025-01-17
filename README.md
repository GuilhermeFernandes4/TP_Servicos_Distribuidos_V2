# Nome do Projeto- House_API

Este projeto é uma API RESTful que gerencia produtos imobiliários. A aplicação utiliza um banco de dados PostgreSQL e foi projetada para execução em containers Docker.

---

## Informações Acadêmicas

- **Unidade Curricular**: Serviços Distribuídos
- **Professor**: Wenderson Wanzeller
- **Aluno**: Guilherme Fernandes e Vinicius Santos
- **Matrícula**: 32186 / 32193
- **Ano Letivo**: 2024/2025
- **Instituição de Ensino**: [ESTG/IPVC]

---

## Funcionalidades

- API RESTful com suporte aos métodos HTTP: GET, POST, PUT, DELETE.
- Integração com banco de dados PostgreSQL para gerenciar informações de produtos.
- Imagem Docker configurada para facilitar a implantação.
- Configuração de rede personalizada no Docker.
- Documentação da API e suporte para testes com Postman.

---

## Requisitos

Para executar este sistema, você precisará dos seguintes itens instalados:

- Docker (versão atualizada).
- Git.
- Postman (opcional, para testar as rotas da API).

---

## Como Executar

### Passo 1: Clonar o Repositório

Execute o comando abaixo para clonar o repositório do GitHub:

```bash
git clone <https://github.com/GuilhermeFernandes4/TP_Servicos_Distribuidos_V2/branches>
```

Acesse o diretório do projeto:

```bash
cd TP_Servicos_Distribuidos_V2
```

---

### Passo 2: Configurar o Banco de Dados

O banco de dados utilizado pela aplicação é o PostgreSQL. As configurações padrão são as seguintes:

- **Nome do Banco de Dados**: HouseDB
- **Usuário**: postgres
- **Senha**: Mascote2004.
- **Porta**: 5432

Estas informações estão definidas no arquivo `docker-compose.yml` e podem ser alteradas conforme necessário.

---

### Passo 3: Executar a Aplicação com Docker

Certifique-se de que o Docker está em execução e utilize o comando abaixo para construir e executar a aplicação:

```bash
docker-compose up
```

Isso iniciará a aplicação e ela estará disponível no endereço: http://localhost:5003.

---

### Passo 4: Testar as Rotas da API

A API pode ser testada utilizando ferramentas como o Postman. Todas as rotas e detalhes de requisição estão documentados no arquivo `API.md`. Além disso, você pode importar o arquivo de coleção do Postman incluído no repositório para facilitar os testes.

---

## Estrutura do Repositório

- **API.md**: Documentação detalhada das rotas da API.
- **docker-compose.yml**: Configuração para executar a aplicação em containers Docker.
- **ProductDBContext.cs**: Contexto do banco de dados utilizando Entity Framework Core.
- **Migrations**: Arquivos de migração para configurar o banco de dados.
- **postman_collection.json**: Arquivo de coleção do Postman para facilitar os testes.
- **src/**: Código-fonte da aplicação.

---

## Banco de Dados

O banco de dados utilizado armazena informações de produtos imobiliários com os seguintes campos:

- **Id** (integer, chave primária)
- **Name** (string, opcional)
- **Address** (string, obrigatório)
- **Price** (decimal, obrigatório)

---

## Endpoints Disponíveis

Segue a lista dos principais endpoints descritos no arquivo `API.md`:

1. **Listar Todos os Produtos**:
   - URL: `/api/Product`
   - Método: `GET`
   - Descrição: Retorna todos os produtos cadastrados.

2. **Obter Produto por ID**:
   - URL: `/api/Product/{id}`
   - Método: `GET`
   - Descrição: Retorna um produto específico pelo ID.

3. **Criar Produto**:
   - URL: `/api/Product`
   - Método: `POST`
   - Descrição: Adiciona um novo produto.

4. **Atualizar Produto**:
   - URL: `/api/Product/{id}`
   - Método: `PUT`
   - Descrição: Atualiza um produto existente.

5. **Deletar Produto**:
   - URL: `/api/Product/{id}`
   - Método: `DELETE`
   - Descrição: Remove um produto do sistema.

Para mais detalhes, consulte o arquivo `API.md`.

---

## Licença

Este projeto está licenciado sob a Licença MIT. Consulte o arquivo LICENSE para mais informações.

---

## Notas Adicionais

- Rede Docker personalizada configurada como `my_custom_Network`.
- Certifique-se de que a porta 5003 esteja disponível no seu sistema para executar a aplicação.
- Para mais detalhes técnicos, consulte os arquivos no repositório.

