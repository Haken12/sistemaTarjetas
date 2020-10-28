 CREATE VIEW v_tarjetas
 AS
 SELECT 
tarjeta.codigo_tarjeta [Codigo],
tarjeta.nombre [Nombre],
tarjeta.referencia [Referencia],
tarjeta.cedula [Cedula],
tarjeta.telefono [Telefono],
tarjeta.fecha_creacion [Fecha],
vendedor.id_vendedor [Id Vendedor],
vendedor.nombre [Vendedor],
zona.id_zona [Id Zona],
zona.descripcion [Zona]

 FROM 
 tarjeta 
 INNER JOIN vendedor ON tarjeta.id_vendedor = vendedor.id_vendedor
 INNER JOIN zona ON tarjeta.id_zona = zona.id_zona;