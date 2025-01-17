# Documentação da API

## Endpoints da API de Produtos

Abaixo está a documentação dos endpoints disponíveis para a API de produtos, incluindo exemplos de requisições e estrutura dos dados de entrada e saída.

---

### 1. Listar Todos os Produtos

- **URL**: `/api/Product`
- **Método**: `GET`
- **Descrição**: Retorna uma lista de todos os produtos cadastrados no sistema.

**Exemplo de Resposta**:

```json
[
  {
    "id": 1,
    "name": "Produto A",
    "address": "Endereço A",
    "price": 100.50
  },
  {
    "id": 2,
    "name": "Produto B",
    "address": "Endereço B",
    "price": 200.75
  }
]
```

---

### 2. Obter Produto por ID

- **URL**: `/api/Product/{id}`
- **Método**: `GET`
- **Descrição**: Retorna os detalhes de um produto específico pelo ID fornecido.

**Parâmetro de URL**:
- `id` (obrigatório): ID do produto a ser retornado.

**Exemplo de Resposta - Sucesso (200 OK)**:

```json
{
  "id": 1,
  "name": "Produto A",
  "address": "Endereço A",
  "price": 100.50
}
```

**Exemplo de Resposta - Erro (404 Not Found)**:

```json
{
  "error": "Produto não encontrado"
}
```

---

### 3. Criar Produto

- **URL**: `/api/Product`
- **Método**: `POST`
- **Descrição**: Cria um novo produto no sistema.

**Corpo da Requisição**:

```json
{
  "name": "Produto C",
  "address": "Endereço C",
  "price": 300.99
}
```

**Exemplo de Resposta - Sucesso (201 Created)**:

```json
{
  "id": 3,
  "name": "Produto C",
  "address": "Endereço C",
  "price": 300.99
}
```

---

### 4. Atualizar Produto

- **URL**: `/api/Product/{id}`
- **Método**: `PUT`
- **Descrição**: Atualiza os dados de um produto existente no sistema.

**Parâmetro de URL**:
- `id` (obrigatório): ID do produto a ser atualizado.

**Corpo da Requisição**:

```json
{
  "name": "Produto A Atualizado",
  "address": "Endereço A Atualizado",
  "price": 150.00
}
```

**Exemplo de Resposta - Sucesso (200 OK)**:

```json
{
  "message": "Produto atualizado com sucesso"
}
```

**Exemplo de Resposta - Erro (404 Not Found)**:

```json
{
  "error": "Produto não encontrado"
}
```

---

### 5. Deletar Produto

- **URL**: `/api/Product/{id}`
- **Método**: `DELETE`
- **Descrição**: Remove um produto do sistema.

**Parâmetro de URL**:
- `id` (obrigatório): ID do produto a ser removido.

**Exemplo de Resposta - Sucesso (200 OK)**:

```json
{
  "message": "Produto removido com sucesso"
}
```

**Exemplo de Resposta - Erro (404 Not Found)**:

```json
{
  "error": "Produto não encontrado"
}
```

---

## Observações
- Certifique-se de usar os IDs corretos para acessar, atualizar ou deletar os produtos.
- A API responde com mensagens padronizadas para erros e sucessos, facilitando a depuração e integração.
- Para futuras implementações, recomenda-se adicionar autenticação e controle de permissões para maior segurança.
