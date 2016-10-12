DROP PROCEDURE TERCER_IMPACTO.CREAR_PROFESIONALES
DROP PROCEDURE TERCER_IMPACTO.CREAR_TIPO_Y_ESPECIALIDAD
DROP PROCEDURE TERCER_IMPACTO.CREAR_DIA_PROFESIONAL_DIA
DROP PROCEDURE TERCER_IMPACTO.CREAR_PLAN_MEDICO
DROP PROCEDURE TERCER_IMPACTO.MIGRAR_PLAN_MED
DROP PROCEDURE TERCER_IMPACTO.MIGRAR_PROFESIONALES
DROP PROCEDURE TERCER_IMPACTO.MIGRAR_ESPECIALIDADES_TIPOS
DROP PROCEDURE TERCER_IMPACTO.MIGRAR_PROFESIONAL_ESPECIALIDAD

DROP TABLE TERCER_IMPACTO.PROFESIONAL_DIA --NADA QUE MIGRAR
DROP TABLE TERCER_IMPACTO.DIA --NADA QUE MIGRAR
DROP TABLE TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD
DROP TABLE TERCER_IMPACTO.ESPECIALIDAD
DROP TABLE TERCER_IMPACTO.TIPO_ESPECIALIDAD
DROP TABLE TERCER_IMPACTO.PROFESIONAL
DROP TABLE TERCER_IMPACTO.PLAN_MEDICO


DROP SCHEMA TERCER_IMPACTO

USE [GD2C2016]
GO

--CREACION DEL ESQUEMA NOMBRE DEL GRUPO--
CREATE SCHEMA [TERCER_IMPACTO] AUTHORIZATION [GD]
GO



