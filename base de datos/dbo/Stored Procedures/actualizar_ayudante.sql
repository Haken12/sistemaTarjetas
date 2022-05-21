
CREATE PROCEDURE actualizar_ayudante
(@id_ayudante int,
 @nombre varchar(50),
 @cedula varchar(13),
 @direccion varchar(50),
 @celular varchar(20),
 @telefono varchar(20),
 @comision int,
 @deduccion int,
 @fecha_ingreso date
)

AS 

UPDATE ayudante 
SET
nombre =@nombre,
cedula = @cedula,
direccion = @direccion,
celular= @celular,
telefono= @telefono,
comision = @comision,
deduccion = @deduccion,
fecha_ingreso = @fecha_ingreso

WHERE ayudante.id_ayudante = @id_ayudante;

