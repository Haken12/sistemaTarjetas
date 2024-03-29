USE [sistemaTarjetas]
GO
/****** Object:  StoredProcedure [dbo].[actualizar_ayudante]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[actualizar_ayudante]
(@id_ayudante int,
 @nombre varchar(50),
 @cedula varchar(13),
 @direccion varchar(50),
 @celular varchar(20),
 @telefono varchar(20),
 @comision int,
 @deduccion int,
 @fecha_ingreso date
)

AS 

UPDATE ayudante 
SET
nombre =@nombre,
cedula = @cedula,
direccion = @direccion,
celular= @celular,
telefono= @telefono,
comision = @comision,
deduccion = @deduccion,
fecha_ingreso = @fecha_ingreso

WHERE ayudante.id_ayudante = @id_ayudante;


GO
/****** Object:  StoredProcedure [dbo].[actualizar_tarjeta]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizar_tarjeta]
(@codigo_tarjeta int,
 @nombre varchar(50),
 @referencia varchar(50),
 @cedula varchar(13),
 @telefono varchar(20),
 @fecha_creacion date,
 @id_vendedor int,
 @id_zona int,
 @tipo_pago varchar(20),
 @debito int,
 @credito int,
 @balance int)
 AS
 UPDATE tarjeta
 SET
 nombre = @nombre,
 referencia = @referencia,
 cedula = @cedula,
 telefono = @telefono,
 fecha_creacion = @fecha_creacion,
 id_vendedor = @id_vendedor,
 id_zona = @id_zona,
 tipo_pago = @tipo_pago,
 debito = @debito,
 credito = @credito,
 balance = @balance
 WHERE tarjeta.codigo_tarjeta = @codigo_tarjeta;

GO
/****** Object:  StoredProcedure [dbo].[actualizar_vendedor]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[actualizar_vendedor]
(@id_vendedor int,
 @nombre varchar(50),
 @cedula varchar(13),
 @direccion varchar(50),
 @celular varchar(20),
 @telefono varchar(20),
 @comision int,
 @deduccion int,
 @fecha_ingreso date,
 @id_ayudante int
)
AS 
UPDATE vendedor 
SET
nombre =@nombre,
cedula = @cedula,
direccion = @direccion,
celular= @celular,
telefono= @telefono,
comision = @comision,
deduccion = @deduccion,
fecha_ingreso = @fecha_ingreso,
id_ayudante = @id_ayudante

WHERE vendedor.id_vendedor = @id_vendedor;


GO
/****** Object:  StoredProcedure [dbo].[actualizar_zona]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROCEDURE [dbo].[actualizar_zona]
 (@id_zona int,
  @id_vendedor int,
  @descripcion varchar(70)
  )
 AS
 UPDATE zona
 SET
 id_vendedor = @id_vendedor,
 descripcion = @descripcion
 WHERE zona.id_zona  = @id_zona;
GO
/****** Object:  StoredProcedure [dbo].[articulos_devolver]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[articulos_devolver]
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

GO
/****** Object:  StoredProcedure [dbo].[crear_ayudante]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[crear_ayudante]
(@nombre varchar(50),
 @cedula varchar(13),
 @direccion varchar(50),
 @celular varchar(20),
 @telefono varchar(20),
 @comision int,
 @deduccion int,
 @fecha_ingreso date
)

AS 

INSERT INTO ayudante (nombre,cedula,direccion,celular,telefono,comision,deduccion,fecha_ingreso)
VALUES
(@nombre,@cedula,@direccion,@celular,@telefono,@comision,@deduccion,@fecha_ingreso);


GO
/****** Object:  StoredProcedure [dbo].[crear_tarjeta]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[crear_tarjeta]
(@nombre varchar(50),
 @referencia varchar(50),
 @cedula varchar(13),
 @telefono varchar(20),
 @fecha_creacion date,
 @id_vendedor int,
 @id_zona int,
 @tipo_pago varchar(20),
 @codigo int out)
AS
INSERT INTO tarjeta
 (nombre,referencia,cedula,telefono,fecha_creacion,id_vendedor,id_zona,tipo_pago,debito,credito,balance)
VALUES (@nombre,@referencia,@cedula,@telefono,@fecha_creacion,@id_vendedor,@id_zona,@tipo_pago,0,0,0)

SET @codigo = SCOPE_IDENTITY();

GO
/****** Object:  StoredProcedure [dbo].[crear_vendedor]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[crear_vendedor]
(@nombre varchar(50),
 @cedula varchar(13),
 @direccion varchar(50),
 @celular varchar(20),
 @telefono varchar(20),
 @comision int,
 @deduccion int,
 @fecha_ingreso date,
 @id_ayudante int
)

AS 

INSERT INTO vendedor (nombre,cedula,direccion,celular,telefono,comision,deduccion,fecha_ingreso,id_ayudante)
VALUES
(@nombre,@cedula,@direccion,@celular,@telefono,@comision,@deduccion,@fecha_ingreso,@id_ayudante);

GO
/****** Object:  StoredProcedure [dbo].[crear_zona]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[crear_zona]
(@id_vendedor int,
 @descripcion varchar(70))
 AS
 INSERT INTO zona(id_vendedor,descripcion)
 VALUES (@id_vendedor,@descripcion);

GO
/****** Object:  StoredProcedure [dbo].[despachar_vendedor]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[despachar_vendedor](
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
GO
/****** Object:  StoredProcedure [dbo].[detallesTarjeta]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROCEDURE [dbo].[detallesTarjeta]
 (@codigo int)
 AS
 SELECT
 numero_detalle [No.]
 ,fecha_detalle [Fecha]
 ,tipo [Tipo]
 ,debito [Debito]
 ,credito[credito]
 ,referencia [Referencia]
 FROM detalle_tarjeta WHERE detalle_tarjeta.codigo_tarjeta = @codigo;

GO
/****** Object:  StoredProcedure [dbo].[devolver_a_inventario]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[devolver_a_inventario]
 (@codigo_producto int,
  @id_vendedor int,
  @cantidad int)
  AS
  UPDATE inventario_productos
  SET
  existencias = existencias + @cantidad
  WHERE codigo_producto = @codigo_producto;

  UPDATE inventario_vendedor
  SET
  existencias = existencias - @cantidad
  WHERE id_vendedor = @id_vendedor AND codigo_producto = @codigo_producto;

  IF ((SELECT existencias FROM inventario_vendedor WHERE id_vendedor = @id_vendedor AND codigo_producto = @codigo_producto)= 0) 
  BEGIN
  DELETE FROM inventario_vendedor WHERE id_vendedor = @id_vendedor AND codigo_producto = @codigo_producto;
  END		

GO
/****** Object:  StoredProcedure [dbo].[eliminar_ayudante]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[eliminar_ayudante]
(@id_ayudante int)
AS
DELETE FROM ayudante 
WHERE ayudante.id_ayudante = @id_ayudante;


GO
/****** Object:  StoredProcedure [dbo].[eliminar_tarjeta]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[eliminar_tarjeta]
 (@codigo_tarjeta int)
 AS
 DELETE FROM tarjeta
 WHERE tarjeta.codigo_tarjeta = @codigo_tarjeta;

GO
/****** Object:  StoredProcedure [dbo].[eliminar_vendedor]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[eliminar_vendedor]
(@id_vendedor int)
AS
DELETE FROM vendedor 
WHERE vendedor.id_vendedor = @id_vendedor;

GO
/****** Object:  StoredProcedure [dbo].[eliminar_zona]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[eliminar_zona]
 (@id_zona int)
 AS
 DELETE FROM zona
 WHERE zona.id_zona = @id_zona;
GO
/****** Object:  StoredProcedure [dbo].[nombreVendedor]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[nombreVendedor]
(
	@id int
)
AS
	SET NOCOUNT ON;
SELECT nombre 
FROM vendedor
WHERE vendedor.id_vendedor = @id
GO
/****** Object:  StoredProcedure [dbo].[nueva_devolucion]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[nueva_devolucion]
(@fecha date
,@tarjeta int
,@valor int
,@numero int OUT)
AS
INSERT INTO devoluciones(fecha,codigo_tarjeta,valor)
VALUES (@fecha,@tarjeta,0)
SET @numero = SCOPE_IDENTITY();


GO
/****** Object:  StoredProcedure [dbo].[nueva_devolucion_tarjeta]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[nueva_devolucion_tarjeta]
 (@codigo_tarjeta int,
 @fecha_detalle date,
 @monto int,
 @ref int)
 AS
 DECLARE @num int
 SET @num = (SELECT COUNT(numero_detalle) FROM detalle_tarjeta WHERE detalle_tarjeta.codigo_tarjeta = @codigo_tarjeta)

 INSERT INTO detalle_tarjeta (numero_detalle,codigo_tarjeta,fecha_detalle,tipo,debito,credito,referencia)
 VALUES(@num+1,@codigo_tarjeta,@fecha_detalle,'Devolucion',@monto,0,@ref);
GO
/****** Object:  StoredProcedure [dbo].[nueva_venta]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[nueva_venta]
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


GO
/****** Object:  StoredProcedure [dbo].[nueva_venta_tarjeta]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[nueva_venta_tarjeta]
(@codigo_tarjeta int,
 @fecha_detalle date,
 @importe int,
 @ref int)
 AS
 DECLARE @num int
 SET @num = (SELECT COUNT(numero_detalle) FROM detalle_tarjeta WHERE detalle_tarjeta.codigo_tarjeta = @codigo_tarjeta)
 INSERT INTO detalle_tarjeta(numero_detalle,codigo_tarjeta,fecha_detalle,tipo,debito,credito,referencia)
 VALUES
 (@num+1,@codigo_tarjeta,@fecha_detalle,'Venta',0,@importe,@ref);
 

GO
/****** Object:  StoredProcedure [dbo].[nuevo_cobro_tarjeta]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[nuevo_cobro_tarjeta]
 (@codigo_tarjeta int,
 @fecha_detalle date,
 @monto int,
 @ref int)
 AS
 DECLARE @num int
 SET @num = (SELECT COUNT(numero_detalle) FROM detalle_tarjeta WHERE detalle_tarjeta.codigo_tarjeta = @codigo_tarjeta)

 INSERT INTO detalle_tarjeta (numero_detalle,codigo_tarjeta,fecha_detalle,tipo,debito,credito,referencia)
 VALUES(@num+1,@codigo_tarjeta,@fecha_detalle,'Cobro',@monto,0,@ref);
GO
/****** Object:  StoredProcedure [dbo].[nuevo_descuento_tarjeta]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[nuevo_descuento_tarjeta]
 (@codigo_tarjeta int,
 @fecha_detalle date,
 @monto int,
 @ref int)
 AS
 DECLARE @num int
 SET @num = (SELECT COUNT(numero_detalle) FROM detalle_tarjeta WHERE detalle_tarjeta.codigo_tarjeta = @codigo_tarjeta)

 INSERT INTO detalle_tarjeta (numero_detalle,codigo_tarjeta,fecha_detalle,tipo,debito,credito,referencia)
 VALUES(@num+1,@codigo_tarjeta,@fecha_detalle,'Descuento',@monto,0,@ref);

GO
/****** Object:  StoredProcedure [dbo].[nuevo_despacho]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[nuevo_despacho]
(@vendedor int,
@observacion varchar(200),
@articulos int,
@total int
,@fecha date
,@id int OUT)
AS
INSERT INTO despacho(id_vendedor,observacion,cantidad_articulos,total,fecha)
VALUES (@vendedor,@observacion,@articulos,0,@fecha);
SET @id = SCOPE_IDENTITY();
GO
/****** Object:  StoredProcedure [dbo].[nuevo_detalle_despacho]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[nuevo_detalle_despacho]
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
GO
/****** Object:  StoredProcedure [dbo].[nuevo_detalle_devolucion]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[nuevo_detalle_devolucion]
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
	WHERE devoluciones.numero_devolucion = @devolucion

	DECLARE @vendedor int
	SET @vendedor =
	(SELECT id_vendedor FROM
	 tarjeta INNER JOIN ventas
	 ON ventas.codigo_tarjeta = tarjeta.codigo_tarjeta)

	 IF (NOT EXISTS(SELECT * FROM inventario_vendedor WHERE id_vendedor = @vendedor and codigo_producto = @articulo))
	 BEGIN
	 INSERT INTO inventario_vendedor(id_vendedor,codigo_producto,existencias)
	 VALUES (@vendedor,@articulo,@cantidad)
	 END
	 ELSE
	 UPDATE inventario_vendedor
	 SET existencias = existencias + @cantidad;


GO
/****** Object:  StoredProcedure [dbo].[nuevo_detalle_venta]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

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

DECLARE @vendedor int
SET @vendedor = (SELECT
id_vendedor FROM 
ventas INNER JOIN tarjeta
ON ventas.codigo_tarjeta = tarjeta.codigo_tarjeta
WHERE ventas.numero_venta = @num_venta);

UPDATE inventario_vendedor
SET existencias = existencias - @cantidad
WHERE id_vendedor = @vendedor AND codigo_producto = @cod_producto;



DECLARE @total int
SET @total = (SELECT SUM(importe) FROM detalle_venta WHERE numero_venta = @num_venta)
UPDATE ventas
SET 
total = @total;

GO
/****** Object:  StoredProcedure [dbo].[unica_tarjeta]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[unica_tarjeta]
(@codigo_tarjeta int,
 @nombre varchar(50) OUT,
 @referencia varchar(50)OUT,
 @cedula varchar(13) OUT,
 @telefono varchar(20) OUT,
 @fecha_creacion date OUT,
 @id_vendedor int OUT,
 @id_zona int OUT,
 @tipo_pago varchar(20) OUT)
 AS
 SELECT
 @nombre = tarjeta.nombre,
 @referencia = tarjeta.referencia,
 @cedula = tarjeta.cedula,
 @telefono = tarjeta.telefono,
 @fecha_creacion = tarjeta.fecha_creacion,
 @tipo_pago = tarjeta.tipo_pago,
 @id_vendedor = vendedor.id_vendedor ,
 @id_zona = zona.id_zona
 FROM 
tarjeta INNER JOIN vendedor ON tarjeta.id_vendedor = vendedor.id_vendedor
 INNER JOIN zona ON tarjeta.id_zona = zona.id_zona

 WHERE tarjeta.codigo_tarjeta = @codigo_tarjeta;


GO
/****** Object:  StoredProcedure [dbo].[unica_zona]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[unica_zona]
 (@id int,
  @descripcion varchar(70) OUT,
  @id_vendedor int OUT ,
  @nombre_vendedor varchar(50)OUT)
  AS
  SELECT
  @descripcion = zona.descripcion,
  @id_vendedor = zona.id_vendedor,
  @nombre_vendedor = vendedor.nombre
  FROM 
  zona INNER JOIN vendedor
  ON zona.id_vendedor = vendedor.id_vendedor
  WHERE zona.id_zona = @id;

GO
/****** Object:  StoredProcedure [dbo].[unico_ayudante]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[unico_ayudante]
(@id int,
 @nombre varchar(50) OUT,
 @cedula varchar(13) OUT,
 @direccion varchar(50) OUT,
 @telefono varchar(20) OUT,
 @celular varchar(20) OUT,
 @comision int OUT,
 @deduccion int OUT,
 @fecha_ingreso date OUT)

AS

SELECT
@nombre = ayudante.nombre,
@cedula = ayudante.cedula,
@direccion = ayudante.direccion,
@telefono = ayudante.telefono,
@celular = ayudante.celular,
@comision = ayudante.comision,
@deduccion = ayudante.deduccion,
@fecha_ingreso = ayudante.fecha_ingreso
FROM ayudante WHERE 
ayudante.id_ayudante = @id;

GO
/****** Object:  StoredProcedure [dbo].[unico_producto]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[unico_producto]
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
GO
/****** Object:  StoredProcedure [dbo].[unico_vendedor]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[unico_vendedor]
(@id int,
 @nombre varchar(50) OUT,
 @cedula varchar(13) OUT,
 @direccion varchar(50) OUT,
 @telefono varchar(20) OUT,
 @celular varchar(20) OUT,
 @comision int out,
 @deduccion int out,
 @fecha_ingreso date OUT,
 @id_ayudante int OUT)

AS

SELECT
@nombre = vendedor.nombre,
@cedula = vendedor.cedula,
@direccion = vendedor.direccion,
@telefono = vendedor.telefono,
@celular = vendedor.celular,
@comision = vendedor.comision,
@deduccion = vendedor.deduccion,
@fecha_ingreso = vendedor.fecha_ingreso,
@id_ayudante = vendedor.id_ayudante
FROM vendedor WHERE 
vendedor.id_vendedor = @id;


GO
/****** Object:  StoredProcedure [dbo].[v_detalles_tarjeta]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROCEDURE [dbo].[v_detalles_tarjeta]
 (@codigo int)
 AS
 SELECT
 numero_detalle [No.]
 ,fecha_detalle [Fecha]
 ,tipo [Tipo]
 ,debito [Debito]
 ,credito[Credito]
 ,referencia [Referencia]
 FROM detalle_tarjeta WHERE detalle_tarjeta.codigo_tarjeta = @codigo;
GO
/****** Object:  StoredProcedure [dbo].[v_inventario_vendedor]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[v_inventario_vendedor]
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
GO
/****** Object:  UserDefinedFunction [dbo].[ayudante_existe]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ayudante_existe]
(@id int)
RETURNS int
AS
BEGIN
DECLARE @n int
SET @n = (SELECT COUNT(id_ayudante) FROM ayudante WHERE ayudante.id_ayudante = @id)
RETURN @n
END

GO
/****** Object:  UserDefinedFunction [dbo].[tarjeta_existe]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE FUNCTION [dbo].[tarjeta_existe]
 (@codigo int)
 RETURNS int
 AS
 BEGIN
 DECLARE @n int
 SET @n = (SELECT COUNT(codigo_tarjeta) FROM tarjeta WHERE tarjeta.codigo_tarjeta = @codigo)
 RETURN @n
 END
GO
/****** Object:  UserDefinedFunction [dbo].[vendedor_existe]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[vendedor_existe]
(@id int)
RETURNS INT
AS
BEGIN
DECLARE @n int
SET @n = (SELECT COUNT(id_vendedor) FROM vendedor WHERE vendedor.id_vendedor = @id)
RETURN @n
END
GO
/****** Object:  UserDefinedFunction [dbo].[zona_existe]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE FUNCTION [dbo].[zona_existe]
  (@id int)
  RETURNS INT 
  AS
  BEGIN
  DECLARE @n int
  SET @n = (SELECT COUNT(id_zona) FROM zona WHERE zona.id_zona = @id)
  RETURN @n
  END
GO
/****** Object:  Table [dbo].[ayudante]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ayudante](
	[id_ayudante] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[cedula] [varchar](13) NULL,
	[direccion] [varchar](50) NULL,
	[celular] [varchar](20) NULL,
	[telefono] [varchar](20) NULL,
	[comision] [int] NULL,
	[deduccion] [int] NULL,
	[fecha_ingreso] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ayudante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[despacho]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[despacho](
	[numero_despacho] [int] IDENTITY(1,1) NOT NULL,
	[id_vendedor] [int] NULL,
	[observacion] [varchar](200) NULL,
	[cantidad_articulos] [int] NULL,
	[total] [int] NULL,
	[fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[numero_despacho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalle_despacho]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_despacho](
	[numero_despacho] [int] NULL,
	[numero_detalle] [int] NULL,
	[codigo_producto] [int] NULL,
	[precio] [int] NULL,
	[cantidad] [int] NULL,
	[importe] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detalle_devolucion]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_devolucion](
	[numero_devolucion] [int] NULL,
	[numero_detalle] [int] NULL,
	[codigo_articulo] [int] NULL,
	[cantidad] [int] NULL,
	[precio] [int] NULL,
	[valor] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detalle_tarjeta]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalle_tarjeta](
	[numero_detalle] [int] NULL,
	[codigo_tarjeta] [int] NULL,
	[fecha_detalle] [date] NULL,
	[tipo] [varchar](20) NULL,
	[debito] [int] NULL,
	[credito] [int] NULL,
	[balance] [int] NULL,
	[referencia] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalle_venta]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_venta](
	[numero_venta] [int] NULL,
	[numero_detalle] [int] NULL,
	[codigo_producto] [int] NULL,
	[precio] [int] NULL,
	[cantidad] [int] NULL,
	[importe] [int] NULL,
	[devueltos] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[devoluciones]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[devoluciones](
	[numero_devolucion] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[codigo_tarjeta] [int] NULL,
	[valor] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[numero_devolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[inventario_productos]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[inventario_productos](
	[codigo_producto] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[costo] [int] NULL,
	[precio] [int] NULL,
	[existencias] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[inventario_vendedor]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventario_vendedor](
	[id_vendedor] [int] NULL,
	[codigo_producto] [int] NULL,
	[existencias] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tarjeta]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tarjeta](
	[codigo_tarjeta] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[referencia] [varchar](50) NULL,
	[cedula] [varchar](13) NULL,
	[telefono] [varchar](20) NULL,
	[fecha_creacion] [date] NULL,
	[id_vendedor] [int] NULL,
	[id_zona] [int] NULL,
	[tipo_pago] [varchar](20) NULL,
	[debito] [int] NULL,
	[credito] [int] NULL,
	[balance] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_tarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vendedor]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vendedor](
	[id_vendedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[cedula] [varchar](13) NOT NULL,
	[direccion] [varchar](50) NULL,
	[telefono] [varchar](20) NULL,
	[celular] [varchar](20) NULL,
	[fecha_ingreso] [date] NULL,
	[comision] [int] NULL,
	[deduccion] [int] NULL,
	[id_ayudante] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_vendedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ventas]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventas](
	[numero_venta] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[codigo_tarjeta] [int] NULL,
	[total] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[numero_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[zona]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[zona](
	[id_zona] [int] IDENTITY(1,1) NOT NULL,
	[id_vendedor] [int] NULL,
	[descripcion] [varchar](70) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_zona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[v_articulos]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_articulos]
  AS
  SELECT
  codigo_producto [Codigo],
  descripcion [Descripcion],
  costo [Costo],
  precio [Precio],
  existencias [Existencias]
  FROM
  inventario_productos;
GO
/****** Object:  View [dbo].[v_ayudante]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_ayudante]
AS
SELECT
id_ayudante [Id],
nombre [Nombre],
cedula [Cedula],
direccion [Direccion],
telefono [Telefono],
celular [Celular],
comision [Comision],
deduccion [Deduccion],
fecha_ingreso [Fecha Ingreso]
FROM 
ayudante;
GO
/****** Object:  View [dbo].[v_tarjetas]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW [dbo].[v_tarjetas]
 AS
 SELECT 
tarjeta.codigo_tarjeta [Codigo],
tarjeta.nombre [Nombre],
tarjeta.referencia [Referencia],
tarjeta.cedula [Cedula],
tarjeta.telefono [Telefono],
tarjeta.fecha_creacion [Fecha],
vendedor.id_vendedor [Id Vendedor],
vendedor.nombre [Vendedor],
zona.id_zona [Id Zona],
zona.descripcion [Zona]

 FROM 
 tarjeta 
 INNER JOIN vendedor ON tarjeta.id_vendedor = vendedor.id_vendedor
 INNER JOIN zona ON tarjeta.id_zona = zona.id_zona;
GO
/****** Object:  View [dbo].[v_vendedor]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[v_vendedor]
AS
SELECT
vendedor.id_vendedor [Id],
vendedor.nombre [Nombre],
vendedor.cedula [Cedula],
vendedor.direccion [Direccion],
vendedor.telefono [Telefono],
vendedor.celular [Celular],
vendedor.comision [Comision],
vendedor.deduccion [Deduccion],
vendedor.fecha_ingreso [Ingreso],
ayudante.id_ayudante,
ayudante.nombre [Ayudante]
FROM 
vendedor INNER JOIN ayudante
ON vendedor.id_ayudante = ayudante.id_ayudante;
GO
/****** Object:  View [dbo].[v_zona]    Script Date: 02/11/2020 13:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW [dbo].[v_zona]
 AS
 SELECT 
 zona.id_vendedor [Id],
 zona.descripcion [Descripcion],
 vendedor.id_vendedor,
 vendedor.nombre [Vendedor]
 FROM
 zona INNER JOIN vendedor
 ON zona.id_vendedor = vendedor.id_vendedor;
GO
SET IDENTITY_INSERT [dbo].[ayudante] ON 

INSERT [dbo].[ayudante] ([id_ayudante], [nombre], [cedula], [direccion], [celular], [telefono], [comision], [deduccion], [fecha_ingreso]) VALUES (1, N'AYUDANTE 1', N'010-2468613-1', N'27 DE FEBRERO 142', N'829-320-1164', N'809-521-5555', 6, 600, CAST(0xAF410B00 AS Date))
INSERT [dbo].[ayudante] ([id_ayudante], [nombre], [cedula], [direccion], [celular], [telefono], [comision], [deduccion], [fecha_ingreso]) VALUES (2, N'AYUDANTE 2', N'010-2468613-1', N'27 DE FEBRERO 141', N'829-320-1164', N'809-521-5555', 4, 0, CAST(0xAF410B00 AS Date))
INSERT [dbo].[ayudante] ([id_ayudante], [nombre], [cedula], [direccion], [celular], [telefono], [comision], [deduccion], [fecha_ingreso]) VALUES (3, N'AYUDANTE 3', N'010-2468613-1', N'27 DE FEBRERO 141', N'829-320-1164', N'809-521-5555', 4, 0, CAST(0xAF410B00 AS Date))
INSERT [dbo].[ayudante] ([id_ayudante], [nombre], [cedula], [direccion], [celular], [telefono], [comision], [deduccion], [fecha_ingreso]) VALUES (4, N'AYUDANTE 4', N'402-5314557-8', N'DIRECCION 8', N'829-521-4315', N'809-521-5521', 1, 0, CAST(0xB1410B00 AS Date))
INSERT [dbo].[ayudante] ([id_ayudante], [nombre], [cedula], [direccion], [celular], [telefono], [comision], [deduccion], [fecha_ingreso]) VALUES (5, N'', N'___-_______-_', N'', N'___-___-____', N'___-___-____', 1, 0, CAST(0xBB410B00 AS Date))
INSERT [dbo].[ayudante] ([id_ayudante], [nombre], [cedula], [direccion], [celular], [telefono], [comision], [deduccion], [fecha_ingreso]) VALUES (6, N'juan perez', N'___-_______-_', N'aa', N'___-___-____', N'___-___-____', 4, 600, CAST(0xC2410B00 AS Date))
SET IDENTITY_INSERT [dbo].[ayudante] OFF
SET IDENTITY_INSERT [dbo].[despacho] ON 

INSERT [dbo].[despacho] ([numero_despacho], [id_vendedor], [observacion], [cantidad_articulos], [total], [fecha]) VALUES (1, 1, N'', 1, 0, CAST(0xB9410B00 AS Date))
INSERT [dbo].[despacho] ([numero_despacho], [id_vendedor], [observacion], [cantidad_articulos], [total], [fecha]) VALUES (2, 2, N'', 1, 0, CAST(0xC2410B00 AS Date))
INSERT [dbo].[despacho] ([numero_despacho], [id_vendedor], [observacion], [cantidad_articulos], [total], [fecha]) VALUES (3, 1, N'', 2, 0, CAST(0xC2410B00 AS Date))
INSERT [dbo].[despacho] ([numero_despacho], [id_vendedor], [observacion], [cantidad_articulos], [total], [fecha]) VALUES (4, 1, N'', 3, 0, CAST(0xC2410B00 AS Date))
SET IDENTITY_INSERT [dbo].[despacho] OFF
INSERT [dbo].[detalle_despacho] ([numero_despacho], [numero_detalle], [codigo_producto], [precio], [cantidad], [importe]) VALUES (1, 1, 1, 10, 5, 50)
INSERT [dbo].[detalle_despacho] ([numero_despacho], [numero_detalle], [codigo_producto], [precio], [cantidad], [importe]) VALUES (2, 1, 1, 10, 5, 50)
INSERT [dbo].[detalle_despacho] ([numero_despacho], [numero_detalle], [codigo_producto], [precio], [cantidad], [importe]) VALUES (3, 1, 1, 10, 10, 100)
INSERT [dbo].[detalle_despacho] ([numero_despacho], [numero_detalle], [codigo_producto], [precio], [cantidad], [importe]) VALUES (3, 2, 2, 40, 10, 400)
INSERT [dbo].[detalle_despacho] ([numero_despacho], [numero_detalle], [codigo_producto], [precio], [cantidad], [importe]) VALUES (4, 1, 1, 10, 10, 100)
INSERT [dbo].[detalle_despacho] ([numero_despacho], [numero_detalle], [codigo_producto], [precio], [cantidad], [importe]) VALUES (4, 2, 2, 40, 10, 400)
INSERT [dbo].[detalle_devolucion] ([numero_devolucion], [numero_detalle], [codigo_articulo], [cantidad], [precio], [valor]) VALUES (1, 1, 1, 1, NULL, 10)
INSERT [dbo].[detalle_devolucion] ([numero_devolucion], [numero_detalle], [codigo_articulo], [cantidad], [precio], [valor]) VALUES (2, 1, 1, 1, NULL, 10)
INSERT [dbo].[detalle_devolucion] ([numero_devolucion], [numero_detalle], [codigo_articulo], [cantidad], [precio], [valor]) VALUES (3, 1, 1, 1, NULL, 10)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, 1, CAST(0xB4410B00 AS Date), N'Venta', 0, 20, NULL, 1)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, NULL, CAST(0xB4410B00 AS Date), N'Cobro', 10, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, NULL, CAST(0xB4410B00 AS Date), N'Cobro', 10, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, NULL, CAST(0xB4410B00 AS Date), N'Cobro', 10, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, NULL, CAST(0xB4410B00 AS Date), N'Cobro', 10, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, NULL, CAST(0xB4410B00 AS Date), N'Cobro', 10, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, NULL, CAST(0xB4410B00 AS Date), N'Cobro', 10, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, NULL, CAST(0xB4410B00 AS Date), N'Cobro', 10, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, NULL, CAST(0xB4410B00 AS Date), N'Cobro', 10, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, NULL, CAST(0xB4410B00 AS Date), N'Cobro', 10, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, NULL, CAST(0xB4410B00 AS Date), N'Cobro', 10, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, NULL, CAST(0xB4410B00 AS Date), N'Cobro', 10, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, NULL, CAST(0xB4410B00 AS Date), N'Cobro', 10, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, NULL, CAST(0xB4410B00 AS Date), N'Cobro', 10, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, NULL, CAST(0xB4410B00 AS Date), N'Cobro', 10, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (2, 1, CAST(0xB4410B00 AS Date), N'Cobro', 10, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (3, 1, CAST(0xB4410B00 AS Date), N'Devolucion', 10, 0, NULL, 1)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, 5, CAST(0xC2410B00 AS Date), N'Venta', 0, 20, NULL, 2)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (4, 1, CAST(0xB4410B00 AS Date), N'Venta', 0, 20, NULL, 3)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (2, 5, CAST(0xC2410B00 AS Date), N'Venta', 0, 20, NULL, 4)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, NULL, CAST(0xB4410B00 AS Date), N'Descuento', 20, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, NULL, CAST(0xB4410B00 AS Date), N'Descuento', 20, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (5, 1, CAST(0xB4410B00 AS Date), N'Descuento', 20, 0, NULL, 0)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (1, 6, CAST(0xC2410B00 AS Date), N'Venta', 0, 20, NULL, 5)
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito], [balance], [referencia]) VALUES (2, 6, CAST(0xC2410B00 AS Date), N'Cobro', 10, 0, NULL, 0)
INSERT [dbo].[detalle_venta] ([numero_venta], [numero_detalle], [codigo_producto], [precio], [cantidad], [importe], [devueltos]) VALUES (1, 1, 1, 10, 2, 20, 1)
INSERT [dbo].[detalle_venta] ([numero_venta], [numero_detalle], [codigo_producto], [precio], [cantidad], [importe], [devueltos]) VALUES (2, 1, 1, 10, 2, 20, 0)
INSERT [dbo].[detalle_venta] ([numero_venta], [numero_detalle], [codigo_producto], [precio], [cantidad], [importe], [devueltos]) VALUES (3, 1, 1, 10, 2, 20, 0)
INSERT [dbo].[detalle_venta] ([numero_venta], [numero_detalle], [codigo_producto], [precio], [cantidad], [importe], [devueltos]) VALUES (4, 1, 1, 10, 2, 20, 0)
INSERT [dbo].[detalle_venta] ([numero_venta], [numero_detalle], [codigo_producto], [precio], [cantidad], [importe], [devueltos]) VALUES (5, 1, 1, 10, 2, 20, 2)
SET IDENTITY_INSERT [dbo].[devoluciones] ON 

INSERT [dbo].[devoluciones] ([numero_devolucion], [fecha], [codigo_tarjeta], [valor]) VALUES (1, CAST(0xB4410B00 AS Date), 1, 10)
INSERT [dbo].[devoluciones] ([numero_devolucion], [fecha], [codigo_tarjeta], [valor]) VALUES (2, CAST(0xC2410B00 AS Date), 6, 10)
INSERT [dbo].[devoluciones] ([numero_devolucion], [fecha], [codigo_tarjeta], [valor]) VALUES (3, CAST(0xC2410B00 AS Date), 6, 10)
SET IDENTITY_INSERT [dbo].[devoluciones] OFF
SET IDENTITY_INSERT [dbo].[inventario_productos] ON 

INSERT [dbo].[inventario_productos] ([codigo_producto], [descripcion], [costo], [precio], [existencias]) VALUES (1, N'SILLA', 5, 10, 30)
INSERT [dbo].[inventario_productos] ([codigo_producto], [descripcion], [costo], [precio], [existencias]) VALUES (2, N'MESA', 20, 40, 15)
INSERT [dbo].[inventario_productos] ([codigo_producto], [descripcion], [costo], [precio], [existencias]) VALUES (3, N'VASO', 3, 7, 50)
INSERT [dbo].[inventario_productos] ([codigo_producto], [descripcion], [costo], [precio], [existencias]) VALUES (4, N'PLATO', 4, 8, 40)
INSERT [dbo].[inventario_productos] ([codigo_producto], [descripcion], [costo], [precio], [existencias]) VALUES (5, N'CUBIERTO', 3, 7, 35)
INSERT [dbo].[inventario_productos] ([codigo_producto], [descripcion], [costo], [precio], [existencias]) VALUES (6, N'JARRA', 5, 10, 30)
INSERT [dbo].[inventario_productos] ([codigo_producto], [descripcion], [costo], [precio], [existencias]) VALUES (7, N'CUCHARA', 3, 7, 35)
INSERT [dbo].[inventario_productos] ([codigo_producto], [descripcion], [costo], [precio], [existencias]) VALUES (8, N'CUCHILLO DE MESA', 3, 7, 35)
INSERT [dbo].[inventario_productos] ([codigo_producto], [descripcion], [costo], [precio], [existencias]) VALUES (9, N'CUCHILLO DE COCINA', 10, 15, 20)
INSERT [dbo].[inventario_productos] ([codigo_producto], [descripcion], [costo], [precio], [existencias]) VALUES (10, N'COPA DE VIDRIO', 5, 10, 20)
SET IDENTITY_INSERT [dbo].[inventario_productos] OFF
INSERT [dbo].[inventario_vendedor] ([id_vendedor], [codigo_producto], [existencias]) VALUES (1, 1, 21)
INSERT [dbo].[inventario_vendedor] ([id_vendedor], [codigo_producto], [existencias]) VALUES (2, 1, 3)
INSERT [dbo].[inventario_vendedor] ([id_vendedor], [codigo_producto], [existencias]) VALUES (NULL, 1, 1)
INSERT [dbo].[inventario_vendedor] ([id_vendedor], [codigo_producto], [existencias]) VALUES (NULL, 1, 1)
INSERT [dbo].[inventario_vendedor] ([id_vendedor], [codigo_producto], [existencias]) VALUES (1, 2, 20)
SET IDENTITY_INSERT [dbo].[tarjeta] ON 

INSERT [dbo].[tarjeta] ([codigo_tarjeta], [nombre], [referencia], [cedula], [telefono], [fecha_creacion], [id_vendedor], [id_zona], [tipo_pago], [debito], [credito], [balance]) VALUES (1, N'CLIENTE 1', N'REFERENCIA  1', N'000-0000000-0', N'000-000-0000', CAST(0xB4410B00 AS Date), 1, 1, N'Semanal', 0, 0, 0)
INSERT [dbo].[tarjeta] ([codigo_tarjeta], [nombre], [referencia], [cedula], [telefono], [fecha_creacion], [id_vendedor], [id_zona], [tipo_pago], [debito], [credito], [balance]) VALUES (2, N'CLIENTE 5', N'REF5', N'000-0000000-0', N'000-000-0000', CAST(0xB5410B00 AS Date), 2, 2, N'Quincenal', 0, 0, 0)
INSERT [dbo].[tarjeta] ([codigo_tarjeta], [nombre], [referencia], [cedula], [telefono], [fecha_creacion], [id_vendedor], [id_zona], [tipo_pago], [debito], [credito], [balance]) VALUES (3, N'juan', N'', N'   -       - ', N'   -   -    ', CAST(0xC2410B00 AS Date), 2, 2, N'Semanal', 0, 0, 0)
INSERT [dbo].[tarjeta] ([codigo_tarjeta], [nombre], [referencia], [cedula], [telefono], [fecha_creacion], [id_vendedor], [id_zona], [tipo_pago], [debito], [credito], [balance]) VALUES (4, N'pedro', N'', N'   -       - ', N'   -   -    ', CAST(0xC2410B00 AS Date), 2, 2, N'Semanal', 0, 0, 0)
INSERT [dbo].[tarjeta] ([codigo_tarjeta], [nombre], [referencia], [cedula], [telefono], [fecha_creacion], [id_vendedor], [id_zona], [tipo_pago], [debito], [credito], [balance]) VALUES (5, N'juancito', N'', N'   -       - ', N'   -   -    ', CAST(0xC2410B00 AS Date), 2, 2, N'Semanal', 0, 0, 0)
INSERT [dbo].[tarjeta] ([codigo_tarjeta], [nombre], [referencia], [cedula], [telefono], [fecha_creacion], [id_vendedor], [id_zona], [tipo_pago], [debito], [credito], [balance]) VALUES (6, N'Juana Perez', N'Azua', N'402-0025523-0', N'506-589-0315', CAST(0xC2410B00 AS Date), 1, 1, N'Semanal', 0, 0, 0)
SET IDENTITY_INSERT [dbo].[tarjeta] OFF
SET IDENTITY_INSERT [dbo].[vendedor] ON 

INSERT [dbo].[vendedor] ([id_vendedor], [nombre], [cedula], [direccion], [telefono], [celular], [fecha_ingreso], [comision], [deduccion], [id_ayudante]) VALUES (1, N'VENDEDOR 1', N'111-1111111-1', N'DIRECCION V1', N'222-222-2222', N'222-222-2222', CAST(0xB1410B00 AS Date), 1, 0, 1)
INSERT [dbo].[vendedor] ([id_vendedor], [nombre], [cedula], [direccion], [telefono], [celular], [fecha_ingreso], [comision], [deduccion], [id_ayudante]) VALUES (2, N'VENDEDOR 2', N'222-2222222-2', N'DV2', N'888-888-8888', N'555-555-5555', CAST(0xB5410B00 AS Date), 4, 0, 2)
INSERT [dbo].[vendedor] ([id_vendedor], [nombre], [cedula], [direccion], [telefono], [celular], [fecha_ingreso], [comision], [deduccion], [id_ayudante]) VALUES (3, N'juancitop1', N'___-_______-_', N'azua', N'___-___-____', N'___-___-____', CAST(0xC2410B00 AS Date), 8, 600, 6)
SET IDENTITY_INSERT [dbo].[vendedor] OFF
SET IDENTITY_INSERT [dbo].[ventas] ON 

INSERT [dbo].[ventas] ([numero_venta], [fecha], [codigo_tarjeta], [total]) VALUES (1, CAST(0xB4410B00 AS Date), 1, 20)
INSERT [dbo].[ventas] ([numero_venta], [fecha], [codigo_tarjeta], [total]) VALUES (2, CAST(0xC2410B00 AS Date), 5, 20)
INSERT [dbo].[ventas] ([numero_venta], [fecha], [codigo_tarjeta], [total]) VALUES (3, CAST(0xB4410B00 AS Date), 1, 20)
INSERT [dbo].[ventas] ([numero_venta], [fecha], [codigo_tarjeta], [total]) VALUES (4, CAST(0xC2410B00 AS Date), 5, 20)
INSERT [dbo].[ventas] ([numero_venta], [fecha], [codigo_tarjeta], [total]) VALUES (5, CAST(0xC2410B00 AS Date), 6, 20)
SET IDENTITY_INSERT [dbo].[ventas] OFF
SET IDENTITY_INSERT [dbo].[zona] ON 

INSERT [dbo].[zona] ([id_zona], [id_vendedor], [descripcion]) VALUES (1, 1, N'V1/LUNES')
INSERT [dbo].[zona] ([id_zona], [id_vendedor], [descripcion]) VALUES (2, 1, N'V1/ MARTES')
INSERT [dbo].[zona] ([id_zona], [id_vendedor], [descripcion]) VALUES (3, 2, N'V2/LUNES')
INSERT [dbo].[zona] ([id_zona], [id_vendedor], [descripcion]) VALUES (4, 2, N'V2/MIERCOLES')
INSERT [dbo].[zona] ([id_zona], [id_vendedor], [descripcion]) VALUES (5, 1, N'Lunes, Barahona.')
INSERT [dbo].[zona] ([id_zona], [id_vendedor], [descripcion]) VALUES (6, 1, N'Martes, Bani.')
SET IDENTITY_INSERT [dbo].[zona] OFF
ALTER TABLE [dbo].[vendedor] ADD  DEFAULT (NULL) FOR [id_ayudante]
GO
ALTER TABLE [dbo].[detalle_despacho]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_DESPACHO] FOREIGN KEY([numero_despacho])
REFERENCES [dbo].[despacho] ([numero_despacho])
GO
ALTER TABLE [dbo].[detalle_despacho] CHECK CONSTRAINT [FK_DETALLE_DESPACHO]
GO
ALTER TABLE [dbo].[detalle_despacho]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_PRODUCTO] FOREIGN KEY([codigo_producto])
REFERENCES [dbo].[inventario_productos] ([codigo_producto])
GO
ALTER TABLE [dbo].[detalle_despacho] CHECK CONSTRAINT [FK_DETALLE_PRODUCTO]
GO
ALTER TABLE [dbo].[detalle_devolucion]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_DEVOLUCION] FOREIGN KEY([numero_devolucion])
REFERENCES [dbo].[devoluciones] ([numero_devolucion])
GO
ALTER TABLE [dbo].[detalle_devolucion] CHECK CONSTRAINT [FK_DETALLE_DEVOLUCION]
GO
ALTER TABLE [dbo].[detalle_tarjeta]  WITH CHECK ADD  CONSTRAINT [FK_CODIGO_TARJETA] FOREIGN KEY([codigo_tarjeta])
REFERENCES [dbo].[tarjeta] ([codigo_tarjeta])
GO
ALTER TABLE [dbo].[detalle_tarjeta] CHECK CONSTRAINT [FK_CODIGO_TARJETA]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_VENTA] FOREIGN KEY([numero_venta])
REFERENCES [dbo].[ventas] ([numero_venta])
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_DETALLE_VENTA]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_DV_PRODUCTO] FOREIGN KEY([codigo_producto])
REFERENCES [dbo].[inventario_productos] ([codigo_producto])
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_DV_PRODUCTO]
GO
ALTER TABLE [dbo].[devoluciones]  WITH CHECK ADD  CONSTRAINT [FK_DEVOLUCION_TARJETA] FOREIGN KEY([codigo_tarjeta])
REFERENCES [dbo].[tarjeta] ([codigo_tarjeta])
GO
ALTER TABLE [dbo].[devoluciones] CHECK CONSTRAINT [FK_DEVOLUCION_TARJETA]
GO
ALTER TABLE [dbo].[inventario_vendedor]  WITH CHECK ADD  CONSTRAINT [FK_IVENDEDOR_PRODCUTO] FOREIGN KEY([codigo_producto])
REFERENCES [dbo].[inventario_productos] ([codigo_producto])
GO
ALTER TABLE [dbo].[inventario_vendedor] CHECK CONSTRAINT [FK_IVENDEDOR_PRODCUTO]
GO
ALTER TABLE [dbo].[tarjeta]  WITH CHECK ADD  CONSTRAINT [FK_TARJETA_VENDEDOR] FOREIGN KEY([id_vendedor])
REFERENCES [dbo].[vendedor] ([id_vendedor])
GO
ALTER TABLE [dbo].[tarjeta] CHECK CONSTRAINT [FK_TARJETA_VENDEDOR]
GO
ALTER TABLE [dbo].[tarjeta]  WITH CHECK ADD  CONSTRAINT [FK_TARJETA_ZONA] FOREIGN KEY([id_zona])
REFERENCES [dbo].[zona] ([id_zona])
GO
ALTER TABLE [dbo].[tarjeta] CHECK CONSTRAINT [FK_TARJETA_ZONA]
GO
ALTER TABLE [dbo].[vendedor]  WITH CHECK ADD  CONSTRAINT [FK_VENDEDOR_AYUDANTE] FOREIGN KEY([id_ayudante])
REFERENCES [dbo].[ayudante] ([id_ayudante])
GO
ALTER TABLE [dbo].[vendedor] CHECK CONSTRAINT [FK_VENDEDOR_AYUDANTE]
GO
ALTER TABLE [dbo].[zona]  WITH CHECK ADD  CONSTRAINT [FK_ZONA_VENDEDOR] FOREIGN KEY([id_vendedor])
REFERENCES [dbo].[vendedor] ([id_vendedor])
GO
ALTER TABLE [dbo].[zona] CHECK CONSTRAINT [FK_ZONA_VENDEDOR]
GO
