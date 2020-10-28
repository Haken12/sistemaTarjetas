CREATE TABLE [dbo].[detalle_tarjeta] (
    [numero_detalle] INT          NULL,
    [codigo_tarjeta] INT          NULL,
    [fecha_detalle]  DATE         NULL,
    [tipo]           VARCHAR (20) NULL,
    [debito]         INT          NULL,
    [credito]        INT          NULL,
    [balance]        INT          NULL,
    [referencia]     INT          NULL,
    CONSTRAINT [FK_CODIGO_TARJETA] FOREIGN KEY ([codigo_tarjeta]) REFERENCES [dbo].[tarjeta] ([codigo_tarjeta])
);

