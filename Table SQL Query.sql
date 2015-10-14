/* DDL de Creacion de Tablas */
/* Nombre del Servidor:A-SRV-BDINST */
/*Usuario: Protectores */
/*Clave: t4.2015  */

                
CREATE TABLE USUARIO 	(
				  		CORREO varchar(255)primary key NOT NULL,
                  		NOMBRE varchar(255)NOT NULL,
                  		APELLIDO varchar (255)NOT NULL,
                  		ORGANIZACION varchar(255)NULL,
                  		CLAVE varchar (255)NOT NULL,
				  		TELEFONO varchar(255)NULL,
                  		DIRECCION varchar(255)NULL
		                  );

CREATE TABLE DIRECCION_ADOPTADOR(
                                 CORREO varchar(255),
								 LATITUD varchar (255)NOT NULL,
								 LONGITUD varchar (255)NOT NULL
								);
CREATE TABLE DIRECCION_PROTECTOR(
                      			 CORREO varchar(255)NOT NULL,
								 LATITUD varchar (255)NOT NULL,
								 LONGITUD varchar (255)NOT NULL                       
								 ); 

CREATE TABLE PEDIDOS (
					  CORREO varchar(255),
					  FEHCAHORA varchar(255)NOT NULL,
					  LATITUD varchar (255)NOT NULL,
                      LONGITUD varchar (255)NOT NULL
					  );

CREATE TABLE ANIMALES (
						CORREO varchar (255),
						NOMBRE varchar (255)NOT NULL,
						ESPECIE varchar (255) NOT NULL,
						FOTO image NULL
						); 

CREATE TABLE TIPOS (
						CORREO varchar (255),
						TIPO varchar (255)NOT NULL
						); 

/*
DROP TABLE PROTECTORES
DROP TABLE DIRECCION_ADOPTADOR
DROP TABLE DIRECCION_PROTECTOR
DROP TABLE PEDIDOS
DROP TABLE ANIMALES
DROP TABLE TIPOS
*/ 
