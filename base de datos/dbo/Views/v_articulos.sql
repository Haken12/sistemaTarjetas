CREATE VIEW v_articulos
  AS
  SELECT
  codigo_producto [Codigo],
  descripcion [Descripcion],
  costo [Costo],
  precio [Precio],
  existencias [Existencias]
  FROM
  inventario_productos;