# Agência de Turismo: Projeto Web com ASP.NET Core, Razor Pages e EF Core

Este projeto, desenvolvido no âmbito da disciplina de **Desenvolvimento Web com .NET e Bases de Dados**, simula um sistema de gerenciamento para uma agência de turismo. Ele é uma vitrine prática de conceitos fundamentais do **ASP.NET Core**, **Razor Pages**, **Entity Framework Core** e **autenticação**, consolidando o aprendizado através de uma série de exercícios progressivos.

---

## Módulos e Funcionalidades

O projeto é estruturado em módulos, cada um explorando um conceito específico do desenvolvimento web, culminando em um sistema robusto de gerenciamento:

| Módulo | Tema | Descrição |
|---|---|---|
| **01** | Delegates | Implementação de cálculo de desconto com delegate simples. |
| **02** | Multicast Delegates | Registro de logs em múltiplos destinos utilizando multicast delegates. |
| **03** | `Func<T>` | Aplicações práticas de funções anônimas para maior flexibilidade no código. |
| **04** | Eventos | Disparo de eventos ao atingir um limite de capacidade, demonstrando comunicação entre componentes. |
| **05** | Validação Simples | Formulário de cadastro com validação de campos, especificamente para cidades. |
| **06** | Modelos Complexos | Cadastro de pacotes turísticos com relacionamento com o objeto `Cidade`. |
| **07** | Roteamento Personalizado | Detalhamento de informações via URL utilizando `asp-route-id` para navegação dinâmica. |
| **08** | Manipulação de Arquivos | Sistema de notas com operações de leitura e escrita em arquivos. |
| **11** | CRUD Completo | Implementação de operações **C**reate, **R**ead, **U**pdate e **D**elete com Razor Pages e Entity Framework Core. |
| **12** | Exclusão Lógica e Autenticação | Sistema de "soft delete" (exclusão lógica) e autenticação de usuários com `[Authorize]`. |

---

## Tecnologias e Ferramentas

* **ASP.NET Core 8** (Razor Pages)
* **Entity Framework Core** com **SQLite** (para armazenamento de dados)
* **C# 12**
* **Bootstrap 5** (gerenciado via LibMan para um design responsivo e moderno)
* **Autenticação por Cookie** (`CookieAuthentication`)
* **Visual Studio 2022**

---

## Como Executar o Projeto

Siga os passos abaixo para configurar e executar o projeto em seu ambiente local:

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/seu-usuario/AgenciaTurismo.git](https://github.com/seu-usuario/AgenciaTurismo.git)
    cd AgenciaTurismo/AgenciaTurismo
    ```

2.  **Restaure os pacotes e dependências:**
    O Visual Studio geralmente faz isso automaticamente. Caso contrário, execute:
    ```bash
    dotnet restore
    ```

3.  **Ajuste a string de conexão (se necessário):**
    Verifique e ajuste a string de conexão no arquivo `Program.cs`, se o seu ambiente exigir um caminho diferente para o banco de dados SQLite:
    ```csharp
    builder.Services.AddDbContext<DbContexto>(options =>
        options.UseSqlite("Data Source=agencia.db"));
    ```

4.  **Execute as migrações do banco de dados:**
    Se esta for a primeira vez que você executa o projeto ou se houver novas migrações, rode os comandos:
    ```bash
    dotnet ef migrations add Inicial
    dotnet ef database update
    ```

5.  **Inicie a aplicação:**
    ```bash
    dotnet run
    ```

6.  **Acesse via navegador:**
    Abra seu navegador e navegue para:
    [http://localhost:7000](http://localhost:7000)

---

## Credenciais de Acesso

A aplicação exige autenticação para acessar algumas páginas (Exercício 12). Utilize as seguintes credenciais:

* **Usuário:** `admin`
* **Senha:** `1234`

---

## Recursos Implementados

Este projeto demonstra a implementação das seguintes funcionalidades chave:

* ✅ **CRUD completo** para Pacotes Turísticos.
* ✅ **Relacionamentos** entre Cidades e Países.
* ✅ **Validação de dados** robusta com DataAnnotations.
* ✅ **Sistema de autenticação** simples baseado em cookies.
* ✅ **Exclusão lógica** de registros (`DeletedAt`).
* ✅ **Interface de usuário amigável** e responsiva com Bootstrap.
* ✅ **Roteamento dinâmico** de URLs com parâmetros.

---

## Autor

**Hebert Victor Bicalho de Almeida**
Aluno de Engenharia de Software | 2º Período

---

## Licença

Este projeto é de natureza **acadêmica** e não possui fins lucrativos. Todos os direitos reservados ao autor.
