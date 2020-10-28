
CREATE VIEW v_vendedor
AS
SELECT
vendedor.id_vendedor [Id],
vendedor.nombre [Nombre],
vendedor.cedula [Cedula],
vendedor.direccion [Direccion],
vendedor.telefono [Telefono],
vendedor.celular [Celular],
vendedor.comision [Comision],
vendedor.deduccion [Deduccion],
vendedor.fecha_ingreso [Ingreso],
ayudante.id_ayudante,
ayudante.nombre [Ayudante]
FROM 
vendedor INNER JOIN ayudante
ON vendedor.id_ayudante = ayudante.id_ayudante;