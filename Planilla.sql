--Creacion de base de datos Planilla
create database PLANILLA

/*PLanillas de pago*/
use PLANILLA
go



--Creando tablas

create table ISSS (
Nombre_Patrono varchar (50) not null,
Nombre_Empresa varchar(50) not null,
NIT varchar(20)not null,
Depa_Municipio varchar(50)not null,
Numero_Patronal varchar (10) not null,
Acti_Economica varchar(30)not null,
Telefono int not null,
Direc_Empresa varchar(50)not null,
Fecha_Emision varchar(20)not null,
Periodo_Pago varchar(50)not null,
Num_Afiliacion varchar(10)not null,
Nombreseguntarjeta varchar (25) not null,
Salario_Bruto decimal(10) not null,
Aguinaldo varchar(10),
Pago_Vacaciones varchar(10)not null,
Hrs_Extras int not null,
Hrs_Jornadas int not null,
Aporte_Laboral varchar(10)not null,
Aporte_Patronal varchar(10)not null,
Total varchar(10) not null,
);
select*from isss


create table AFP(
Periodo_Devengue varchar(30),
Identificacion_NT varchar(20),
Nom_Empresa varchar(40),
Razon_Social varchar(20),
Telefono varchar(10),
Direccion varchar(50),
Banco_Empleador varchar(50),
Num_Cuenta varchar(20),
NUP varchar(20),
Identificacion varchar(20),
Nombre_Afiliado varchar(50),
Apellido_Afliado varchar(50),
Ingreso_Base money,
Cotizacion_Voluntaria money,
Aporte_Patronal money,
Aporte_Laboral money,
Total money
);



create table PlanillaG(
NombreEmpleado varchar (60)not null,
Departamento varchar(20) not null,
SueldoBase varchar (10) not null,
HorasNormales  varchar (10) not null,
HorasExtra varchar (10) not null,
ISSS_Laboral varchar (10) not null,
ISSS_Patronal varchar(10) not null,
AFP_Laboral varchar(10) not null,
AFP_Patronal varchar(10) not null,
Total_Deduccion   varchar (10) not null,
SalarioNeto  varchar (10) not null
);
select*from PlanillaG

--Creando procedimientos almacenados

create procedure SP_VERAFP
as
select*from AFP

create procedure SP_VERISSS
as
select*from ISSS

create procedure SP_VERPLANILLAG
as
select*from PlanillaG

--Creando llaves primarias

alter table AFP add constraint pk_NUP primary key(NUP)

alter table ISSS add constraint pk_NIT primary key(NIT)

alter table PlanillaG add constraint pk_NIT_ primary key(NIT)