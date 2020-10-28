
 CREATE PROCEDURE v_detalles_tarjeta
 (@codigo int)
 AS
 SELECT
 numero_detalle [No.]
 ,fecha_detalle [Fecha]
 ,tipo [Tipo]
 ,debito [Debito]
 ,credito[Credito]
 ,referencia [Referencia]
 FROM detalle_tarjeta WHERE detalle_tarjeta.codigo_tarjeta = @codigo;