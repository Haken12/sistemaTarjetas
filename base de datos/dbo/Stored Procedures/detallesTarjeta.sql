
 CREATE PROCEDURE detallesTarjeta
 (@codigo int)
 AS
 SELECT
 numero_detalle [No.]
 ,fecha_detalle [Fecha]
 ,tipo [Tipo]
 ,debito [Debito]
 ,credito[credito]
 ,referencia [Referencia]
 FROM detalle_tarjeta WHERE detalle_tarjeta.codigo_tarjeta = @codigo;
