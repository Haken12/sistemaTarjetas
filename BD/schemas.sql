CREATE DATABASE sistemaTarjetas;

GO

USE sistemaTarjetas;

GO

CREATE TABLE ayudante(
id_ayudante int identity not null primary key,
nombre varchar(50) not null,
cedula varchar(13),
direccion varchar(50),
celular varchar(20),
telefono varchar(20),
comision decimal(5,2),
deduccion decimal(5,2),
fecha_ingreso date
);

GO

CREATE TABLE vendedor(
id_vendedor int identity not null primary key,
nombre varchar(50) not null,
cedula varchar(13) not null,
direccion varchar(50),
telefono varchar(20),
celular varchar(20),
fecha_ingreso date,
comision decimal(5,2),
deduccion decimal(5,2),
id_ayudante int default (NULL),
CONSTRAINT FK_VENDEDOR_AYUDANTE FOREIGN KEY (id_ayudante) REFERENCES ayudante(id_ayudante)
 );

GO

 CREATE TABLE zona(
 id_zona int identity not null primary key,
 id_vendedor int,
 descripcion varchar(70),
 CONSTRAINT FK_ZONA_VENDEDOR FOREIGN KEY (id_vendedor) REFERENCES vendedor(id_vendedor) );

  CREATE TABLE cliente(
 codigo_cliente int identity not null primary key,
 nombre varchar(50) not null,
 cedula varchar(13),
 direccion varchar(50),
 telefono varchar(20)
 );

GO

 CREATE TABLE tarjeta(
 codigo_tarjeta int identity primary key not null,
 codigo_cliente int,
 fecha_creacion date,
 id_vendedor int,
 id_zona int,
 tipo_pago varchar(20),
 CONSTRAINT FK_TARJETA_VENDEDOR FOREIGN KEY (id_vendedor) REFERENCES vendedor(id_vendedor),
 CONSTRAINT FK_TARJETA_ZONA FOREIGN KEY (id_zona) REFERENCES zona(id_zona),
 CONSTRAINT FK_TARJETA_CLIENTE FOREIGN KEY (codigo_cliente) REFERENCES cliente(codigo_cliente)
 );

 GO
 CREATE TABLE detalle_tarjeta(
 numero_detalle int,
 codigo_tarjeta int,
 fecha_detalle date,
 tipo varchar(20),
 debito decimal(9,2),
 credito decimal(9,2),
 CONSTRAINT FK_CODIGO_TARJETA FOREIGN KEY (codigo_tarjeta) REFERENCES tarjeta(codigo_tarjeta),	
 );




 