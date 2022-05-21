
CREATE PROCEDURE unico_ayudante
(@id int,
 @nombre varchar(50) OUT,
 @cedula varchar(13) OUT,
 @direccion varchar(50) OUT,
 @telefono varchar(20) OUT,
 @celular varchar(20) OUT,
 @comision int OUT,
 @deduccion int OUT,
 @fecha_ingreso date OUT)

AS

SELECT
@nombre = ayudante.nombre,
@cedula = ayudante.cedula,
@direccion = ayudante.direccion,
@telefono = ayudante.telefono,
@celular = ayudante.celular,
@comision = ayudante.comision,
@deduccion = ayudante.deduccion,
@fecha_ingreso = ayudante.fecha_ingreso
FROM ayudante WHERE 
ayudante.id_ayudante = @id;
