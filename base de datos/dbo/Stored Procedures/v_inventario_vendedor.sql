CREATE PROCEDURE v_inventario_vendedor
(@id_vendedor int)
AS
SELECT
inventario_productos.codigo_producto [Codigo],
inventario_productos.descripcion [Descripcion],
inventario_productos.precio [Precio],
inventario_vendedor.existencias [Existencias]
FROM inventario_vendedor INNER JOIN inventario_productos
 ON inventario_vendedor.codigo_producto =  inventario_productos.codigo_producto
 WHERE inventario_vendedor.id_vendedor = @id_vendedor;