CREATE PROCEDURE TERCER_IMPACTO.CREAR_PROFESIONALES
AS
BEGIN
	CREATE TABLE TERCER_IMPACTO.PROFESIONAL(
		MATRICULA NUMERIC(18,0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
		NOMBRE VARCHAR(255),
		TIPO_DOC VARCHAR(20),
		NRO_DOC NUMERIC(18,0),
		DIRECCION VARCHAR(255),
		TELEFONO NUMERIC(18,0),
		MAIL VARCHAR(255),
		FECHA_NAC DATETIME,
		SEXO VARCHAR(1),
		APELLIDO VARCHAR(255)
	
	)
END
GO

CREATE PROCEDURE TERCER_IMPACTO.CREAR_TIPO_Y_ESPECIALIDAD
AS
BEGIN
	CREATE TABLE TERCER_IMPACTO.TIPO_ESPECIALIDAD(
		ID_TIPO_ESPECIALIDAD NUMERIC(18,0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
		DESCRIPCION VARCHAR(255)
		)

	CREATE TABLE TERCER_IMPACTO.ESPECIALIDAD(
		ID_ESPECIALIDAD NUMERIC(18,0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
		DESCRIPCION VARCHAR(255),
		TIPO_ESPECIALIDAD NUMERIC(18,0) FOREIGN KEY REFERENCES 
		TERCER_IMPACTO.TIPO_ESPECIALIDAD(ID_TIPO_ESPECIALIDAD)
		)
		
	CREATE TABLE TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD(
		ID_PROFESIONAL NUMERIC(18,0) NOT NULL 
		FOREIGN KEY REFERENCES
		TERCER_IMPACTO.PROFESIONAL(MATRICULA),
		ID_ESPECIALIDAD NUMERIC(18,0) NOT NULL 
		FOREIGN KEY REFERENCES
		TERCER_IMPACTO.ESPECIALIDAD(ID_ESPECIALIDAD),
		CONSTRAINT PROF_ESP_PK PRIMARY KEY(ID_PROFESIONAL,ID_ESPECIALIDAD)
		)
END
GO

CREATE PROCEDURE TERCER_IMPACTO.CREAR_DIA_PROFESIONAL_DIA
AS
BEGIN
	CREATE TABLE TERCER_IMPACTO.DIA(
		ID_DIA NUMERIC(18,0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
		FECHA DATE NOT NULL)
		
	CREATE TABLE TERCER_IMPACTO.PROFESIONAL_DIA(
		ID_PROFESIONAL NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES
		TERCER_IMPACTO.PROFESIONAL(MATRICULA),
		ID_ESPECIALIDAD NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES
		TERCER_IMPACTO.ESPECIALIDAD(ID_ESPECIALIDAD),
		ID_DIA NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES
		TERCER_IMPACTO.DIA(ID_DIA),
		COMIENZO TIME NOT NULL,
		FIN TIME NOT NULL,
		CONSTRAINT PROF_DIA_PK PRIMARY KEY (ID_PROFESIONAL,						ID_ESPECIALIDAD,
		ID_DIA)
		)

END
GO

CREATE PROCEDURE TERCER_IMPACTO.CREAR_PLAN_MEDICO
AS
BEGIN
	CREATE TABLE TERCER_IMPACTO.PLAN_MEDICO(
		ID_PLAN_MEDICO NUMERIC(18,0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
		DESCRIPCION VARCHAR(255),
		PRECIO_BONO_CONSULTA NUMERIC(18,0),
		PRECIO_BONO_FARMACIA NUMERIC(18,0) 
	)
END
GO

--SET IDENTITY INSERT NOMBRETABLA ON
--SET IDENTITY INSERT NOMBRETABLA OFF

CREATE PROCEDURE TERCER_IMPACTO.MIGRAR_PLAN_MED
AS
BEGIN
	SET IDENTITY_INSERT TERCER_IMPACTO.PLAN_MEDICO ON;
	INSERT INTO TERCER_IMPACTO.PLAN_MEDICO (ID_PLAN_MEDICO,
	DESCRIPCION,PRECIO_BONO_CONSULTA,PRECIO_BONO_FARMACIA)
	SELECT DISTINCT PLAN_MED_CODIGO, Plan_Med_Descripcion,
	Plan_Med_Precio_Bono_Consulta, Plan_Med_Precio_Bono_Farmacia 
	FROM gd_esquema.Maestra WHERE Plan_Med_Codigo IS NOT NULL
	SET IDENTITY_INSERT TERCER_IMPACTO.PLAN_MEDICO OFF;
END
GO

CREATE PROCEDURE TERCER_IMPACTO.MIGRAR_PROFESIONALES
AS
BEGIN
	INSERT INTO TERCER_IMPACTO.PROFESIONAL(NRO_DOC,NOMBRE,
	TIPO_DOC,DIRECCION,TELEFONO, MAIL, FECHA_NAC,
	APELLIDO) 
	SELECT DISTINCT Medico_Dni,Medico_Nombre,'DNI', Medico_Direccion,
	Medico_Telefono,Medico_Mail,Medico_Fecha_Nac,Medico_Apellido
	FROM gd_esquema.Maestra WHERE Medico_Dni IS NOT NULL
	--el sexo se agregara mas tarde	porque no estamos seguros de algunos sexos		

END
GO

CREATE PROCEDURE TERCER_IMPACTO.MIGRAR_ESPECIALIDADES_TIPOS
AS
BEGIN

	SET IDENTITY_INSERT TERCER_IMPACTO.TIPO_ESPECIALIDAD ON;
	
	INSERT INTO TERCER_IMPACTO.TIPO_ESPECIALIDAD
	(ID_TIPO_ESPECIALIDAD,DESCRIPCION)
	SELECT DISTINCT Tipo_Especialidad_Codigo,Tipo_Especialidad_Descripcion 
	FROM gd_esquema.Maestra WHERE Tipo_Especialidad_Codigo IS NOT NULL;
	
	SET IDENTITY_INSERT TERCER_IMPACTO.TIPO_ESPECIALIDAD OFF;
	
	SET IDENTITY_INSERT TERCER_IMPACTO.ESPECIALIDAD ON;
	
	INSERT INTO TERCER_IMPACTO.ESPECIALIDAD
	(ID_ESPECIALIDAD,DESCRIPCION,TIPO_ESPECIALIDAD)
	SELECT DISTINCT Especialidad_Codigo,Especialidad_Descripcion,
	Tipo_Especialidad_Codigo

	FROM gd_esquema.Maestra WHERE Especialidad_Codigo IS NOT NULL
	
	SET IDENTITY_INSERT TERCER_IMPACTO.ESPECIALIDAD OFF;
	
END
GO

CREATE PROCEDURE TERCER_IMPACTO.MIGRAR_PROFESIONAL_ESPECIALIDAD
AS
BEGIN
	INSERT INTO TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD
	(ID_PROFESIONAL,ID_ESPECIALIDAD)
	SELECT MATRICULA,Especialidad_Codigo  FROM
	TERCER_IMPACTO.PROFESIONAL AS PRO
	JOIN gd_esquema.Maestra AS MA
	ON MA.Medico_Dni=PRO.NRO_DOC
	GROUP BY MATRICULA, Especialidad_Codigo
	
END
GO



EXEC TERCER_IMPACTO.CREAR_PROFESIONALES;
EXEC TERCER_IMPACTO.CREAR_TIPO_Y_ESPECIALIDAD;
EXEC TERCER_IMPACTO.CREAR_DIA_PROFESIONAL_DIA;
EXEC TERCER_IMPACTO.CREAR_PLAN_MEDICO;
EXEC TERCER_IMPACTO.MIGRAR_PLAN_MED;
EXEC TERCER_IMPACTO.MIGRAR_PROFESIONALES;
EXEC TERCER_IMPACTO.MIGRAR_ESPECIALIDADES_TIPOS;
EXEC TERCER_IMPACTO.MIGRAR_PROFESIONAL_ESPECIALIDAD;

