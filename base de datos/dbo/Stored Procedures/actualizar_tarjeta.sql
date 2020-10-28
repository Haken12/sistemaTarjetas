CREATE PROCEDURE actualizar_tarjeta
(@codigo_tarjeta int,
 @nombre varchar(50),
 @referencia varchar(50),
 @cedula varchar(13),
 @telefono varchar(20),
 @fecha_creacion date,
 @id_vendedor int,
 @id_zona int,
 @tipo_pago varchar(20),
 @debito int,
 @credito int,
 @balance int)
 AS
 UPDATE tarjeta
 SET
 nombre = @nombre,
 referencia = @referencia,
 cedula = @cedula,
 telefono = @telefono,
 fecha_creacion = @fecha_creacion,
 id_vendedor = @id_vendedor,
 id_zona = @id_zona,
 tipo_pago = @tipo_pago,
 debito = @debito,
 credito = @credito,
 balance = @balance
 WHERE tarjeta.codigo_tarjeta = @codigo_tarjeta;
