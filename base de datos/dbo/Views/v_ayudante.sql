CREATE VIEW v_ayudante
AS
SELECT
id_ayudante [Id],
nombre [Nombre],
cedula [Cedula],
direccion [Direccion],
telefono [Telefono],
celular [Celular],
comision [Comision],
deduccion [Deduccion],
fecha_ingreso [Fecha Ingreso]
FROM 
ayudante;