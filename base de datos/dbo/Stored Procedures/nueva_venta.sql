CREATE PROCEDURE nueva_venta
(@fecha date
,@tarjeta int
,@total int
,@num int OUT)
AS
BEGIN
INSERT INTO ventas(fecha,codigo_tarjeta,total)
VALUES (@fecha,@tarjeta,@total);
SET @num = SCOPE_IDENTITY();

END

