CREATE TABLE [dbo].[detalle_devolucion] (
    [numero_devolucion] INT NULL,
    [numero_detalle]    INT NULL,
    [codigo_articulo]   INT NULL,
    [cantidad]          INT NULL,
    [precio]            INT NULL,
    [valor]             INT NULL,
    CONSTRAINT [FK_DETALLE_DEVOLUCION] FOREIGN KEY ([numero_devolucion]) REFERENCES [dbo].[devoluciones] ([numero_devolucion])
);

