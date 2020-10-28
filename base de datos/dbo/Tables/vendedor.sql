CREATE TABLE [dbo].[vendedor] (
    [id_vendedor]   INT          IDENTITY (1, 1) NOT NULL,
    [nombre]        VARCHAR (50) NOT NULL,
    [cedula]        VARCHAR (13) NOT NULL,
    [direccion]     VARCHAR (50) NULL,
    [telefono]      VARCHAR (20) NULL,
    [celular]       VARCHAR (20) NULL,
    [fecha_ingreso] DATE         NULL,
    [comision]      INT          NULL,
    [deduccion]     INT          NULL,
    [id_ayudante]   INT          DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id_vendedor] ASC),
    CONSTRAINT [FK_VENDEDOR_AYUDANTE] FOREIGN KEY ([id_ayudante]) REFERENCES [dbo].[ayudante] ([id_ayudante])
);

