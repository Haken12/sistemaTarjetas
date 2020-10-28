CREATE PROCEDURE nueva_devolucion
(@fecha date
,@tarjeta int
,@valor int
,@numero int OUT)
AS
INSERT INTO devoluciones(fecha,codigo_tarjeta,valor)
VALUES (@fecha,@tarjeta,0)
SET @numero = SCOPE_IDENTITY();

