CREATE PROCEDURE unica_tarjeta
(@codigo_tarjeta int,
 @nombre varchar(50) OUT,
 @referencia varchar(50)OUT,
 @cedula varchar(13) OUT,
 @telefono varchar(20) OUT,
 @fecha_creacion date OUT,
 @id_vendedor int OUT,
 @id_zona int OUT,
 @tipo_pago varchar(20) OUT)
 AS
 SELECT
 @nombre = tarjeta.nombre,
 @referencia = tarjeta.referencia,
 @cedula = tarjeta.cedula,
 @telefono = tarjeta.telefono,
 @fecha_creacion = tarjeta.fecha_creacion,
 @tipo_pago = tarjeta.tipo_pago,
 @id_vendedor = vendedor.id_vendedor ,
 @id_zona = zona.id_zona
 FROM 
tarjeta INNER JOIN vendedor ON tarjeta.id_vendedor = vendedor.id_vendedor
 INNER JOIN zona ON tarjeta.id_zona = zona.id_zona

 WHERE tarjeta.codigo_tarjeta = @codigo_tarjeta;

