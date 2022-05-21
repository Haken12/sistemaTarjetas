CREATE TABLE [dbo].[devoluciones] (
    [numero_devolucion] INT  IDENTITY (1, 1) NOT NULL,
    [fecha]             DATE NULL,
    [codigo_tarjeta]    INT  NULL,
    [valor]             INT  NULL,
    PRIMARY KEY CLUSTERED ([numero_devolucion] ASC),
    CONSTRAINT [FK_DEVOLUCION_TARJETA] FOREIGN KEY ([codigo_tarjeta]) REFERENCES [dbo].[tarjeta] ([codigo_tarjeta])
);

