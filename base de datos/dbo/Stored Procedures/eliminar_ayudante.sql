
CREATE PROCEDURE eliminar_ayudante
(@id_ayudante int)
AS
DELETE FROM ayudante 
WHERE ayudante.id_ayudante = @id_ayudante;

