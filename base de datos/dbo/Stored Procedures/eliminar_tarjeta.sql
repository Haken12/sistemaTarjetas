 CREATE PROCEDURE eliminar_tarjeta
 (@codigo_tarjeta int)
 AS
 DELETE FROM tarjeta
 WHERE tarjeta.codigo_tarjeta = @codigo_tarjeta;
