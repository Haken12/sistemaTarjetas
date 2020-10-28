
CREATE PROCEDURE nuevo_detalle_despacho
(@num_despacho int,
 @cod_producto int,
 @precio int,
 @cantidad int,
 @importe int)
 AS
 BEGIN
 DECLARE @num int
 SET @num = (SELECT COUNT(numero_despacho) FROM detalle_despacho WHERE detalle_despacho.numero_despacho = @num_despacho)
 INSERT INTO detalle_despacho(numero_despacho,numero_detalle,codigo_producto,precio,cantidad,importe)
 VALUES 
 (@num_despacho,@num+1,@cod_producto,@precio,@cantidad,@importe);
 END