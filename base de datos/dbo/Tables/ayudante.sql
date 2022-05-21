CREATE TABLE [dbo].[ayudante] (
    [id_ayudante]   INT          IDENTITY (1, 1) NOT NULL,
    [nombre]        VARCHAR (50) NOT NULL,
    [cedula]        VARCHAR (13) NULL,
    [direccion]     VARCHAR (50) NULL,
    [celular]       VARCHAR (20) NULL,
    [telefono]      VARCHAR (20) NULL,
    [comision]      INT          NULL,
    [deduccion]     INT          NULL,
    [fecha_ingreso] DATE         NULL,
    PRIMARY KEY CLUSTERED ([id_ayudante] ASC)
);

