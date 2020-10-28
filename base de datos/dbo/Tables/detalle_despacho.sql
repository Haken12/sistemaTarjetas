CREATE TABLE [dbo].[detalle_despacho] (
    [numero_despacho] INT NULL,
    [numero_detalle]  INT NULL,
    [codigo_producto] INT NULL,
    [precio]          INT NULL,
    [cantidad]        INT NULL,
    [importe]         INT NULL,
    CONSTRAINT [FK_DETALLE_DESPACHO] FOREIGN KEY ([numero_despacho]) REFERENCES [dbo].[despacho] ([numero_despacho]),
    CONSTRAINT [FK_DETALLE_PRODUCTO] FOREIGN KEY ([codigo_producto]) REFERENCES [dbo].[inventario_productos] ([codigo_producto])
);

