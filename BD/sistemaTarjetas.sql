USE [sistemaTarjetas]
GO
/****** Object:  UserDefinedTableType [dbo].[t_inventario]    Script Date: 08/10/2020 20:14:57 ******/
CREATE TYPE [dbo].[t_inventario] AS TABLE(
	[codigo] [int] NULL,
	[descripcion] [varchar](70) NULL,
	[existencias] [int] NULL
)
GO
/****** Object:  StoredProcedure [dbo].[actualizar_ayudante]    Script Date: 08/10/2020 20:14:57 ******/
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
 @comision decimal(5,2),
 @deduccion decimal(5,2),
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
/****** Object:  StoredProcedure [dbo].[actualizar_cliente]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 CREATE PROCEDURE [dbo].[actualizar_cliente]
 (@codigo_cliente int,
 @nombre varchar(50),
 @cedula varchar(13),
 @direccion varchar(50),
 @telefono varchar(20))
 AS
 UPDATE cliente
 SET
 nombre = @nombre,
 cedula = @cedula,
 direccion = @direccion,
 telefono = @telefono
 WHERE cliente.codigo_cliente = @codigo_cliente;


GO
/****** Object:  StoredProcedure [dbo].[actualizar_tarjeta]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[actualizar_tarjeta]
(@codigo_tarjeta int,
 @codigo_cliente int,
 @fecha_creacion date,
 @id_vendedor int,
 @id_zona int,
 @tipo_pago varchar(20))
 AS
 UPDATE tarjeta
 SET
 codigo_cliente = @codigo_cliente,
 fecha_creacion = @fecha_creacion,
 id_vendedor = @id_vendedor,
 id_zona = @id_zona,
 tipo_pago = @tipo_pago
 WHERE tarjeta.codigo_tarjeta = @codigo_tarjeta;

GO
/****** Object:  StoredProcedure [dbo].[actualizar_vendedor]    Script Date: 08/10/2020 20:14:57 ******/
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
 @comision decimal(5,2),
 @deduccion decimal(5,2),
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
/****** Object:  StoredProcedure [dbo].[actualizar_zona]    Script Date: 08/10/2020 20:14:57 ******/
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
/****** Object:  StoredProcedure [dbo].[crear_ayudante]    Script Date: 08/10/2020 20:14:57 ******/
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
 @comision decimal(5,2),
 @deduccion decimal(5,2),
 @fecha_ingreso date
)

AS 

INSERT INTO ayudante (nombre,cedula,direccion,celular,telefono,comision,deduccion,fecha_ingreso)
VALUES
(@nombre,@cedula,@direccion,@celular,@telefono,@comision,@deduccion,@fecha_ingreso);


