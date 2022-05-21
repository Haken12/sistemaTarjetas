CREATE FUNCTION ayudante_existe
(@id int)
RETURNS int
AS
BEGIN
DECLARE @n int
SET @n = (SELECT COUNT(id_ayudante) FROM ayudante WHERE ayudante.id_ayudante = @id)
RETURN @n
END
