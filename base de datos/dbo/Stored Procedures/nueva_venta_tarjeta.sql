CREATE PROCEDURE nueva_venta_tarjeta
(@codigo_tarjeta int,
 @fecha_detalle date,
 @importe int,
 @ref int)
 AS
 DECLARE @num int
 SET @num = (SELECT COUNT(numero_detalle) FROM detalle_tarjeta WHERE detalle_tarjeta.codigo_tarjeta = @codigo_tarjeta)
 INSERT INTO detalle_tarjeta(numero_detalle,codigo_tarjeta,fecha_detalle,tipo,debito,credito,referencia)
 VALUES
 (@num+1,@codigo_tarjeta,@fecha_detalle,'Venta',0,@importe,@ref);
 
