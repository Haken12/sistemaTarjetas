 CREATE FUNCTION tarjeta_existe
 (@codigo int)
 RETURNS int
 AS
 BEGIN
 DECLARE @n int
 SET @n = (SELECT COUNT(codigo_tarjeta) FROM tarjeta WHERE tarjeta.codigo_tarjeta = @codigo)
 RETURN @n
 END