# APICompleteExample

![.NET 7.0](https://img.shields.io/badge/.NET-7.0-blue) ![ASP.NET Core Web API](https://img.shields.io/badge/ASP.NET%20Core-Web%20API-green) ![EF Core](https://img.shields.io/badge/Entity%20Framework-Core-yellow) ![PowerShell](https://img.shields.io/badge/PowerShell-Script-blue) ![MIT License](https://img.shields.io/badge/License-MIT-lightgrey)

> Um exemplo completo de Web API em ASP.NET Core com Entity Framework Core, incluindo script SQL para criação de banco e PowerShell para geração de modelos C#.

---

## 📚 Sumário

- [Sobre o Projeto](#sobre-o-projeto)
- [Tecnologias](#tecnologias)
- [Pré-requisitos](#pré-requisitos)
- [Instalação](#instalação)
- [Configuração](#configuração)
- [Geração de Models](#geração-de-models)
- [Uso / Execução](#uso--execução)
- [Endpoints da API](#endpoints-da-api)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Contribuindo](#contribuindo)
- [Licença](#licença)
- [Autor](#autor)

---

## 💡 Sobre o Projeto

Este projeto demonstra como:

- Construir uma **Web API** RESTful com **ASP.NET Core 7.0**
- Mapear entidades e migrations com **Entity Framework Core**
- Gerar automaticamente classes de modelo a partir de um banco **SQL Server** via PowerShell
- Implementar registro e login de usuários com geração e validação de **tokens** simples (sem JWT)

---

## 🚀 Tecnologias

| Camada    | Tecnologia                    |
|-----------|-------------------------------|
| Backend   | ASP.NET Core Web API          |
| ORM       | Entity Framework Core         |
| Banco     | SQL Server                    |
| Scripting | PowerShell (`createmodel.ps1`)|

---

## ✅ Pré-requisitos

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download)
- SQL Server (instância local ou hospedada)
- PowerShell 5.1+

---

## 🛠️ Instalação

```bash
# 1. Clone o repositório
git clone https://github.com/pepes1234/APICompleteExample.git
cd APICompleteExample

# 2. (Opcional) Abra no VS Code / Visual Studio
code .
```

---

## ⚙️ Configuração

### Banco de Dados

- Execute o script SQL `backend/script.sql` no SQL Server para criar o banco e as tabelas.

```sql
USE master;
GO
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'Exemplo')
    DROP DATABASE Exemplo;
GO
CREATE DATABASE Exemplo;
GO
USE Exemplo;
GO
-- Criação de tabelas...
```

### String de Conexão

Edite o arquivo `backend/appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=SEU_SERVIDOR;Database=Exemplo;User Id=usuario;Password=senha;"
  }
}
```

---

## 🧱 Geração de Models

Execute o script PowerShell `createmodel.ps1` para gerar os modelos a partir do banco:

```powershell
.\createmodel.ps1 `
  -connectionString "Server=SEU_SERVIDOR;Database=Exemplo;User Id=usuario;Password=senha;" `
  -outputFolder "Model"
```

---

## ▶️ Uso / Execução

```bash
./createmodel.ps1 {String de conexão do seu banco} {Nome do banco(Exemplo)}
cd backend
dotnet run
```

A API estará disponível em:

- `https://localhost:5001`
- `http://localhost:5000`

---

## 📡 Endpoints da API

### 🔐 Usuário

- **Registrar novo usuário**
  - `GET /User/register/{Nome}/{Email}/{Senha}`
  - Exemplo:
    ```
    /User/register/JoaoSilva/joao@email.com/MinhaSenha123
    ```

- **Login**
  - `GET /User/Login`
  - Corpo JSON:
    ```json
    {
      "Nome": "JoaoSilva",
      "Senha": "MinhaSenha123"
    }
    ```
  - Retorna token como texto puro.

---

### 📝 Anotações

- **Salvar anotação**
  - `GET /Note/save`
  - Query ou JSON:
    ```json
    {
      "Title": "Minha Nota",
      "Conteudo": "Conteúdo aqui",
      "UsuarioId": 1
    }
    ```

- **Buscar anotações com paginação**
  - `GET /Note/getNotes/{pageNumber}-{notesPerPage}-{search?}`
  - Exemplo:
    ```
    /Note/getNotes/1-10-teste
    ```

---

## 🗂️ Estrutura do Projeto

```
APICompleteExample/
├── backend/
│   ├── Controllers/
│   ├── Model/
│   ├── Services/
│   ├── createmodel.ps1
│   ├── script.sql
│   ├── appsettings.json
│   └── backend.csproj
├── .gitignore
├── LICENSE
└── README.md
```

---
