# 🌐 APICompleteExample

<p align="center">
  <img src="https://img.shields.io/badge/.NET-7.0-blue" alt=".NET 7.0" />
  <img src="https://img.shields.io/badge/ASP.NET_Core-Web_API-informational" alt="ASP.NET Core Web API" />
  <img src="https://img.shields.io/badge/Blazor-Server-lightgrey" alt="Blazor Server" />
  <img src="https://img.shields.io/badge/Entity_Framework-Core-success" alt="EF Core" />
  <img src="https://img.shields.io/badge/PowerShell-Script-yellow" alt="PowerShell" />
  <img src="https://img.shields.io/badge/License-MIT-brightgreen" alt="MIT License" />
</p>

> Um exemplo completo de aplicação com **ASP.NET Core Web API** no backend e **Blazor Server** no frontend, incluindo um script PowerShell para geração automática de modelos a partir de um banco de dados SQL Server.

---

## 📑 Sumário

- [🚀 Sobre o Projeto](#🚀-sobre-o-projeto)
- [⚙️ Tecnologias](#⚙️-tecnologias)
- [📋 Pré-requisitos](#📋-pré-requisitos)
- [🏗️ Instalação](#🏗️-instalação)
- [🔧 Configuração](#🔧-configuração)
- [▶️ Uso](#▶️-uso)
- [📂 Estrutura do Projeto](#📂-estrutura-do-projeto)
- [🤝 Contribuindo](#🤝-contribuindo)
- [📄 Licença](#📄-licença)
- [👤 Autor](#👤-autor)

---

## 🚀 Sobre o Projeto

**APICompleteExample** é um template full-stack em .NET que demonstra como:

1. Construir uma **Web API** com **ASP.NET Core**  
2. Consumir essa API em um **frontend Blazor Server**  
3. Gerar automaticamente classes de modelo C# a partir de um banco **SQL Server** via PowerShell e Entity Framework Core  

Use este projeto como ponto de partida para suas aplicações corporativas ou estudos de integração backend-frontend em .NET.

---

## ⚙️ Tecnologias

| Camada           | Tecnologia                   |
|------------------|------------------------------|
| 🏷️ Backend       | ASP.NET Core Web API         |
| 🛠️ ORM           | Entity Framework Core        |
| 🌐 Frontend      | Blazor Server                |
| 💾 Banco de Dados| SQL Server                   |
| 📜 Script        | PowerShell (`createmodel.ps1`)|

---

## 📋 Pré-requisitos

- ✅ **.NET 7.0 SDK**  
- ✅ **SQL Server** (local ou remoto)  
- ✅ **PowerShell** (para executar o script de geração de modelos)  

---

## 🏗️ Instalação

```bash
# 1. Clone o repositório
git clone https://github.com/pepes1234/APICompleteExample.git
cd APICompleteExample
```

---

## 🔧 Configuração

1. **String de conexão**  
   Edite `backend/appsettings.json` (ou configure via variáveis de ambiente):

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=SEU_SERVIDOR;Database=SEU_BANCO;User Id=usuario;Password=senha;"
     }
   }
   ```

2. **Gerar modelos**  
   No diretório `backend`, execute:

   ```powershell
   .\createmodel.ps1 \
     -connectionString "Server=SEU_SERVIDOR;Database=SEU_BANCO;User Id=usuario;Password=senha;" \
     -outputFolder "Models"
   ```

   Isso criará classes C# em `backend/Models/` correspondentes às tabelas do seu banco.

---

## ▶️ Uso

### 🖥️ Backend (Web API)

```bash
cd backend
dotnet run
```

- Acesse a API em `https://localhost:5001` ou `http://localhost:5000`.

### 🌐 Frontend (Blazor Server)

```bash
cd frontend
dotnet run
```

- Abra o navegador em `https://localhost:6001` (porta exibida no terminal).

---

## 📂 Estrutura do Projeto

```plaintext
APICompleteExample/
├── backend/                  
│   ├── Controllers/          # Endpoints da Web API
│   ├── Data/                 # DbContext e Migrations
│   ├── Models/               # Classes geradas pelo script
│   ├── createmodel.ps1       # Script PowerShell de geração de modelos
│   ├── Program.cs            
│   └── appsettings.json      # Strings de conexão
├── frontend/                 
│   ├── Pages/                # Páginas Blazor
│   ├── Shared/               # Componentes compartilhados
│   ├── Program.cs            
│   └── appsettings.json      # Configuração de serviço/API
├── .gitignore                 
├── LICENSE                    
└── README.md                  
```

---

## 🤝 Contribuindo

1. 🍴 **Fork** este repositório  
2. 🏷️ Crie uma branch:
   ```bash
git checkout -b feature/sua-feature
   ```  
3. 💾 Faça commit das mudanças:
   ```bash
git commit -m "✨ Descreva sua feature"
   ```  
4. 📤 Envie para o repositório remoto:
   ```bash
git push origin feature/sua-feature
   ```  
5. 📬 Abra um Pull Request  

---

## 📄 Licença

Este projeto está sob a **MIT License**. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

## 👤 Autor

Desenvolvido com ❤️ por [@pepes1234](https://github.com/pepes1234)