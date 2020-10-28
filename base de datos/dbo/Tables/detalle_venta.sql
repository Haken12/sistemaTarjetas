CREATE TABLE [dbo].[detalle_venta] (
    [numero_venta]    INT NULL,
    [numero_detalle]  INT NULL,
    [codigo_producto] INT NULL,
    [precio]          INT NULL,
    [cantidad]        INT NULL,
    [importe]         INT NULL,
    [devueltos]       INT NULL,
    CONSTRAINT [FK_DETALLE_VENTA] FOREIGN KEY ([numero_venta]) REFERENCES [dbo].[ventas] ([numero_venta]),
    CONSTRAINT [FK_DV_PRODUCTO] FOREIGN KEY ([codigo_producto]) REFERENCES [dbo].[inventario_productos] ([codigo_producto])
);

