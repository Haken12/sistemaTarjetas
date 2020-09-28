CREATE PROCEDURE crear_ayudante
(@nombre varchar(50),
 @cedula varchar(13),
 @direccion varchar(50),
 @celular varchar(20),
 @telefono varchar(20),
 @comision decimal(5,2),
 @deduccion decimal(5,2),
 @fecha_ingreso date
)

AS 

INSERT INTO ayudante (nombre,cedula,direccion,celular,telefono,comision,deduccion,fecha_ingreso)
VALUES
(@nombre,@cedula,@direccion,@celular,@telefono,@comision,@deduccion,@fecha_ingreso);

GO

CREATE PROCEDURE actualizar_ayudante
(@id_ayudante int,
 @nombre varchar(50),
 @cedula varchar(13),
 @direccion varchar(50),
 @celular varchar(20),
 @telefono varchar(20),
 @comision decimal(5,2),
 @deduccion decimal(5,2),
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

GO

CREATE PROCEDURE eliminar_ayudante
(@id_ayudante int)
AS
DELETE FROM ayudante 
WHERE ayudante.id_ayudante = @id_ayudante;

GO

CREATE PROCEDURE unico_ayudante
(@id int,
 @nombre varchar(50) OUT,
 @cedula varchar(13) OUT,
 @direccion varchar(50) OUT,
 @telefono varchar(20) OUT,
 @celular varchar(20) OUT,
 @comision decimal(5,2) OUT,
 @deduccion decimal(5,2)OUT,
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
