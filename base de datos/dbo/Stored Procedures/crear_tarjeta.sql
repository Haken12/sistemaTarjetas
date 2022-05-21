CREATE PROCEDURE crear_tarjeta
(@nombre varchar(50),
 @referencia varchar(50),
 @cedula varchar(13),
 @telefono varchar(20),
 @fecha_creacion date,
 @id_vendedor int,
 @id_zona int,
 @tipo_pago varchar(20))
AS
INSERT INTO tarjeta
 (nombre,referencia,cedula,telefono,fecha_creacion,id_vendedor,id_zona,tipo_pago,debito,credito,balance)
VALUES (@nombre,@referencia,@cedula,@telefono,@fecha_creacion,@id_vendedor,@id_zona,@tipo_pago,0,0,0);
