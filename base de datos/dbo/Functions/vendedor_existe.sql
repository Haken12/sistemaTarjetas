CREATE FUNCTION vendedor_existe
(@id int)
RETURNS INT
AS
BEGIN
DECLARE @n int
SET @n = (SELECT COUNT(id_vendedor) FROM vendedor WHERE vendedor.id_vendedor = @id)
RETURN @n
END