CREATE TABLE [dbo].[inventario_vendedor] (
    [id_vendedor]     INT NULL,
    [codigo_producto] INT NULL,
    [existencias]     INT NULL,
    CONSTRAINT [FK_IVENDEDOR_PRODCUTO] FOREIGN KEY ([codigo_producto]) REFERENCES [dbo].[inventario_productos] ([codigo_producto])
);

