CREATE PROCEDURE crear_vendedor_sa
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

INSERT INTO vendedor (nombre,cedula,direccion,celular,telefono,comision,deduccion,fecha_ingreso,id_ayudante)
VALUES
(@nombre,@cedula,@direccion,@celular,@telefono,@comision,@deduccion,@fecha_ingreso,0);

GO

CREATE PROCEDURE crear_vendedor_ca
(@nombre varchar(50),
 @cedula varchar(13),
 @direccion varchar(50),
 @celular varchar(20),
 @telefono varchar(20),
 @comision decimal(5,2),
 @deduccion decimal(5,2),
 @fecha_ingreso date,
 @id_ayudante int
)

AS 

INSERT INTO vendedor (nombre,cedula,direccion,celular,telefono,comision,deduccion,fecha_ingreso,id_ayudante)
VALUES
(@nombre,@cedula,@direccion,@celular,@telefono,@comision,@deduccion,@fecha_ingreso,@id_ayudante);


GO


CREATE PROCEDURE actualizar_vendedor
(@id_vendedor int,
 @nombre varchar(50),
 @cedula varchar(13),
 @direccion varchar(50),
 @celular varchar(20),
 @telefono varchar(20),
 @comision decimal(5,2),
 @deduccion decimal(5,2),
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

GO


CREATE PROCEDURE eliminar_vendedor
(@id_vendedor int)
AS
DELETE FROM vendedor 
WHERE vendedor.id_vendedor = @id_vendedor;

GO

CREATE PROCEDURE unico_vendedor
(@id int,
 @nombre varchar(50) OUT,
 @cedula varchar(13) OUT,
 @direccion varchar(50) OUT,
 @telefono varchar(20) OUT,
 @celular varchar(20) OUT,
 @comision decimal(5,2) OUT,
 @deduccion decimal(5,2)OUT,
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

GO

CREATE VIEW vVendedores
AS
SELECT
vendedor.id_vendedor [Id],
vendedor.nombre [Nombre],
vendedor.cedula [Cedula],
vendedor.direccion [Direccion],
vendedor.telefono [Telefono],
vendedor.celular [Celular],
vendedor.comision [Comision],
vendedor.deduccion [Deduccion],
vendedor.fecha_ingreso [Ingreso],
ayudante.id_ayudante,
ayudante.nombre [Ayudante]
FROM 
vendedor INNER JOIN ayudante
ON vendedor.id_ayudante = ayudante.id_ayudante;


select * from vendedor;

select * from ayudante;
