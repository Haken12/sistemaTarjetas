CREATE PROCEDURE [dbo].[nuevo_despacho]
(@vendedor int,
@observacion varchar(200),
@articulos int,
@total int
,@fecha date
,@id int OUT)
AS
INSERT INTO despacho(id_vendedor,observacion,cantidad_articulos,total,fecha)
VALUES (@vendedor,@observacion,@articulos,0,@fecha);
SET @id = SCOPE_IDENTITY();