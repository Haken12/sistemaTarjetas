 CREATE PROCEDURE unico_producto
 (@codigo int,
  @descripcion varchar(50) OUT,
  @costo INT OUT,
  @precio INT OUT,
  @existencias int OUT)

  AS
  SELECT
  @descripcion = descripcion,
  @costo = costo,
  @precio = precio,
  @existencias = existencias
  FROM inventario_productos WHERE codigo_producto =@codigo;