CREATE PROCEDURE articulos_devolver
(@n_venta int)
AS
SELECT
numero_detalle [Numero]
,detalle_venta.codigo_producto [Codigo]
,inventario_productos.descripcion [Descripcion]
,(detalle_venta.cantidad - detalle_venta.devueltos) [Cantidad],
detalle_venta.precio [Precio]
FROM
detalle_venta INNER JOIN inventario_productos ON detalle_venta.codigo_producto = inventario_productos.codigo_producto 
WHERE numero_venta = @n_venta AND [Cantidad] > 0;
