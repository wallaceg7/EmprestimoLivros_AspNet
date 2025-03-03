# Plataforma de Empréstimo de Livros

## Descrição do Projeto
Este é um sistema para gerenciamento de empréstimos de livros, permitindo o controle dos livros emprestados entre usuários. O projeto segue os conceitos de CRUD (Create, Read, Update e Delete) e foi desenvolvido utilizando C# com o framework .NET.

## Tecnologias Utilizadas
- **C#**
- **.NET**
- **Entity Framework** (Code-First Approach)
- **SQL Server** (Banco de dados relacional)
- **Swagger** (Documentação da API)
- **MVC** (Controllers, Views, Models)
- **Logs** (Para monitoramento e depuração)
- **Migrations** (Gerenciamento de alterações no banco de dados)
- **Bootstrap, JavaScript e HTML** (Para a interface do usuário)

## Funcionalidades
- Cadastro e autenticação de usuários (Login)
- Cadastro de empréstimos de livros
- Consulta de empréstimos por ID
- Listagem de todos os empréstimos
- Edição de informações dos empréstimos
- Exclusão de empréstimos

## Estrutura das Classes
### Empréstimo
- **Id** (Identificador único)
- **Recebedor** (Quem recebe o livro)
- **Fornecedor** (Quem empresta o livro)
- **Nome do Livro**
- **Data do Empréstimo**

### Login
- **Id** (Identificador único)
- **Nome**
- **Sobrenome**
- **Email**
- **Senha** (Armazenada em formato hash)

## Como Executar o Projeto
1. Clone o repositório:
   ```sh
   git clone https://github.com/seuusuario/nome-do-repositorio.git
   ```
2. Acesse o diretório do projeto:
   ```sh
   cd nome-do-repositorio
   ```
3. Configure a string de conexão com o SQL Server no arquivo **appsettings.json**.
4. Execute as migrações do banco de dados:
   ```sh
   dotnet ef database update
   ```
5. Inicie a aplicação:
   ```sh
   dotnet run
   ```
6. Acesse a documentação Swagger:
   - `http://localhost:5000/swagger`

## Estrutura do Projeto
```
/plataforma-emprestimo-livros
│── Controllers
│   ├── EmprestimoController.cs
│   ├── LoginController.cs
│
│── Models
│   ├── Emprestimo.cs
│   ├── Login.cs
│
│── Data
│   ├── ApplicationDbContext.cs
│
│── Services
│   ├── EmprestimoService.cs
│   ├── LoginService.cs
│
│── Views
│   ├── Emprestimo
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   ├── Delete.cshtml
│   ├── Login
│       ├── Index.cshtml
│       ├── Register.cshtml
│
│── Logs
│── appsettings.json
│── Program.cs
│── Startup.cs
│── wwwroot (Bootstrap, JS, CSS)
```

## Contribuição
Contribuições são bem-vindas! Para isso:
1. Faça um fork do projeto.
2. Crie uma branch para sua funcionalidade: `git checkout -b minha-feature`
3. Faça commit das suas alterações: `git commit -m 'Adiciona nova funcionalidade'`
4. Envie para o repositório remoto: `git push origin minha-feature`
5. Abra um Pull Request.

## Licença
Este projeto está licenciado sob a MIT License - veja o arquivo [LICENSE](LICENSE) para mais detalhes.
