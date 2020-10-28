CREATE PROCEDURE [dbo].nombreVendedor
(
	@id int
)
AS
	SET NOCOUNT ON;
SELECT nombre 
FROM vendedor
WHERE vendedor.id_vendedor = @id