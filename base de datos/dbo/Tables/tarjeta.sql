CREATE TABLE [dbo].[tarjeta] (
    [codigo_tarjeta] INT          IDENTITY (1, 1) NOT NULL,
    [nombre]         VARCHAR (50) NULL,
    [referencia]     VARCHAR (50) NULL,
    [cedula]         VARCHAR (13) NULL,
    [telefono]       VARCHAR (20) NULL,
    [fecha_creacion] DATE         NULL,
    [id_vendedor]    INT          NULL,
    [id_zona]        INT          NULL,
    [tipo_pago]      VARCHAR (20) NULL,
    [debito]         INT          NULL,
    [credito]        INT          NULL,
    [balance]        INT          NULL,
    PRIMARY KEY CLUSTERED ([codigo_tarjeta] ASC),
    CONSTRAINT [FK_TARJETA_VENDEDOR] FOREIGN KEY ([id_vendedor]) REFERENCES [dbo].[vendedor] ([id_vendedor]),
    CONSTRAINT [FK_TARJETA_ZONA] FOREIGN KEY ([id_zona]) REFERENCES [dbo].[zona] ([id_zona])
);

