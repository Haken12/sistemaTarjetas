 CREATE FUNCTION zona_existe
  (@id int)
  RETURNS INT 
  AS
  BEGIN
  DECLARE @n int
  SET @n = (SELECT COUNT(id_zona) FROM zona WHERE zona.id_zona = @id)
  RETURN @n
  END