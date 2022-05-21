CREATE TABLE [dbo].[ventas] (
    [numero_venta]   INT  IDENTITY (1, 1) NOT NULL,
    [fecha]          DATE NULL,
    [codigo_tarjeta] INT  NULL,
    [total]          INT  NULL,
    PRIMARY KEY CLUSTERED ([numero_venta] ASC)
);

