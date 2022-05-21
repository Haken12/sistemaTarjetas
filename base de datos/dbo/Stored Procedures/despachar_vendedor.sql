 CREATE PROCEDURE despachar_vendedor(
 @codigo_prodcuto int,
 @id_vendedor int,
 @cantidad int
 )
 AS

 IF (NOT EXISTS (select * from inventario_vendedor WHERE (id_vendedor = @id_vendedor) AND (inventario_vendedor.codigo_producto = @codigo_prodcuto)))
 BEGIN
 INSERT INTO inventario_vendedor (codigo_producto,id_vendedor,existencias)
 VALUES (@codigo_prodcuto,@id_vendedor,@cantidad);
 END 
 ELSE
 BEGIN
 UPDATE inventario_vendedor 
 SET
 existencias = existencias + @cantidad
 WHERE (inventario_vendedor.codigo_producto = @codigo_prodcuto) AND (inventario_vendedor.id_vendedor = @id_vendedor);
 END