
 CREATE PROCEDURE actualizar_zona
 (@id_zona int,
  @id_vendedor int,
  @descripcion varchar(70)
  )
 AS
 UPDATE zona
 SET
 id_vendedor = @id_vendedor,
 descripcion = @descripcion
 WHERE zona.id_zona  = @id_zona;