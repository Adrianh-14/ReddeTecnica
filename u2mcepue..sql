


create database PruebaTecnica
use PruebaTecnica


create table Empresas
(
Id int primary key identity(1,1),
Rnc varchar(11),
Nombre varchar (40),
NombreComercial varchar(60),
Categoria varchar(60),
EsquemaPagos varchar(100),
ActividadEconomica varchar(120),
RamaGubernamental varchar(120),
Estado varchar(20)

);
--///////////////////////////////////////
create procedure Crear_empresa
@Rnc varchar(11),
@Nombre varchar (40),
@NombreComercial varchar(60),
@Categoria varchar(60),
@EsquemaPagos varchar(100),
@ActividadEconomica varchar(120),
@RamaGubernamental varchar(120)
as
begin
 SET NOCOUNT ON;
 insert into Empresas(Rnc, Nombre, NombreComercial, Categoria, EsquemaPagos, ActividadEconomica, RamaGubernamental) values
 (@Rnc,@Nombre, @NombreComercial,@Categoria,@EsquemaPagos ,@ActividadEconomica,@RamaGubernamental)
 end
 go

 --/////////////////////////////////////////////////

 create procedure Obtener_Empresa
 @Id int 

as
begin
 SET NOCOUNT ON;

 select * from Empresas
 where Id = @Id

 end
 go

 --////////////////////////////////////////////////
 create procedure Actualizar_Empresa
 @Id int,
 @Nombre varchar (40),
@NombreComercial varchar(60),
@Categoria varchar(60),
@EsquemaPagos varchar(100),
@ActividadEconomica varchar(120),
@RamaGubernamental varchar(120)

as
begin
 SET NOCOUNT ON;
update Empresas
set Nombre =  @Nombre, 
NombreComercial = @NombreComercial,
categoria = @Categoria,
EsquemaPagos = @EsquemaPagos,
ActividadEconomica = @ActividadEconomica,
RamaGubernamental = @RamaGubernamental
where Id   = @Id
 end
 go

 --//////////////////////////////////////////

 create procedure Eliminar_Empresas
 @Id int 

as
begin
 SET NOCOUNT ON;

 delete  from Empresas
 where Id = @Id

 end
 go

 --/////////////////////////////////////////
 create procedure ObtenerTodas_Empresa


as
begin
 SET NOCOUNT ON;

 select * from Empresas

 end
 go

