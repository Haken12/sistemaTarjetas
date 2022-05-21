
CREATE PROCEDURE nuevo_detalle_devolucion
(@devolucion int,
 @articulo int,
 @numero int,
 @venta int,
 @detalle int,
 @cantidad int,
 @valor int)
 AS
	INSERT INTO detalle_devolucion(numero_devolucion,numero_detalle,codigo_articulo,cantidad,valor)
	VALUES (@devolucion,@numero,@articulo,@cantidad,@valor)

	UPDATE detalle_venta
	SET devueltos = (devueltos + @cantidad)
	WHERE numero_venta = @venta AND numero_detalle = @detalle

	DECLARE @total int
	SET @total = (SELECT SUM(valor) FROM detalle_devolucion WHERE numero_devolucion = @devolucion)
	
	UPDATE devoluciones 
	SET valor = @total 
	WHERE devoluciones.numero_devolucion = @devolucion;

