CREATE DATABASE simticaf;

USE simticaf;

CREATE TABLE usuarios (
    id_control  INTEGER NOT NULL AUTO_INCREMENT,
    nombre      VARCHAR(20) NOT NULL,
    apellido1   VARCHAR(20) NOT NULL,
    apellido2   VARCHAR(20) NOT NULL,
    telefono    VARCHAR(15) NOT NULL,
    correo      VARCHAR(25) NOT NULL,
    usuario     VARCHAR(15) NOT NULL,
    pass        VARCHAR(8) NOT NULL,
    PRIMARY KEY (id_control)
);

CREATE TABLE registros (
    id_registro     INTEGER NOT NULL AUTO_INCREMENT,
    cantidad        INTEGER NOT NULL,
    preciou         FLOAT NOT NULL,
    creacion        TIMESTAMP NOT NULL,
    id_categoria    INTEGER NOT NULL,
    descripcion     VARCHAR(50) NOT NULL,
    PRIMARY KEY (id_registro)
);

CREATE TABLE categorias (
    id_categoria    INTEGER NOT NULL AUTO_INCREMENT,
    descripcion     VARCHAR(50),
    PRIMARY KEY (id_categoria)
);