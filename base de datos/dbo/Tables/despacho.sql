CREATE TABLE [dbo].[despacho] (
    [numero_despacho]    INT           IDENTITY (1, 1) NOT NULL,
    [id_vendedor]        INT           NULL,
    [observacion]        VARCHAR (200) NULL,
    [cantidad_articulos] INT           NULL,
    [total]              INT           NULL,
    [fecha]              DATE          NULL,
    PRIMARY KEY CLUSTERED ([numero_despacho] ASC)
);

