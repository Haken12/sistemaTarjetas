CREATE TABLE [dbo].[inventario_productos] (
    [codigo_producto] INT          IDENTITY (1, 1) NOT NULL,
    [descripcion]     VARCHAR (50) NULL,
    [costo]           INT          NULL,
    [precio]          INT          NULL,
    [existencias]     INT          NULL,
    PRIMARY KEY CLUSTERED ([codigo_producto] ASC)
);

