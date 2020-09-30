CREATE PROCEDURE crear_zona
(@id_vendedor int,
 @descripcion varchar(70))
 AS
 INSERT INTO zona(id_vendedor,descripcion)
 VALUES (@id_vendedor,@descripcion);

 GO

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

 GO


 CREATE PROCEDURE eliminar_zona
 (@id_zona int)
 AS
 DELETE FROM zona
 WHERE zona.id_zona = @id_zona;

 GO
 
 CREATE VIEW vZona
 AS
 SELECT 
 zona.id_vendedor [Id],
 zona.descripcion [Descripcion],
 vendedor.id_vendedor,
 vendedor.nombre [Vendedor]
 FROM
 zona INNER JOIN vendedor
 ON zona.id_vendedor = vendedor.id_vendedor;

 GO 

 CREATE PROCEDURE unica_zona
 (@id int,
  @descripcion varchar(70) OUT,
  @id_vendedor int OUT ,
  @nombre_vendedor varchar(50)OUT)
  AS
  SELECT
  @descripcion = zona.descripcion,
  @id_vendedor = zona.id_vendedor,
  @nombre_vendedor = vendedor.nombre
  FROM 
  zona INNER JOIN vendedor
  ON zona.id_vendedor = vendedor.id_vendedor
  WHERE zona.id_zona = @id;