GO
/****** Object:  StoredProcedure [dbo].[crear_cliente]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[crear_cliente]
(@nombre varchar(50),
 @cedula varchar(13),
 @direccion varchar(50),
 @telefono varchar(20))
 AS
 INSERT INTO cliente(nombre,cedula,direccion,telefono)
 VALUES (@nombre,@cedula,@direccion,@telefono);


GO
/****** Object:  StoredProcedure [dbo].[crear_producto]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[crear_producto]
(@descripcion varchar(50),
 @costo money,
 @precio money,
 @existencias int)

 AS

 INSERT INTO inventario_productos (descripcion,costo,precio,existencias)
 VALUES
 (@descripcion,@costo,@precio,@existencias);
GO
/****** Object:  StoredProcedure [dbo].[crear_tarjeta]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[crear_tarjeta]
(@codigo_cliente int,
 @fecha_creacion date,
 @id_vendedor int,
 @id_zona int,
 @tipo_pago varchar(20))
AS
INSERT INTO tarjeta (codigo_cliente,fecha_creacion,id_vendedor,id_zona,tipo_pago)
VALUES (@codigo_cliente,@fecha_creacion,@id_vendedor,@id_zona,@tipo_pago);

GO
/****** Object:  StoredProcedure [dbo].[crear_vendedor_ca]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[crear_vendedor_ca]
(@nombre varchar(50),
 @cedula varchar(13),
 @direccion varchar(50),
 @celular varchar(20),
 @telefono varchar(20),
 @comision decimal(5,2),
 @deduccion decimal(5,2),
 @fecha_ingreso date,
 @id_ayudante int
)

AS 

INSERT INTO vendedor (nombre,cedula,direccion,celular,telefono,comision,deduccion,fecha_ingreso,id_ayudante)
VALUES
(@nombre,@cedula,@direccion,@celular,@telefono,@comision,@deduccion,@fecha_ingreso,@id_ayudante);
GO
/****** Object:  StoredProcedure [dbo].[crear_zona]    Script Date: 08/10/2020 20:14:57 ******/
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
/****** Object:  StoredProcedure [dbo].[despachar_vendedor]    Script Date: 08/10/2020 20:14:57 ******/
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
 UPDATE inventario_productos
 SET 
 existencias = existencias - @cantidad
 WHERE codigo_producto = @codigo_prodcuto;

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
/****** Object:  StoredProcedure [dbo].[detallesTarjeta]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[detallesTarjeta]
 (@codigo int)
 AS
 SELECT
 numero_detalle [Numero],
 fecha_detalle [Fecha],
 tipo [Tipo],
 debito[Debito],
 credito [Credito]
 FROM
 detalle_tarjeta 
 WHERE detalle_tarjeta.codigo_tarjeta = @codigo;
GO
/****** Object:  StoredProcedure [dbo].[devolver_a_inventario]    Script Date: 08/10/2020 20:14:57 ******/
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
/****** Object:  StoredProcedure [dbo].[eliminar_ayudante]    Script Date: 08/10/2020 20:14:57 ******/
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
/****** Object:  StoredProcedure [dbo].[eliminar_cliente]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 CREATE PROCEDURE [dbo].[eliminar_cliente]
 (@codigo_cliente int)
 AS
 DELETE FROM cliente
 WHERE cliente.codigo_cliente = @codigo_cliente;

GO
/****** Object:  StoredProcedure [dbo].[eliminar_tarjeta]    Script Date: 08/10/2020 20:14:57 ******/
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
/****** Object:  StoredProcedure [dbo].[eliminar_vendedor]    Script Date: 08/10/2020 20:14:57 ******/
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
/****** Object:  StoredProcedure [dbo].[eliminar_zona]    Script Date: 08/10/2020 20:14:57 ******/
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
/****** Object:  StoredProcedure [dbo].[nuevaDevolucion]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[nuevaDevolucion]
 (@codigo_tarjeta int,
 @fecha_detalle date,
 @monto decimal(9,2))
 AS
 DECLARE @num int
 SET @num = (SELECT COUNT(numero_detalle) FROM detalle_tarjeta WHERE detalle_tarjeta.codigo_tarjeta = @codigo_tarjeta)

 INSERT INTO detalle_tarjeta (numero_detalle,codigo_tarjeta,fecha_detalle,tipo,debito,credito)
 VALUES(@num+1,@codigo_tarjeta,@fecha_detalle,'Devolucion',@monto,0);
GO
/****** Object:  StoredProcedure [dbo].[nuevaVenta]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[nuevaVenta]
(@codigo_tarjeta int,
 @fecha_detalle date,
 @monto decimal(9,2))
 AS
 DECLARE @num int
 SET @num = (SELECT COUNT(numero_detalle) FROM detalle_tarjeta WHERE detalle_tarjeta.codigo_tarjeta = @codigo_tarjeta)

 INSERT INTO detalle_tarjeta (numero_detalle,codigo_tarjeta,fecha_detalle,tipo,debito,credito)
 VALUES(@num+1,@codigo_tarjeta,@fecha_detalle,'Venta',0,@monto);
GO
/****** Object:  StoredProcedure [dbo].[nuevoCobro]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[nuevoCobro]
 (@codigo_tarjeta int,
 @fecha_detalle date,
 @monto decimal(9,2))
 AS
 DECLARE @num int
 SET @num = (SELECT COUNT(numero_detalle) FROM detalle_tarjeta WHERE detalle_tarjeta.codigo_tarjeta = @codigo_tarjeta)

 INSERT INTO detalle_tarjeta (numero_detalle,codigo_tarjeta,fecha_detalle,tipo,debito,credito)
 VALUES(@num+1,@codigo_tarjeta,@fecha_detalle,'Cobro',@monto,0);
GO
/****** Object:  StoredProcedure [dbo].[nuevoDescuento]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[nuevoDescuento]
 (@codigo_tarjeta int,
 @fecha_detalle date,
 @monto decimal(9,2))
 AS
 DECLARE @num int
 SET @num = (SELECT COUNT(numero_detalle) FROM detalle_tarjeta WHERE detalle_tarjeta.codigo_tarjeta = @codigo_tarjeta)

 INSERT INTO detalle_tarjeta (numero_detalle,codigo_tarjeta,fecha_detalle,tipo,debito,credito)
 VALUES(@num+1,@codigo_tarjeta,@fecha_detalle,'Descuento',@monto,0);
GO
/****** Object:  StoredProcedure [dbo].[unica_tarjeta]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[unica_tarjeta]
 (@codigo int,
  @codigo_cliente int OUT,
 @fecha_creacion date OUT,
 @id_vendedor int OUT,
 @id_zona int OUT,
 @tipo_pago varchar(20) OUT)
 AS
 SELECT
 @codigo_cliente =cliente.codigo_cliente,
 @fecha_creacion = tarjeta.fecha_creacion ,
 @tipo_pago = tarjeta.tipo_pago ,
 @id_vendedor = vendedor.id_vendedor ,
 @id_zona = zona.id_zona 
 FROM 
tarjeta INNER JOIN cliente ON tarjeta.codigo_cliente = cliente.codigo_cliente
 INNER JOIN vendedor ON tarjeta.id_vendedor = vendedor.id_vendedor
 INNER JOIN zona ON tarjeta.id_zona = zona.id_zona

 WHERE tarjeta.codigo_tarjeta = @codigo;

GO
/****** Object:  StoredProcedure [dbo].[unica_tarjeta_completa]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[unica_tarjeta_completa]
 (@codigo int
 )
 AS
 SELECT
  tarjeta.codigo_tarjeta [Codigo],
 tarjeta.fecha_creacion [Fecha],
 tarjeta.tipo_pago [Forma de Pago],
 cliente.nombre [Cliente],
 cliente.cedula [Cedula],
 cliente.direccion [Direccion],
 cliente.telefono [Telefono],
 vendedor.nombre [Vendedor],
 zona.descripcion [Zona],
 vendedor.id_vendedor
 FROM 
tarjeta INNER JOIN cliente ON tarjeta.codigo_cliente = cliente.codigo_cliente
 INNER JOIN vendedor ON tarjeta.id_vendedor = vendedor.id_vendedor
 INNER JOIN zona ON tarjeta.id_zona = zona.id_zona

 WHERE tarjeta.codigo_tarjeta = @codigo;
GO
/****** Object:  StoredProcedure [dbo].[unica_zona]    Script Date: 08/10/2020 20:14:57 ******/
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
/****** Object:  StoredProcedure [dbo].[unico_ayudante]    Script Date: 08/10/2020 20:14:57 ******/
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
 @comision decimal(5,2) OUT,
 @deduccion decimal(5,2)OUT,
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
/****** Object:  StoredProcedure [dbo].[unico_cliente]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[unico_cliente]
(@codigo_cliente int,
 @nombre varchar(50) OUT,
 @cedula varchar(13) OUT,
 @direccion varchar(50) OUT,
 @telefono varchar(20) OUT)
 AS
 SELECT
 @nombre = cliente.nombre,
 @cedula = cliente.cedula,
 @telefono = cliente.telefono,
 @direccion = cliente.direccion
 FROM
 cliente WHERE cliente.codigo_cliente = @codigo_cliente;


GO
/****** Object:  StoredProcedure [dbo].[unico_producto]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[unico_producto]
 (@codigo int,
  @descripcion varchar(50) OUT,
  @costo money OUT,
  @precio money OUT,
  @existencias int OUT)

  AS
  SELECT
  @descripcion = descripcion,
  @costo = costo,
  @precio = precio,
  @existencias = existencias
  FROM inventario_productos WHERE codigo_producto =@codigo;
GO
/****** Object:  StoredProcedure [dbo].[unico_vendedor]    Script Date: 08/10/2020 20:14:57 ******/
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
 @comision decimal(5,2) OUT,
 @deduccion decimal(5,2)OUT,
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
/****** Object:  UserDefinedFunction [dbo].[balance_tarjeta]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE FUNCTION [dbo].[balance_tarjeta]
 (@codigo int)
 RETURNS INT
 AS
 BEGIN
 DECLARE @balance int
 SET @balance = (select (SUM (credito)- SUM (debito)) FROM detalle_tarjeta WHERE detalle_tarjeta.codigo_tarjeta = @codigo)
 RETURN @balance
 END
GO
/****** Object:  Table [dbo].[ayudante]    Script Date: 08/10/2020 20:14:57 ******/
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
	[comision] [decimal](5, 2) NULL,
	[deduccion] [decimal](5, 2) NULL,
	[fecha_ingreso] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ayudante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[codigo_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[cedula] [varchar](13) NULL,
	[direccion] [varchar](50) NULL,
	[telefono] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalle_tarjeta]    Script Date: 08/10/2020 20:14:57 ******/
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
	[debito] [decimal](9, 2) NULL,
	[credito] [decimal](9, 2) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[inventario_productos]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[inventario_productos](
	[codigo_producto] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[costo] [money] NULL,
	[precio] [money] NULL,
	[existencias] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[inventario_vendedor]    Script Date: 08/10/2020 20:14:57 ******/
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
/****** Object:  Table [dbo].[tarjeta]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tarjeta](
	[codigo_tarjeta] [int] IDENTITY(1,1) NOT NULL,
	[codigo_cliente] [int] NULL,
	[fecha_creacion] [date] NULL,
	[id_vendedor] [int] NULL,
	[id_zona] [int] NULL,
	[tipo_pago] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_tarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vendedor]    Script Date: 08/10/2020 20:14:57 ******/
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
	[comision] [decimal](5, 2) NULL,
	[deduccion] [decimal](5, 2) NULL,
	[id_ayudante] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_vendedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[zona]    Script Date: 08/10/2020 20:14:57 ******/
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
/****** Object:  View [dbo].[v_inventario_vendedor]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

  CREATE VIEW [dbo].[v_inventario_vendedor]
 
  AS
  SELECT
  inventario_productos.codigo_producto [Codigo],
  inventario_productos.descripcion [Descripcion],
  inventario_productos.precio [Precio],
  inventario_vendedor.existencias [Existencias],
  inventario_vendedor.id_vendedor
  FROM 
  inventario_vendedor INNER JOIN inventario_productos 
  ON inventario_vendedor.codigo_producto = inventario_productos.codigo_producto;

GO
/****** Object:  View [dbo].[vClientes]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE VIEW [dbo].[vClientes]
 AS
 SELECT 
 codigo_cliente [Codigo],
 nombre [Nombre],
 cedula [Cedula],
 telefono [Telefono],
 direccion [Direccion]
 FROM
 cliente;
GO
/****** Object:  View [dbo].[vProductos]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW [dbo].[vProductos]
  AS
  SELECT 
  codigo_producto [Codigo],
  descripcion [Descripcion],
  costo [Costo],
  precio [Precio],
  existencias [Existencias]

  FROM inventario_productos;
GO
/****** Object:  View [dbo].[vTarjetas]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW [dbo].[vTarjetas]
 AS
 SELECT 
 tarjeta.codigo_tarjeta [Codigo],
 tarjeta.fecha_creacion [Fecha],
 tarjeta.tipo_pago [Forma de Pago],
 cliente.nombre [Cliente],
 vendedor.nombre [Vendedor],
 zona.descripcion [Zona]

 FROM 
 tarjeta INNER JOIN cliente ON tarjeta.codigo_cliente = cliente.codigo_cliente
 INNER JOIN vendedor ON tarjeta.id_vendedor = vendedor.id_vendedor
 INNER JOIN zona ON tarjeta.id_zona = zona.id_zona;
GO
/****** Object:  View [dbo].[vVendedores]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vVendedores]
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
/****** Object:  View [dbo].[vZona]    Script Date: 08/10/2020 20:14:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vZona]
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

INSERT [dbo].[ayudante] ([id_ayudante], [nombre], [cedula], [direccion], [celular], [telefono], [comision], [deduccion], [fecha_ingreso]) VALUES (1, N'Ninguno', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ayudante] ([id_ayudante], [nombre], [cedula], [direccion], [celular], [telefono], [comision], [deduccion], [fecha_ingreso]) VALUES (3, N'JOSE LOPEZ', N'000-0000000-0', N'INDEPENDENCIA 134', N'000-000-0000', N'000-000-0000', CAST(0.00 AS Decimal(5, 2)), CAST(0.00 AS Decimal(5, 2)), CAST(0xA2410B00 AS Date))
INSERT [dbo].[ayudante] ([id_ayudante], [nombre], [cedula], [direccion], [celular], [telefono], [comision], [deduccion], [fecha_ingreso]) VALUES (4, N'LUIS DIAZ', N'000-0000000-0', N'INDEPENDENCIA 145', N'000-000-0000', N'000-000-0000', CAST(0.00 AS Decimal(5, 2)), CAST(0.00 AS Decimal(5, 2)), CAST(0xA2410B00 AS Date))
INSERT [dbo].[ayudante] ([id_ayudante], [nombre], [cedula], [direccion], [celular], [telefono], [comision], [deduccion], [fecha_ingreso]) VALUES (5, N'ROBERTO MELO', N'000-0000000-0', N'27 DE FEBRERO 89', N'000-000-0000', N'000-000-0000', CAST(0.00 AS Decimal(5, 2)), CAST(0.00 AS Decimal(5, 2)), CAST(0xA2410B00 AS Date))
INSERT [dbo].[ayudante] ([id_ayudante], [nombre], [cedula], [direccion], [celular], [telefono], [comision], [deduccion], [fecha_ingreso]) VALUES (6, N'ANA RAMIREZ', N'000-0000000-0', N'DUARTE 125', N'000-000-0000', N'000-000-0000', CAST(0.00 AS Decimal(5, 2)), CAST(0.00 AS Decimal(5, 2)), CAST(0xA2410B00 AS Date))
INSERT [dbo].[ayudante] ([id_ayudante], [nombre], [cedula], [direccion], [celular], [telefono], [comision], [deduccion], [fecha_ingreso]) VALUES (7, N'LUISA SANCHEZ', N'000-0000000-0', N'19 DE MARZO 170', N'000-000-0000', N'000-000-0000', CAST(0.00 AS Decimal(5, 2)), CAST(0.00 AS Decimal(5, 2)), CAST(0xA2410B00 AS Date))
SET IDENTITY_INSERT [dbo].[ayudante] OFF
SET IDENTITY_INSERT [dbo].[cliente] ON 

INSERT [dbo].[cliente] ([codigo_cliente], [nombre], [cedula], [direccion], [telefono]) VALUES (2, N'CLIENTE 1', N'000-0000000-0', N'DIRECCION 1', N'000-000-0000')
INSERT [dbo].[cliente] ([codigo_cliente], [nombre], [cedula], [direccion], [telefono]) VALUES (3, N'CLIENTE 2 ', N'000-0000000-0', N'DIRECCION 2', N'000-000-0000')
INSERT [dbo].[cliente] ([codigo_cliente], [nombre], [cedula], [direccion], [telefono]) VALUES (4, N'CLINETE 3', N'000-0000000-0', N'DIRECCION 3', N'000-000-0000')
INSERT [dbo].[cliente] ([codigo_cliente], [nombre], [cedula], [direccion], [telefono]) VALUES (5, N'CLIENTE 4', N'000-0000000-0', N'DIRECCION 4', N'000-000-0000')
INSERT [dbo].[cliente] ([codigo_cliente], [nombre], [cedula], [direccion], [telefono]) VALUES (6, N'CLIENTE 5', N'000-0000000-0', N'DIRECCION 5', N'000-000-0000')
SET IDENTITY_INSERT [dbo].[cliente] OFF
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito]) VALUES (1, 1, CAST(0xA6410B00 AS Date), N'Venta', CAST(0.00 AS Decimal(9, 2)), CAST(0.00 AS Decimal(9, 2)))
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito]) VALUES (2, 1, CAST(0xA6410B00 AS Date), N'Venta', CAST(0.00 AS Decimal(9, 2)), CAST(0.00 AS Decimal(9, 2)))
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito]) VALUES (3, 1, CAST(0xA6410B00 AS Date), N'Cobro', CAST(50.00 AS Decimal(9, 2)), CAST(0.00 AS Decimal(9, 2)))
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito]) VALUES (4, 1, CAST(0xA6410B00 AS Date), N'Descuento', CAST(50.00 AS Decimal(9, 2)), CAST(0.00 AS Decimal(9, 2)))
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito]) VALUES (5, 1, CAST(0xA6410B00 AS Date), N'Devolucion', CAST(50.00 AS Decimal(9, 2)), CAST(0.00 AS Decimal(9, 2)))
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito]) VALUES (6, 1, CAST(0xA6410B00 AS Date), N'Cobro', CAST(56.00 AS Decimal(9, 2)), CAST(0.00 AS Decimal(9, 2)))
INSERT [dbo].[detalle_tarjeta] ([numero_detalle], [codigo_tarjeta], [fecha_detalle], [tipo], [debito], [credito]) VALUES (7, 1, CAST(0xA6410B00 AS Date), N'Venta', CAST(0.00 AS Decimal(9, 2)), CAST(0.00 AS Decimal(9, 2)))
SET IDENTITY_INSERT [dbo].[inventario_productos] ON 

INSERT [dbo].[inventario_productos] ([codigo_producto], [descripcion], [costo], [precio], [existencias]) VALUES (1, N'Mesa', 0.0000, 0.0000, 14)
INSERT [dbo].[inventario_productos] ([codigo_producto], [descripcion], [costo], [precio], [existencias]) VALUES (2, N'Silla', 0.0000, 0.0000, 30)
INSERT [dbo].[inventario_productos] ([codigo_producto], [descripcion], [costo], [precio], [existencias]) VALUES (3, N'Sofa', 0.0000, 0.0000, 10)
INSERT [dbo].[inventario_productos] ([codigo_producto], [descripcion], [costo], [precio], [existencias]) VALUES (4, N'Cama', 0.0000, 0.0000, 10)
INSERT [dbo].[inventario_productos] ([codigo_producto], [descripcion], [costo], [precio], [existencias]) VALUES (5, N'Repisa', 0.0000, 0.0000, 15)
INSERT [dbo].[inventario_productos] ([codigo_producto], [descripcion], [costo], [precio], [existencias]) VALUES (6, N'Armario', 0.0000, 0.0000, 5)
INSERT [dbo].[inventario_productos] ([codigo_producto], [descripcion], [costo], [precio], [existencias]) VALUES (7, N'Silla Mesedora', 0.0000, 0.0000, 10)
SET IDENTITY_INSERT [dbo].[inventario_productos] OFF
INSERT [dbo].[inventario_vendedor] ([id_vendedor], [codigo_producto], [existencias]) VALUES (5, 1, 1)
SET IDENTITY_INSERT [dbo].[tarjeta] ON 

INSERT [dbo].[tarjeta] ([codigo_tarjeta], [codigo_cliente], [fecha_creacion], [id_vendedor], [id_zona], [tipo_pago]) VALUES (1, 2, CAST(0xA2410B00 AS Date), 5, 5, N'Semanal')
SET IDENTITY_INSERT [dbo].[tarjeta] OFF
SET IDENTITY_INSERT [dbo].[vendedor] ON 

INSERT [dbo].[vendedor] ([id_vendedor], [nombre], [cedula], [direccion], [telefono], [celular], [fecha_ingreso], [comision], [deduccion], [id_ayudante]) VALUES (5, N'MIGUEL LOPEZ', N'000-0000000-0', N'LAS CARRERAS 140', N'000-000-0000', N'000-000-0000', CAST(0xA2410B00 AS Date), CAST(0.00 AS Decimal(5, 2)), CAST(0.00 AS Decimal(5, 2)), 3)
INSERT [dbo].[vendedor] ([id_vendedor], [nombre], [cedula], [direccion], [telefono], [celular], [fecha_ingreso], [comision], [deduccion], [id_ayudante]) VALUES (6, N'ALEJANDRO MENDEZ', N'000-0000000-0', N'16 DE AGOSTO 210', N'000-000-0000', N'000-000-0000', CAST(0xA2410B00 AS Date), CAST(0.00 AS Decimal(5, 2)), CAST(0.00 AS Decimal(5, 2)), 4)
INSERT [dbo].[vendedor] ([id_vendedor], [nombre], [cedula], [direccion], [telefono], [celular], [fecha_ingreso], [comision], [deduccion], [id_ayudante]) VALUES (7, N'ALBERTO VARGAS', N'000-0000000-0', N'30 DE MARZO 105', N'000-000-0000', N'000-000-0000', CAST(0xA2410B00 AS Date), CAST(0.00 AS Decimal(5, 2)), CAST(0.00 AS Decimal(5, 2)), 5)
INSERT [dbo].[vendedor] ([id_vendedor], [nombre], [cedula], [direccion], [telefono], [celular], [fecha_ingreso], [comision], [deduccion], [id_ayudante]) VALUES (8, N'CRISTINA DIAZ', N'000-0000000-0', N'DUVERGE 40', N'000-000-0000', N'000-000-0000', CAST(0xA2410B00 AS Date), CAST(0.00 AS Decimal(5, 2)), CAST(0.00 AS Decimal(5, 2)), 6)
INSERT [dbo].[vendedor] ([id_vendedor], [nombre], [cedula], [direccion], [telefono], [celular], [fecha_ingreso], [comision], [deduccion], [id_ayudante]) VALUES (9, N'ROSA DE LEON', N'000-0000000-0', N'27 DE FEBRERO 23', N'000-000-0000', N'000-000-0000', CAST(0xA2410B00 AS Date), CAST(0.00 AS Decimal(5, 2)), CAST(0.00 AS Decimal(5, 2)), 7)
SET IDENTITY_INSERT [dbo].[vendedor] OFF
SET IDENTITY_INSERT [dbo].[zona] ON 

INSERT [dbo].[zona] ([id_zona], [id_vendedor], [descripcion]) VALUES (1, 5, N'MIGUEL LOPEZ/LUNES')
INSERT [dbo].[zona] ([id_zona], [id_vendedor], [descripcion]) VALUES (2, 6, N'ALEJANDRO MENDEZ/MARTES')
INSERT [dbo].[zona] ([id_zona], [id_vendedor], [descripcion]) VALUES (3, 7, N'ALBERTO VARGAS/MIERCOLES')
INSERT [dbo].[zona] ([id_zona], [id_vendedor], [descripcion]) VALUES (4, 8, N'CRISTINA DIAZ/JUEVES')
INSERT [dbo].[zona] ([id_zona], [id_vendedor], [descripcion]) VALUES (5, 9, N'ROSA DE LEON/VIERNES')
SET IDENTITY_INSERT [dbo].[zona] OFF
ALTER TABLE [dbo].[vendedor] ADD  DEFAULT (NULL) FOR [id_ayudante]
GO
ALTER TABLE [dbo].[detalle_tarjeta]  WITH CHECK ADD  CONSTRAINT [FK_CODIGO_TARJETA] FOREIGN KEY([codigo_tarjeta])
REFERENCES [dbo].[tarjeta] ([codigo_tarjeta])
GO
ALTER TABLE [dbo].[detalle_tarjeta] CHECK CONSTRAINT [FK_CODIGO_TARJETA]
GO
ALTER TABLE [dbo].[inventario_vendedor]  WITH CHECK ADD  CONSTRAINT [FK_IVENDEDOR_PRODCUTO] FOREIGN KEY([codigo_producto])
REFERENCES [dbo].[inventario_productos] ([codigo_producto])
GO
ALTER TABLE [dbo].[inventario_vendedor] CHECK CONSTRAINT [FK_IVENDEDOR_PRODCUTO]
GO
ALTER TABLE [dbo].[tarjeta]  WITH CHECK ADD  CONSTRAINT [FK_TARJETA_CLIENTE] FOREIGN KEY([codigo_cliente])
REFERENCES [dbo].[cliente] ([codigo_cliente])
GO
ALTER TABLE [dbo].[tarjeta] CHECK CONSTRAINT [FK_TARJETA_CLIENTE]
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
