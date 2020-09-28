CREATE PROCEDURE crear_cliente
(@nombre varchar(50),
 @cedula varchar(13),
 @direccion varchar(50),
 @telefono varchar(20))
 AS
 INSERT INTO cliente(nombre,cedula,direccion,telefono)
 VALUES (@nombre,@cedula,@direccion,@telefono);

 GO


 CREATE PROCEDURE actualizar_cliente
 (@codigo_cliente int,
 @nombre varchar(50),
 @cedula varchar(13),
 @direccion varchar(50),
 @telefono varchar(20))
 AS
 UPDATE cliente
 SET
 nombre = @nombre,
 cedula = @cedula,
 direccion = @direccion,
 telefono = @telefono
 WHERE cliente.codigo_cliente = @codigo_cliente;

 GO


 CREATE PROCEDURE eliminar_cliente
 (@codigo_cliente int)
 AS
 DELETE FROM cliente
 WHERE cliente.codigo_cliente = @codigo_cliente;

 GO

 CREATE PROCEDURE unico_cliente
(@codigo_cliente int,
 @nombre varchar(50) OUT,
 @cedula varchar(13) OUT,
 @direccion varchar(50) OUT,
 @telefono varchar(20) OUT)
 AS
 SELECT
 @nombre = cliente.nombre,
 @cedula = cliente.cedula,
 @telefono = cliente.telefono,
 @direccion = cliente.direccion
 FROM
 cliente WHERE cliente.codigo_cliente = @codigo_cliente;

 GO

 CREATE VIEW vClientes
 AS
 SELECT 
 codigo_cliente [Codigo],
 nombre [Nombre],
 cedula [Cedula],
 telefono [Telefono],
 direccion [Direccion]
 FROM
 cliente;