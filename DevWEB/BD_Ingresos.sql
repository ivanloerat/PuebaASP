Create Database Ingresos

create table cUsuarios(
cUsuId int identity primary key,
cUsuAlias varchar(10),
cUsuNombre varchar(30),
cUsuPass varchar(20),
cUsuActivo bit,
cUsuAdministrador bit)

CREATE UNIQUE INDEX UX_cUsuarios   
   ON cUsuarios(cUsuAlias,cUsuPass);


Insert into cUsuarios select 'admin','administrador','admin01',1,1

Create Table hRegistros(
hRegId int identity primary key,
cUsuId int constraint fk_cUsuarios_cUsuId foreign key references cUsuarios (cUsuId),
hRegEntrada datetime,
hRegSalida datetime)



