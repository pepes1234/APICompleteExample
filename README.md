# 🌐 APICompleteExample

<p align="center">
  <img src="https://img.shields.io/badge/.NET-7.0-blue" alt=".NET 7.0" />
  <img src="https://img.shields.io/badge/ASP.NET_Core-Web_API-informational" alt="ASP.NET Core Web API" />
  <img src="https://img.shields.io/badge/Blazor-Server-lightgrey" alt="Blazor Server" />
  <img src="https://img.shields.io/badge/Entity_Framework-Core-success" alt="EF Core" />
  <img src="https://img.shields.io/badge/PowerShell-Script-yellow" alt="PowerShell" />
  <img src="https://img.shields.io/badge/License-MIT-brightgreen" alt="MIT License" />
</p>

> Um exemplo completo de aplicação com **ASP.NET Core Web API** no backend e **Blazor Server** no frontend, incluindo script de geração de modelos a partir de um banco de dados SQL Server.

---

## 📑 Sumário

- [Sobre o Projeto](#sobre-o-projeto)
- [Tecnologias](#tecnologias)
- [Pré-requisitos](#pré-requisitos)
- [Instalação](#instalação)
- [Configuração](#configuração)
- [Uso](#uso)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Contribuindo](#contribuindo)
- [Licença](#licença)
- [Autor](#autor)

---

## 💡 Sobre o Projeto

O **APICompleteExample** é uma aplicação demonstrativa que mostra como criar uma **Web API** robusta com **ASP.NET Core** e consumir essa API em um **frontend Blazor Server**. Além disso, inclui um script PowerShell (`createmodel.ps1`) para gerar classes de modelo a partir das tabelas de um banco de dados **SQL Server**, facilitando o uso do **Entity Framework Core**.

Use este template para acelerar o desenvolvimento de projetos full-stack em .NET, seguir boas práticas de organização de código e aprender como integrar backend e frontend de forma coerente.

---

## ⚙️ Tecnologias

| Camada     | Tecnologia                  |
|------------|-----------------------------|
| Backend    | ASP.NET Core Web API        |
| ORM        | Entity Framework Core       |
| Frontend   | Blazor Server               |
| Banco de Dados | SQL Server              |
| Script     | PowerShell (`.ps1`)         |

---

## 📋 Pré-requisitos

1. **.NET 7.0 SDK** instalado
2. **SQL Server** (local ou remoto) disponível
3. **PowerShell** (para executar o script de geração de modelos)

---

## 🏗️ Instalação

Clone o repositório e navegue até a pasta raiz:

```bash
git clone https://github.com/pepes1234/APICompleteExample.git
cd APICompleteExample
```

---

## 🔧 Configuração

1. **Configurar string de conexão**

   Edite o arquivo `backend/appsettings.json` (ou use variáveis de ambiente) para apontar para seu servidor SQL Server:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=MEU_SERVIDOR;Database=MeuBanco;User Id=usuario;Password=senha;"
     }
   }
   ```

2. **Gerar modelos a partir do banco**

   No diretório `backend`, execute o script PowerShell `createmodel.ps1`:

   ```powershell
   .\createmodel.ps1 -connectionString "Server=MEU_SERVIDOR;Database=MeuBanco;User Id=usuario;Password=senha;" -outputFolder "Models"
   ```

   Isso criará classes C# em `backend/Models/` correspondentes às tabelas do seu banco.

---

## ▶️ Uso

### Backend (Web API)

1. Abra o terminal no diretório `backend`:
   ```bash
   cd backend
   ```
2. Execute a API:
   ```bash
   dotnet run
   ```
3. A API ficará disponível em `https://localhost:5001` e `http://localhost:5000`.

### Frontend (Blazor Server)

1. Abra novo terminal no diretório `frontend`:
   ```bash
   cd frontend
   ```
2. Execute a aplicação Blazor:
   ```bash
   dotnet run
   ```
3. Acesse `https://localhost:6001` (ou porta indicada) para usar o frontend.

---

## 📂 Estrutura do Projeto

```plaintext
APICompleteExample/
├── backend/
│   ├── Controllers/          # Endpoints da Web API
│   ├── Models/               # Classes de entidade (geradas via script)
│   ├── Data/                 # DbContext e migrations
│   ├── createmodel.ps1       # Script PowerShell de geração de modelos
│   ├── Program.cs
│   └── appsettings.json      # Configurações de conexão
├── frontend/
│   ├── Pages/                # Páginas Blazor
│   ├── Shared/               # Componentes compartilhados
│   ├── Program.cs
│   └── appsettings.json      # Configurações de rota/serviço
├── .gitignore
├── LICENSE
└── README.md
```

---

## 🤝 Contribuindo

1. Faça um **fork** 🍴
2. Crie uma **branch**: `feature/minha-feature`
3. Faça **commit** das alterações: `git commit -m "✨ adiciona minha feature"`
4. **Push** para a branch: `git push origin feature/minha-feature`
5. Abra um **Pull Request** 🚀

Por favor, siga o padrão de nomenclatura de branches e boas práticas de commits.

---
