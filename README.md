# APICompleteExample
entrar nas pastas:
cd backend
cd frontend
sair das pastas:
cd ..

criação backend:
dotnet new webapi

criação frontend:
dotnet new blazorserver

conexão com o banco: 
rodar createmodel.ps1 no baceknd passando
.\createmodel.ps1 {string d conexão} {Nome do banco}

para usar o toListAsync/FirstOrDefaultAsync, precisa de 
using Microsoft.EntityFrameworkCore;

