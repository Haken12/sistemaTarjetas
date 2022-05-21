
CREATE PROCEDURE [dbo].[unico_vendedor]
(@id int,
 @nombre varchar(50) OUT,
 @cedula varchar(13) OUT,
 @direccion varchar(50) OUT,
 @telefono varchar(20) OUT,
 @celular varchar(20) OUT,
 @comision int out,
 @deduccion int out,
 @fecha_ingreso date OUT,
 @id_ayudante int OUT)

AS

SELECT
@nombre = vendedor.nombre,
@cedula = vendedor.cedula,
@direccion = vendedor.direccion,
@telefono = vendedor.telefono,
@celular = vendedor.celular,
@comision = vendedor.comision,
@deduccion = vendedor.deduccion,
@fecha_ingreso = vendedor.fecha_ingreso,
@id_ayudante = vendedor.id_ayudante
FROM vendedor WHERE 
vendedor.id_vendedor = @id;

