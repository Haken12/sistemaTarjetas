 CREATE VIEW v_zona
 AS
 SELECT 
 zona.id_vendedor [Id],
 zona.descripcion [Descripcion],
 vendedor.id_vendedor,
 vendedor.nombre [Vendedor]
 FROM
 zona INNER JOIN vendedor
 ON zona.id_vendedor = vendedor.id_vendedor;