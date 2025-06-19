# Agência de Turismo - Projeto ASP.NET Core com Razor Pages e EF Core

Este projeto foi desenvolvido como parte da disciplina de **Desenvolvimento Web com .NET e Bases de Dados**.
Trata-se de um sistema educacional para gerenciamento de uma agência de turismo, onde são praticados conceitos fundamentais de ASP.NET Core, Razor Pages, Entity Framework Core e autenticação.

## Conteúdo por Exercício

| Exercício | Tema | Descrição |
|----------|------|-----------|
| 01 | Delegate | Cálculo de desconto com delegate simples |
| 02 | Multicast Delegate | Registro de logs em múltiplos destinos |
| 03 | `Func<T>` | Aplicações práticas de funções anônimas |
| 04 | Eventos | Disparo de evento em limite de capacidade |
| 05 | Cadastro simples | Formulário com validação de cidade |
| 06 | Objeto complexo | Cadastro de pacote turístico com cidade |
| 07 | Roteamento | Detalhamento via URL com `asp-route-id` |
| 08 | Arquivo | Sistema de notas usando leitura e escrita |
| 11 | CRUD e Scaffolding | CRUD completo com Razor Pages e EF Core |
| 12 | Exclusão lógica e autenticação | Soft delete e sistema de login com [Authorize] |

---

## Tecnologias Utilizadas

- ASP.NET Core 8 (Razor Pages)
- Entity Framework Core com SQLite
- C# 12
- Bootstrap 5 (via LibMan)
- Autenticação com `CookieAuthentication`
- Visual Studio 2022

---

## Executando o Projeto

1. **Clone o repositório:**

   ```bash
   git clone https://github.com/seu-usuario/AgenciaTurismo.git
   cd AgenciaTurismo/AgenciaTurismo
Restaure os pacotes e dependências:

O Visual Studio faz isso automaticamente, mas você também pode usar:
dotnet restore

Ajuste a string de conexão em Program.cs:
builder.Services.AddDbContext<DbContexto>(options =>
    options.UseSqlite("Data Source=agencia.db"));
    
Rode as migrações (caso necessário):
dotnet ef migrations add Inicial
dotnet ef database update

Execute a aplicação:
dotnet run

Acesse via navegador:
http://localhost:7000

## Login de Acesso
A aplicação exige login para acesso a páginas sensíveis (Exercício 12).
Usuário: admin
Senha: 1234

## Funcionalidades
✅ CRUD completo de Pacotes Turísticos
✅ Relacionamentos com Cidades e Países
✅ Validação com DataAnnotations
✅ Autenticação simples com cookie
✅ Exclusão lógica via DeletedAt
✅ Interface amigável com Bootstrap
✅ Roteamento dinâmico com parâmetros

## Estrutura do Projeto

AgenciaTurismo/
├── Models/
│   ├── Cliente.cs
│   ├── CidadeDestino.cs
│   ├── PaisDestino.cs
│   ├── PacoteTuristico.cs
│   └── Reserva.cs
├── Data/
│   └── DbContexto.cs
├── Pages/
│   ├── Exercicios/
│   │   └── Exercicio01 ~ Exercicio12/
│   ├── Conta/
│   │   ├── Login.cshtml
│   │   ├── Logout.cshtml
│   └── Shared/
├── wwwroot/
├── Program.cs
└── AgenciaTurismo.csproj

## Autor
Hebert Victor Bicalho de Almeida
Aluno de Engenharia de Software | 2º Período
Desenvolvimento focado em ASP.NET, Java, Python e Segurança Cibernética.

## Licença
Este projeto é acadêmico e sem fins lucrativos. Todos os direitos reservados ao autor.
