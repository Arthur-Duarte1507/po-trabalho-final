# Mercado Orion (WinForms)

## Como usar
- Requisite um banco PostgreSQL com a tabela `produtos` (o backup `MercadoOrionBackup.sql` contém o esquema e alguns dados).  
- Abra o app, informe host, porta, usuário, senha e nome do banco, então clique em **Guardar conexão**. O app testa a conexão na hora.
- Use **Atualizar** para listar os itens. Os botões **Adicionar**, **Editar** e **Remover** trabalham na linha selecionada do grid.

## Stack
- .NET 8 + Windows Forms
- Npgsql 9 para acesso ao PostgreSQL

## Build/execução
```bash
dotnet build MercadoOrion/MercadoOrion.App/MercadoOrion.App.csproj
dotnet run --project MercadoOrion/MercadoOrion.App/MercadoOrion.App.csproj
```