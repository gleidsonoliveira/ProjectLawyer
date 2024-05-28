#Instalar o package no projeto de inicialização "Web"
Microsoft.EntityFrameworkCore.Design

#Instalar o package no projeto "ProjectLawyer.Data" 
Microsoft.EntityFrameworkCore.Tools
Pomelo.EntityFrameworkCore.MySql


# Comando para criar a primeira migração normal, apontando o contexto correto aser utilizado. 
# Obs:. Sempre utilizar essa quando existir dois contexto no projeto
Add-migration "CreateTablesAspNetIdentity" -Context "AuctionManagerDbContext"

# Obs:. Sempre utilizar essa quando existir dois contexto no projeto
update-database -Context "AuctionManagerDbContext"

# Comando para criar a primeira migração
add-migration "CreateAllTables"

# Comando para executar a migração no banco de dados.
update-database

# Comando para remover até uma migration especifica. 
Update-Database -migration:"NomeMigration"
Depois executar o Remove-Migration para remover a classe do migration e voltar a classe no Snapshot

# revertendo migração
Remove-Migration -Context "AuctionManagerDbContext"

#Geração dos scripts do banco de dados
script-migration

#Executar Migrations de um banco no outro
script-migration -From AddColumnOperationTypeIntoFareRoute -To AddTableMonitorLocation

Obs:
  Se a Migration parar e começar a dar problema, excluir a pasta Migration e deletar todas as tabelas, menos a tabela "__efmigrationshistory"
  Na tabela "__efmigrationshistory" deletar os registros



 
 Add-migration "CreateTableGenerateAuctionDocumentTemplate" -Context "AuctionManagerDbContext"
 Remove-Migration -Context "AuctionManagerDbContext"
 update-database -Context "AuctionManagerDbContext" --force