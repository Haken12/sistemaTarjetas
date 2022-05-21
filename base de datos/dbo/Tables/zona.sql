CREATE TABLE [dbo].[zona] (
    [id_zona]     INT          IDENTITY (1, 1) NOT NULL,
    [id_vendedor] INT          NULL,
    [descripcion] VARCHAR (70) NULL,
    PRIMARY KEY CLUSTERED ([id_zona] ASC),
    CONSTRAINT [FK_ZONA_VENDEDOR] FOREIGN KEY ([id_vendedor]) REFERENCES [dbo].[vendedor] ([id_vendedor])
);

