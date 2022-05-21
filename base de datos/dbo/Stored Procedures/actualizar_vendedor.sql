
CREATE PROCEDURE actualizar_vendedor
(@id_vendedor int,
 @nombre varchar(50),
 @cedula varchar(13),
 @direccion varchar(50),
 @celular varchar(20),
 @telefono varchar(20),
 @comision int,
 @deduccion int,
 @fecha_ingreso date,
 @id_ayudante int
)
AS 
UPDATE vendedor 
SET
nombre =@nombre,
cedula = @cedula,
direccion = @direccion,
celular= @celular,
telefono= @telefono,
comision = @comision,
deduccion = @deduccion,
fecha_ingreso = @fecha_ingreso,
id_ayudante = @id_ayudante

WHERE vendedor.id_vendedor = @id_vendedor;

