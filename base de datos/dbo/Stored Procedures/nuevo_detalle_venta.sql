
CREATE PROCEDURE [dbo].[nuevo_detalle_venta]
(@num_venta int
,@num_detalle int
,@cod_producto int
,@precio int
,@cantidad int
,@importe int)
AS
INSERT INTO detalle_venta(numero_venta,numero_detalle,codigo_producto,precio,cantidad,importe,devueltos)
VALUES
(@num_venta,@num_detalle,@cod_producto,@precio,@cantidad,@importe,0);


DECLARE @total int
SET @total = (SELECT SUM(importe) FROM detalle_venta WHERE numero_venta = @num_venta)
UPDATE ventas
SET 
total = @total;
