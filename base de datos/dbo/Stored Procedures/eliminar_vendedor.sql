

CREATE PROCEDURE eliminar_vendedor
(@id_vendedor int)
AS
DELETE FROM vendedor 
WHERE vendedor.id_vendedor = @id_vendedor;
