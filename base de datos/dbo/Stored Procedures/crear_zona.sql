CREATE PROCEDURE crear_zona
(@id_vendedor int,
 @descripcion varchar(70))
 AS
 INSERT INTO zona(id_vendedor,descripcion)
 VALUES (@id_vendedor,@descripcion);
