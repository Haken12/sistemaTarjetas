 CREATE PROCEDURE eliminar_zona
 (@id_zona int)
 AS
 DELETE FROM zona
 WHERE zona.id_zona = @id_zona;