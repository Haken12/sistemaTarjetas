CREATE PROCEDURE crear_tarjeta
(@codigo_cliente int,
 @fecha_creacion date,
 @id_vendedor int,
 @id_zona int,
 @tipo_pago varchar(20))
AS
INSERT INTO tarjeta (codigo_cliente,fecha_creacion,id_vendedor,id_zona,tipo_pago)
VALUES (@codigo_cliente,@fecha_creacion,@id_vendedor,@id_zona,@tipo_pago);

GO

CREATE PROCEDURE actualizar_tarjeta
(@codigo_tarjeta int,
 @codigo_cliente int,
 @fecha_creacion date,
 @id_vendedor int,
 @id_zona int,
 @tipo_pago varchar(20))
 AS
 UPDATE tarjeta
 SET
 codigo_cliente = @codigo_cliente,
 fecha_creacion = @fecha_creacion,
 id_vendedor = @id_vendedor,
 id_zona = @id_zona,
 tipo_pago = @tipo_pago
 WHERE tarjeta.codigo_tarjeta = @codigo_tarjeta;

 GO

 CREATE PROCEDURE eliminar_tarjeta
 (@codigo_tarjeta int)
 AS
 DELETE FROM tarjeta
 WHERE tarjeta.codigo_tarjeta = @codigo_tarjeta;

 GO

 CREATE VIEW vTarjetas
 AS
 SELECT 
 tarjeta.codigo_tarjeta [Codigo],
 tarjeta.fecha_creacion [Fecha],
 tarjeta.tipo_pago [Forma de Pago],
 cliente.nombre [Cliente],
 vendedor.nombre [Vendedor],
 zona.descripcion [Zona]

 FROM 
 tarjeta INNER JOIN cliente ON tarjeta.codigo_cliente = cliente.codigo_cliente
 INNER JOIN vendedor ON tarjeta.id_vendedor = vendedor.id_vendedor
 INNER JOIN zona ON tarjeta.id_zona = zona.id_zona;

 GO 

 CREATE PROCEDURE unica_tarjeta
 (@codigo int,
  @codigo_cliente int OUT,
 @fecha_creacion date OUT,
 @id_vendedor int OUT,
 @id_zona int OUT,
 @tipo_pago varchar(20) OUT)
 AS
 SELECT
 @codigo_cliente =cliente.codigo_cliente,
 @fecha_creacion = tarjeta.fecha_creacion ,
 @tipo_pago = tarjeta.tipo_pago ,
 @id_vendedor = vendedor.id_vendedor ,
 @id_zona = zona.id_zona 
 FROM 
tarjeta INNER JOIN cliente ON tarjeta.codigo_cliente = cliente.codigo_cliente
 INNER JOIN vendedor ON tarjeta.id_vendedor = vendedor.id_vendedor
 INNER JOIN zona ON tarjeta.id_zona = zona.id_zona

 WHERE tarjeta.codigo_tarjeta = @codigo;

 GO

 CREATE PROCEDURE unica_tarjeta_completa
 (@codigo int,
  @codigo_cliente int OUT,
 @fecha_creacion date OUT,
 @id_vendedor int OUT,
 @id_zona int OUT,
 @tipo_pago varchar(20) OUT)
 AS
 SELECT
  tarjeta.codigo_tarjeta [Codigo],
 tarjeta.fecha_creacion [Fecha],
 tarjeta.tipo_pago [Forma de Pago],
 cliente.nombre [Cliente],
 cliente.cedula [Cedula],
 cliente.direccion [Direccion],
 cliente.telefono [Telefono],
 vendedor.nombre [Vendedor],
 zona.descripcion [Zona]
 FROM 
tarjeta INNER JOIN cliente ON tarjeta.codigo_cliente = cliente.codigo_cliente
 INNER JOIN vendedor ON tarjeta.id_vendedor = vendedor.id_vendedor
 INNER JOIN zona ON tarjeta.id_zona = zona.id_zona

 WHERE tarjeta.codigo_tarjeta = @codigo;