--EJECUTAR PARA HACER DROP DEL SCHEMA-----------
DROP PROCEDURE TERCER_IMPACTO.CREAR_ROL_USUA_FUNC
DROP PROCEDURE TERCER_IMPACTO.CREAR_PROFESIONALES
DROP PROCEDURE TERCER_IMPACTO.CREAR_TIPO_Y_ESPECIALIDAD
DROP PROCEDURE TERCER_IMPACTO.CREAR_DIA_PROFESIONAL_DIA
DROP PROCEDURE TERCER_IMPACTO.CREAR_PLAN_MEDICO
DROP PROCEDURE TERCER_IMPACTO.MIGRAR_PLAN_MED
DROP PROCEDURE TERCER_IMPACTO.MIGRAR_PROFESIONALES
DROP PROCEDURE TERCER_IMPACTO.MIGRAR_ESPECIALIDADES_TIPOS
DROP PROCEDURE TERCER_IMPACTO.MIGRAR_PROFESIONAL_ESPECIALIDAD
DROP PROCEDURE TERCER_IMPACTO.LLENAR_TABLA_ROL_FUNC
DROP PROCEDURE TERCER_IMPACTO.MIGRAR_USUARIOS
DROP FUNCTION TERCER_IMPACTO.COMPARAR_HASH
DROP PROCEDURE TERCER_IMPACTO.DESHABILITAR_ROL
DROP PROCEDURE TERCER_IMPACTO.AGREGAR_FUNCIONALIDAD
DROP PROCEDURE TERCER_IMPACTO.AGREGAR_DIA
DROP PROCEDURE TERCER_IMPACTO.SACAR_TURNO
DROP FUNCTION TERCER_IMPACTO.EXISTE_TURNO
DROP PROCEDURE TERCER_IMPACTO.COMPRAR_BONOS
DROP FUNCTION TERCER_IMPACTO.RETORNAR_PRECIO_BONOS
DROP PROCEDURE TERCER_IMPACTO.MIGRAR_AGENDA
DROP FUNCTION TERCER_IMPACTO.NRO_UTILIZADO

---------------MAURO
DROP PROCEDURE TERCER_IMPACTO.CREAR_AFILIADOS
DROP PROCEDURE TERCER_IMPACTO.CREAR_TURNO
DROP PROCEDURE TERCER_IMPACTO.CREAR_CONSULTA
DROP PROCEDURE TERCER_IMPACTO.CREAR_BONO
DROP PROCEDURE TERCER_IMPACTO.MIGRAR_TURNO
DROP PROCEDURE TERCER_IMPACTO.MIGRAR_CONSULTA
DROP PROCEDURE TERCER_IMPACTO.MIGRAR_BONO
DROP PROCEDURE TERCER_IMPACTO.MIGRAR_COMPRA_BONO
DROP PROCEDURE TERCER_IMPACTO.MIGRAR_AFILIADOS
DROP PROCEDURE TERCER_IMPACTO.AGREGAR_ID_CONSULTA
DROP PROCEDURE TERCER_IMPACTO.AGREGAR_SINTOMA
DROP PROCEDURE TERCER_IMPACTO.AGREGAR_ENFERMEDAD
DROP FUNCTION TERCER_IMPACTO.EXISTE_CONSULTA
DROP PROCEDURE TERCER_IMPACTO.AGREGAR_CANCELACION
DROP PROCEDURE TERCER_IMPACTO.CREAR_CANCELACION
DROP PROCEDURE TERCER_IMPACTO.CANCELAR_TURNO_PROF
---------------
DROP TABLE TERCER_IMPACTO.HISTORIAL_CAMBIO
DROP TABLE TERCER_IMPACTO.CANCELACION

DROP TABLE TERCER_IMPACTO.BONO
DROP TABLE TERCER_IMPACTO.COMPRA_BONO
DROP TABLE TERCER_IMPACTO.CONSULTA
DROP TABLE TERCER_IMPACTO.TURNO
DROP TABLE TERCER_IMPACTO.AFILIADO

DROP TABLE TERCER_IMPACTO.PROFESIONAL_DIA --NADA QUE MIGRAR
DROP TABLE TERCER_IMPACTO.DIA --NADA QUE MIGRAR
DROP TABLE TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD
DROP TABLE TERCER_IMPACTO.ESPECIALIDAD
DROP TABLE TERCER_IMPACTO.TIPO_ESPECIALIDAD



DROP TABLE TERCER_IMPACTO.PROFESIONAL
DROP TABLE TERCER_IMPACTO.PLAN_MEDICO
DROP TABLE TERCER_IMPACTO.ROL_FUNCIONALIDAD
DROP TABLE TERCER_IMPACTO.ROL_USUARIO
DROP TABLE TERCER_IMPACTO.ROL
DROP TABLE TERCER_IMPACTO.USUARIO
DROP TABLE TERCER_IMPACTO.FUNCIONALIDAD

-------------------


DROP SCHEMA TERCER_IMPACTO

--FIN DROP DEL SCHEMA-----------------------------

--CREACION DEL SCHEMA-----------------------------


USE [GD2C2016]
GO

--CREACION DEL ESQUEMA NOMBRE DEL GRUPO--
CREATE SCHEMA [TERCER_IMPACTO] AUTHORIZATION [GD]
GO

CREATE PROCEDURE TERCER_IMPACTO.CREAR_ROL_USUA_FUNC
AS
BEGIN

	CREATE TABLE TERCER_IMPACTO.FUNCIONALIDAD(
		ID_FUNC NUMERIC(18,0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
		DESCRIPCION VARCHAR(255) NOT NULL UNIQUE
		)
	
	CREATE TABLE TERCER_IMPACTO.ROL(
		ID_ROL NUMERIC(18,0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
		NOMBRE VARCHAR(155) NOT NULL,
		HABILITADO BIT NOT NULL DEFAULT 1--0 FALSE 1 TRUE
		)
	
	CREATE TABLE TERCER_IMPACTO.USUARIO(
		ID_USUARIO NUMERIC(18,0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
		PASS VARCHAR(255) NOT NULL,
		USERNAME VARCHAR(255) UNIQUE NOT NULL,
		INTENTOS_FALLIDOS INT DEFAULT 0 --MAS DE 2 IMPLICA INHABILITADO
		)
		
	CREATE TABLE TERCER_IMPACTO.ROL_FUNCIONALIDAD(
		ROL_ID NUMERIC(18,0) NOT NULL FOREIGN KEY
		REFERENCES TERCER_IMPACTO.ROL(ID_ROL),
		FUNC_ID NUMERIC(18,0) NOT NULL FOREIGN KEY
		REFERENCES TERCER_IMPACTO.FUNCIONALIDAD(ID_FUNC),
		HABILITADO BIT NOT NULL DEFAULT 1,
		CONSTRAINT ROL_FUNC_PK PRIMARY KEY (ROL_ID,FUNC_ID)
		)
		
	CREATE TABLE TERCER_IMPACTO.ROL_USUARIO(
		ROL_ID NUMERIC(18,0) NOT NULL FOREIGN KEY
		REFERENCES TERCER_IMPACTO.ROL(ID_ROL),
		USUARIO_ID NUMERIC(18,0) NOT NULL FOREIGN KEY
		REFERENCES TERCER_IMPACTO.USUARIO(ID_USUARIO),
		CONSTRAINT ROL_US_PK PRIMARY KEY (ROL_ID,USUARIO_ID)
		)


END
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
		APELLIDO VARCHAR(255),
		USUARIO_ID NUMERIC(18,0) FOREIGN KEY
		REFERENCES TERCER_IMPACTO.USUARIO(ID_USUARIO) 
		--DEBERIA SER UNICA
	
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
		ID_PROF_ESP NUMERIC(18,0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
		ID_PROFESIONAL NUMERIC(18,0) NOT NULL 
		FOREIGN KEY REFERENCES
		TERCER_IMPACTO.PROFESIONAL(MATRICULA),
		ID_ESPECIALIDAD NUMERIC(18,0) NOT NULL 
		FOREIGN KEY REFERENCES
		TERCER_IMPACTO.ESPECIALIDAD(ID_ESPECIALIDAD)
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
		
		ID_PROF_ESP NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES
		TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD(ID_PROF_ESP),
		ID_DIA NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES
		TERCER_IMPACTO.DIA(ID_DIA),
		COMIENZO TIME NOT NULL,
		FIN TIME NOT NULL,
		HABILITADO BIT DEFAULT 1,
		CONSTRAINT PROF_DIA_PK PRIMARY KEY (ID_PROF_ESP,
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



CREATE PROCEDURE TERCER_IMPACTO.LLENAR_TABLA_ROL_FUNC
AS
BEGIN

	INSERT INTO TERCER_IMPACTO.ROL (NOMBRE)
	VALUES 
	('AFILIADO'),
	('ADMINISTRATIVO'),
	('PROFESIONAL')
	
	--ADMINISTRATIVO--
	INSERT INTO TERCER_IMPACTO.FUNCIONALIDAD VALUES ('ABM ROL');
	INSERT INTO TERCER_IMPACTO.FUNCIONALIDAD VALUES ('ABM USUARIO');--NO SE HACE
	INSERT INTO TERCER_IMPACTO.FUNCIONALIDAD VALUES ('ABM AFILIADO');
	INSERT INTO TERCER_IMPACTO.FUNCIONALIDAD VALUES ('ABM PROFESIONAL');--NO SE HACE
	INSERT INTO TERCER_IMPACTO.FUNCIONALIDAD VALUES ('ABM ESPECIALIDAD');--NO SE HACE
	INSERT INTO TERCER_IMPACTO.FUNCIONALIDAD VALUES ('ABM PLAN');--NO SE HACE
	INSERT INTO TERCER_IMPACTO.FUNCIONALIDAD VALUES ('REGISTRAR LLEGADA');
	INSERT INTO TERCER_IMPACTO.FUNCIONALIDAD VALUES ('LISTADO ESTADISTICO');
	--AFILIADO Y ADMINISTRATIVO
	INSERT INTO TERCER_IMPACTO.FUNCIONALIDAD VALUES ('PEDIR TURNO');
	INSERT INTO TERCER_IMPACTO.FUNCIONALIDAD VALUES ('COMPRAR BONOS');
	INSERT INTO TERCER_IMPACTO.FUNCIONALIDAD VALUES ('CANCELAR AFILIADO');
	--PROFESIONAL
	INSERT INTO TERCER_IMPACTO.FUNCIONALIDAD VALUES ('REGISTRAR AGENDA');
	INSERT INTO TERCER_IMPACTO.FUNCIONALIDAD VALUES ('REGISTRAR DIAGNOSTICO');
	INSERT INTO TERCER_IMPACTO.FUNCIONALIDAD VALUES ('CANCELAR PROFESIONAL');
	--AFILIADO Y PROFESIONAL
	INSERT INTO TERCER_IMPACTO.FUNCIONALIDAD VALUES ('CANCELAR TURNO'); --SON DISTINTAS
	--OJO, EL ADMINISTRATIVO NO TIENE CANCELAR TURNO
	
	INSERT INTO TERCER_IMPACTO.ROL_FUNCIONALIDAD (ROL_ID,FUNC_ID)
	SELECT R.ID_ROL,F.ID_FUNC 
	FROM TERCER_IMPACTO.ROL R CROSS JOIN
	TERCER_IMPACTO.FUNCIONALIDAD F WHERE R.NOMBRE='ADMINISTRATIVO'
	--AND F.DESCRIPCION <> 'REGISTRAR AGENDA' AND F.DESCRIPCION <> 'REGISTRAR DIAGNOSTICO'
	--AND F.DESCRIPCION <> 'CANCELAR TURNO'
	--ADMINISTRATIVO CON TODAS LAS FUNCIONALIDADES PARA CORREGIR EL TP
	
	INSERT INTO TERCER_IMPACTO.ROL_FUNCIONALIDAD (ROL_ID,FUNC_ID)
	SELECT R.ID_ROL,F.ID_FUNC 
	FROM TERCER_IMPACTO.ROL R CROSS JOIN
	TERCER_IMPACTO.FUNCIONALIDAD F WHERE R.NOMBRE='PROFESIONAL'
	AND (F.DESCRIPCION = 'REGISTRAR AGENDA' OR F.DESCRIPCION = 'REGISTRAR DIAGNOSTICO'
	OR F.DESCRIPCION = 'CANCELAR PROFESIONAL')
	
	INSERT INTO TERCER_IMPACTO.ROL_FUNCIONALIDAD (ROL_ID,FUNC_ID)
	SELECT R.ID_ROL,F.ID_FUNC 
	FROM TERCER_IMPACTO.ROL R CROSS JOIN
	TERCER_IMPACTO.FUNCIONALIDAD F WHERE R.NOMBRE='AFILIADO'
	AND (F.DESCRIPCION = 'PEDIR TURNO' OR F.DESCRIPCION = 'COMPRAR BONOS'
	OR F.DESCRIPCION = 'CANCELAR TURNO' OR F.DESCRIPCION = 'CANCELAR AFILIADO')
	
END
GO



CREATE PROCEDURE TERCER_IMPACTO.MIGRAR_USUARIOS
AS BEGIN
	INSERT INTO TERCER_IMPACTO.USUARIO (USERNAME,PASS) 
	VALUES ('admin','w32e')
	
	INSERT INTO TERCER_IMPACTO.ROL_USUARIO (ROL_ID,USUARIO_ID)
	SELECT R.ID_ROL, U.ID_USUARIO FROM TERCER_IMPACTO.ROL R
	,TERCER_IMPACTO.USUARIO U WHERE U.USERNAME='admin'
	AND R.NOMBRE='ADMINISTRATIVO' 
	
	INSERT INTO TERCER_IMPACTO.USUARIO (USERNAME,PASS)
	SELECT APELLIDO+CONVERT(VARCHAR(50),NRO_DOC),TIPO_DOC+CONVERT(VARCHAR(50),NRO_DOC) 
	FROM TERCER_IMPACTO.PROFESIONAL

	UPDATE TERCER_IMPACTO.PROFESIONAL
	SET USUARIO_ID=(SELECT ID_USUARIO FROM
	TERCER_IMPACTO.USUARIO WHERE 
	USERNAME = APELLIDO+CONVERT(VARCHAR(50),NRO_DOC))

	ALTER TABLE TERCER_IMPACTO.PROFESIONAL
	ADD CONSTRAINT UNICO_USER UNIQUE (USUARIO_ID)
	
	INSERT INTO TERCER_IMPACTO.ROL_USUARIO (ROL_ID,USUARIO_ID)
	SELECT (SELECT ID_ROL FROM TERCER_IMPACTO.ROL WHERE NOMBRE='PROFESIONAL'),
	USUARIO_ID FROM TERCER_IMPACTO.PROFESIONAL

	INSERT INTO TERCER_IMPACTO.USUARIO (USERNAME,PASS)
	SELECT APELLIDO+CONVERT(VARCHAR(50),NRO_DOC),
	TIPO_DOC+CONVERT(VARCHAR(50),NRO_DOC) 
	FROM TERCER_IMPACTO.AFILIADO

	UPDATE TERCER_IMPACTO.AFILIADO
	SET USUARIO_ID=(SELECT ID_USUARIO FROM
	TERCER_IMPACTO.USUARIO WHERE 
	USERNAME = APELLIDO+CONVERT(VARCHAR(50),NRO_DOC))


	
	INSERT INTO TERCER_IMPACTO.ROL_USUARIO (ROL_ID,USUARIO_ID)
	SELECT (SELECT ID_ROL FROM TERCER_IMPACTO.ROL WHERE NOMBRE='AFILIADO'),
	USUARIO_ID FROM TERCER_IMPACTO.AFILIADO

END
GO

CREATE FUNCTION TERCER_IMPACTO.COMPARAR_HASH
(@PASS VARCHAR(255),@ID_USER NUMERIC(18,0)) 
RETURNS BIT
AS
BEGIN
	DECLARE @RESULT BIT;
	IF ((SELECT PASS 
	FROM TERCER_IMPACTO.USUARIO
	WHERE ID_USUARIO =@ID_USER)  = HASHBYTES('SHA2_256',@PASS))
		SET @RESULT=1;
	ELSE
		SET @RESULT=0;
	
	RETURN @RESULT;
END
GO

CREATE PROCEDURE TERCER_IMPACTO.DESHABILITAR_ROL
(@nombre VARCHAR(255))
AS
BEGIN
	DECLARE @ID NUMERIC(18,0)
	SET @ID=(SELECT ID_ROL FROM TERCER_IMPACTO.ROL
	WHERE NOMBRE=@nombre)
	
	UPDATE TERCER_IMPACTO.ROL SET HABILITADO=0
	WHERE ID_ROL=@ID
	
	DELETE FROM TERCER_IMPACTO.ROL_USUARIO WHERE ROL_ID=@ID
END
GO

CREATE PROCEDURE TERCER_IMPACTO.AGREGAR_FUNCIONALIDAD
(@DESCRIPCION VARCHAR(255),@ID_ROL DECIMAL(18,0))
AS
BEGIN
	DECLARE @ID_FUNC NUMERIC(18,0)
	SET @ID_FUNC=(SELECT ID_FUNC FROM
	TERCER_IMPACTO.FUNCIONALIDAD 
	WHERE DESCRIPCION=@DESCRIPCION)
	IF (EXISTS (SELECT ROL_ID FROM TERCER_IMPACTO.ROL_FUNCIONALIDAD
	WHERE FUNC_ID=@ID_FUNC AND ROL_ID=@ID_ROL AND HABILITADO=0))
		BEGIN
			UPDATE TERCER_IMPACTO.ROL_FUNCIONALIDAD
			SET HABILITADO=1
			WHERE FUNC_ID=@ID_FUNC AND ROL_ID=@ID_ROL
		END
	ELSE IF (NOT EXISTS (SELECT ROL_ID 
		FROM TERCER_IMPACTO.ROL_FUNCIONALIDAD
		WHERE FUNC_ID=@ID_FUNC AND ROL_ID=@ID_ROL))
		BEGIN
			INSERT INTO TERCER_IMPACTO.ROL_FUNCIONALIDAD
			(ROL_ID,FUNC_ID) VALUES (@ID_ROL,@ID_FUNC)
		END
END
GO

CREATE PROCEDURE TERCER_IMPACTO.AGREGAR_DIA
(@PROF_ID NUMERIC(18,0),@ESP_ID NUMERIC(18,0),
 @FECHA DATE,@COMIENZO TIME,@FIN TIME)
AS
BEGIN
	DECLARE @ID_PROF_ESP NUMERIC(18,0);
	SET @ID_PROF_ESP=(SELECT ID_PROF_ESP FROM
	TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD
	WHERE ID_PROFESIONAL=@PROF_ID AND
	ID_ESPECIALIDAD=@ESP_ID);
	DECLARE @ID_DIA NUMERIC(18,0);
	SET @ID_DIA=(SELECT ID_DIA FROM
	TERCER_IMPACTO.DIA WHERE FECHA=@FECHA);
	IF (@ID_DIA IS NOT NULL)
		INSERT INTO TERCER_IMPACTO.PROFESIONAL_DIA
		(ID_PROF_ESP,ID_DIA,COMIENZO,FIN)
		VALUES (@ID_PROF_ESP,@ID_DIA,@COMIENZO,@FIN);
	ELSE
		BEGIN
			INSERT INTO TERCER_IMPACTO.DIA (FECHA)
			VALUES (@FECHA);
			SET @ID_DIA=(SELECT ID_DIA FROM
			TERCER_IMPACTO.DIA WHERE FECHA=@FECHA);
			INSERT INTO TERCER_IMPACTO.PROFESIONAL_DIA
			(ID_PROF_ESP,ID_DIA,COMIENZO,FIN)
			VALUES (@ID_PROF_ESP,@ID_DIA,@COMIENZO,@FIN);
		END
END
GO

------PARTE DE MAURO------

CREATE PROCEDURE TERCER_IMPACTO.CREAR_AFILIADOS
AS
BEGIN
	CREATE TABLE TERCER_IMPACTO.AFILIADO(
		ID_AFILIADO NUMERIC(18,0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
		NOMBRE VARCHAR(255),
		APELLIDO VARCHAR(255),
		TIPO_DOC VARCHAR(20),
		NRO_DOC NUMERIC(18,0),
		DIRECCION VARCHAR(255),
		TELEFONO NUMERIC(18,0),
		MAIL VARCHAR(255),
		FECHA_NAC DATETIME,
		SEXO VARCHAR(1),
		ESTADO_CIVIL VARCHAR(50),
		CANT_HIJOS NUMERIC(18,0),
		ID_PLAN_MEDICO NUMERIC(18,0) FOREIGN KEY REFERENCES
        TERCER_IMPACTO.PLAN_MEDICO(ID_PLAN_MEDICO),
		USUARIO_ID NUMERIC(18,0) FOREIGN KEY REFERENCES
		TERCER_IMPACTO.USUARIO(ID_USUARIO),
		HABILITADO BIT DEFAULT 1,
		FECHA_BAJA DATETIME)
		
	CREATE TABLE TERCER_IMPACTO.HISTORIAL_CAMBIO(
		ID_CAMBIO NUMERIC(18,0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
		ID_AFILIADO NUMERIC(18,0) FOREIGN KEY REFERENCES
		TERCER_IMPACTO.AFILIADO(ID_AFILIADO),
		ID_PLAN_ANTERIOR NUMERIC(18,0) FOREIGN KEY REFERENCES
		TERCER_IMPACTO.PLAN_MEDICO(ID_PLAN_MEDICO),
		FECHA_CAMBIO DATETIME,
		MOTIVO VARCHAR(255))
END
GO

--10
CREATE PROCEDURE TERCER_IMPACTO.CREAR_TURNO
AS
BEGIN
	CREATE TABLE TERCER_IMPACTO.TURNO(
		ID_TURNO NUMERIC(18,0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
		ID_MEDICO NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES
        TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD(ID_PROF_ESP),
		ID_AFILIADO NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES
        TERCER_IMPACTO.AFILIADO(ID_AFILIADO),
		FECHA DATETIME NOT NULL,
		HABILITADO BIT DEFAULT 1
		)


END
GO

--11
CREATE PROCEDURE TERCER_IMPACTO.CREAR_CONSULTA
AS
BEGIN
		
	CREATE TABLE TERCER_IMPACTO.CONSULTA(
		ID_CONSULTA NUMERIC(18,0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
		ID_TURNO NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES
		TERCER_IMPACTO.TURNO(ID_TURNO),
		SINTOMAS VARCHAR(255),
		DIAGNOSTICO VARCHAR(255),
		FECHA DATETIME
		)

END
GO


--9
CREATE PROCEDURE TERCER_IMPACTO.CREAR_BONO

AS
BEGIN
	CREATE TABLE TERCER_IMPACTO.COMPRA_BONO(
		ID_COMPRA_BONO NUMERIC(18,0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
		MONTO NUMERIC(18,0), 
		CANTIDAD_BONOS NUMERIC(18,0), 
		ID_AFILIADO NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES
		TERCER_IMPACTO.AFILIADO(ID_AFILIADO),
		FECHA_COMPRA DATETIME NOT NULL,
		)


	CREATE TABLE TERCER_IMPACTO.BONO(
		ID_BONO NUMERIC(18,0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
		ID_PLAN_MEDICO NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES
        TERCER_IMPACTO.PLAN_MEDICO(ID_PLAN_MEDICO),
		ID_AFILIADO NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES
		TERCER_IMPACTO.AFILIADO(ID_AFILIADO),
		ID_CONSULTA NUMERIC(18,0) FOREIGN KEY REFERENCES
        TERCER_IMPACTO.CONSULTA(ID_CONSULTA),
        FECHA DATETIME NOT NULL,
        COMPRA_BONO_ID NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES
        TERCER_IMPACTO.COMPRA_BONO(ID_COMPRA_BONO)
		)
	

	
END
GO

--13
CREATE PROCEDURE TERCER_IMPACTO.CREAR_CANCELACION
AS
BEGIN
		
	CREATE TABLE TERCER_IMPACTO.CANCELACION(
		ID_CANCELACION NUMERIC(18,0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
		ID_TURNO NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES
		TERCER_IMPACTO.TURNO(ID_TURNO),
		TIPO VARCHAR(255),
		EXPLICACION VARCHAR(255)
		
		)

END
GO


CREATE PROCEDURE TERCER_IMPACTO.MIGRAR_AFILIADOS
AS
BEGIN

	INSERT INTO TERCER_IMPACTO.AFILIADO (NOMBRE, APELLIDO,
	TIPO_DOC, NRO_DOC, DIRECCION,TELEFONO, MAIL, FECHA_NAC, ID_PLAN_MEDICO)
	SELECT DISTINCT Paciente_Nombre, Paciente_Apellido, 'DNI',
	Paciente_Dni, Paciente_Direccion, Paciente_Telefono, Paciente_Mail, Paciente_Fecha_Nac,	Plan_Med_Codigo
	FROM gd_esquema.Maestra WHERE Paciente_Dni IS NOT NULL
	
END
GO

CREATE PROCEDURE TERCER_IMPACTO.MIGRAR_TURNO
AS
BEGIN
	SET IDENTITY_INSERT TERCER_IMPACTO.TURNO ON;
	INSERT INTO TERCER_IMPACTO.TURNO (ID_TURNO, ID_MEDICO, ID_AFILIADO ,
	FECHA)
	SELECT DISTINCT Turno_numero, 
	ID_PROF_ESP , ID_AFILIADO, Turno_fecha 
	FROM gd_esquema.Maestra AS MA
	JOIN TERCER_IMPACTO.PROFESIONAL AS PRO
	ON MA.Medico_Dni = PRO.NRO_DOC
	JOIN TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD
	ON PRO.MATRICULA=ID_PROFESIONAL
	AND MA.Especialidad_Codigo=ID_ESPECIALIDAD
	JOIN TERCER_IMPACTO.AFILIADO AS AF
	ON MA.Paciente_Dni = AF.NRO_DOC
	Group by Turno_numero, ID_PROF_ESP, ID_AFILIADO, Turno_fecha
	
	
	SET IDENTITY_INSERT TERCER_IMPACTO.TURNO OFF;
	
END
GO


-- VER---
CREATE PROCEDURE TERCER_IMPACTO.MIGRAR_CONSULTA
AS
BEGIN
	
	INSERT INTO TERCER_IMPACTO.CONSULTA ( SINTOMAS,
	DIAGNOSTICO, ID_TURNO)
	SELECT Consulta_sintomas, Consulta_Enfermedades, ID_TURNO
	FROM TERCER_IMPACTO.TURNO AS TUR
	JOIN gd_esquema.Maestra AS MA
	ON MA.Turno_Numero = TUR.Id_Turno
	WHERE Consulta_Sintomas IS NOT NULL 

END
GO

CREATE PROCEDURE TERCER_IMPACTO.MIGRAR_COMPRA_BONO
AS
BEGIN
	
	INSERT INTO TERCER_IMPACTO.COMPRA_BONO (ID_AFILIADO, FECHA_COMPRA)
	SELECT ID_AFILIADO, Compra_Bono_Fecha 
	FROM gd_esquema.Maestra AS MA
	JOIN TERCER_IMPACTO.AFILIADO AS AF
	ON MA.Paciente_Dni = AF.NRO_DOC
	WHERE Compra_Bono_Fecha IS NOT NULL
	GROUP BY ID_AFILIADO,Compra_Bono_Fecha 
	
END
GO 

CREATE PROCEDURE TERCER_IMPACTO.MIGRAR_BONO
AS
BEGIN
	SET IDENTITY_INSERT TERCER_IMPACTO.BONO ON;
	INSERT INTO TERCER_IMPACTO.BONO (ID_BONO, ID_PLAN_MEDICO, ID_AFILIADO, FECHA,
	COMPRA_BONO_ID)
	SELECT DISTINCT Bono_Consulta_Numero, AF.ID_PLAN_MEDICO, AF.ID_AFILIADO,				Bono_Consulta_Fecha_Impresion ,		
	(SELECT C.ID_COMPRA_BONO FROM 
	TERCER_IMPACTO.COMPRA_BONO AS C 
	WHERE C.ID_AFILIADO=AF.ID_AFILIADO 
	AND C.FECHA_COMPRA=MA.Compra_Bono_Fecha	)
	FROM gd_esquema.Maestra AS MA
	JOIN TERCER_IMPACTO.AFILIADO AS AF
	ON MA.Paciente_Dni = AF.NRO_DOC
	Where MA.Bono_Consulta_Numero IS NOT NULL 
	AND MA.Compra_Bono_Fecha IS NOT NULL
	AND MA.Bono_Consulta_Fecha_Impresion IS NOT NULL
	
	
	UPDATE TERCER_IMPACTO.BONO 
	SET ID_CONSULTA = CON.ID_CONSULTA
	FROM TERCER_IMPACTO.CONSULTA AS CON
	JOIN gd_esquema.Maestra as MA
	on MA.turno_numero=CON.ID_TURNO
	JOIN TERCER_IMPACTO.BONO AS B 
	ON B.ID_BONO=MA.Bono_Consulta_Numero
	where MA.turno_numero IS NOT NULL
	
	SET IDENTITY_INSERT TERCER_IMPACTO.BONO OFF;
	
	UPDATE TERCER_IMPACTO.COMPRA_BONO
	SET CANTIDAD_BONOS=(SELECT COUNT(*) FROM TERCER_IMPACTO.BONO
		WHERE ID_COMPRA_BONO=COMPRA_BONO_ID)
		
	UPDATE TERCER_IMPACTO.COMPRA_BONO
	SET MONTO=(SELECT TOP 1 CANTIDAD_BONOS*PRECIO_BONO_CONSULTA FROM							TERCER_IMPACTO.PLAN_MEDICO P JOIN TERCER_IMPACTO.BONO B
		ON P.ID_PLAN_MEDICO=B.ID_PLAN_MEDICO
		WHERE ID_COMPRA_BONO=B.COMPRA_BONO_ID)	
END
GO


CREATE FUNCTION TERCER_IMPACTO.RETORNAR_PRECIO_BONOS
(@ID_AFIL NUMERIC(18,0),@CANT INT)
RETURNS NUMERIC(18,0)
AS BEGIN
	DECLARE @PRECIO NUMERIC(18,0); 
	SET @PRECIO=(SELECT PRECIO_BONO_CONSULTA FROM
	TERCER_IMPACTO.PLAN_MEDICO P JOIN
	TERCER_IMPACTO.AFILIADO A 
	ON P.ID_PLAN_MEDICO=A.ID_PLAN_MEDICO
	WHERE A.ID_AFILIADO=@ID_AFIL)
	
	RETURN @PRECIO*CONVERT(NUMERIC(18,0),@CANT)
END
GO

CREATE PROCEDURE TERCER_IMPACTO.COMPRAR_BONOS
(@ID_AFIL NUMERIC(18,0),@CANT INT,@FECHA DATETIME)
AS
BEGIN
	DECLARE @I INT;
	SET @I='0';
	DECLARE @ID_COMPRA NUMERIC(18,0);
	
	INSERT INTO TERCER_IMPACTO.COMPRA_BONO
	(MONTO,CANTIDAD_BONOS,ID_AFILIADO,FECHA_COMPRA)
	VALUES ((SELECT TERCER_IMPACTO.RETORNAR_PRECIO_BONOS
	(@ID_AFIL,@CANT)),@CANT,@ID_AFIL,@FECHA)
	
	SET @ID_COMPRA=(SELECT TOP 1 ID_COMPRA_BONO FROM
					TERCER_IMPACTO.COMPRA_BONO ORDER BY ID_COMPRA_BONO DESC)
	
	WHILE @I<@CANT
		BEGIN
			INSERT INTO TERCER_IMPACTO.BONO
			(ID_PLAN_MEDICO,ID_AFILIADO,FECHA,COMPRA_BONO_ID)
			VALUES ((SELECT ID_PLAN_MEDICO FROM
			AFILIADO WHERE ID_AFILIADO=@ID_AFIL),
			@ID_AFIL,@FECHA,@ID_COMPRA)
			SET @I=@I+1;
		END
	
	
END
GO

CREATE PROCEDURE TERCER_IMPACTO.SACAR_TURNO(
@ID_MED NUMERIC(18,0),@ID_AFIL NUMERIC(18,0),
@FECHA DATETIME)
AS BEGIN
	INSERT INTO TERCER_IMPACTO.TURNO
	(ID_MEDICO,ID_AFILIADO,FECHA)
	VALUES (@ID_MED,@ID_AFIL,@FECHA)
END
GO
------------------------------

CREATE PROCEDURE TERCER_IMPACTO.AGREGAR_CANCELACION(
@ID_TUR NUMERIC(18,0),@TIPO VARCHAR(255),
@EXPLICACION VARCHAR(255))
AS BEGIN
	INSERT INTO TERCER_IMPACTO.CANCELACION
	(ID_TURNO,TIPO,EXPLICACION)
	VALUES (@ID_TUR,@TIPO,@EXPLICACION)
	
	/*
	UPDATE TERCER_IMPACTO.BONO SET HABILITADO = 0 
	WHERE ID_TURNO in (select ID_TURNO from TERCER_IMPACTO.CANCELACION )
	*/
END
GO

--------------------------------

CREATE FUNCTION TERCER_IMPACTO.EXISTE_TURNO
(@ID_MED NUMERIC(18,0),@ANIO INT,@MES INT,
@DIA INT,@HORA INT, @MINUTO INT)
RETURNS BIT
AS
BEGIN
	DECLARE @BIT BIT;
	SET @BIT='0';
	IF (EXISTS(SELECT 1 FROM 
	TERCER_IMPACTO.TURNO WHERE
	ID_MEDICO=@ID_MED AND
	YEAR(FECHA)=@ANIO AND
	MONTH(FECHA)=@MES AND
	DAY(FECHA)=@DIA AND
	DATEPART(HOUR,FECHA)=@HORA AND
	DATEPART(MINUTE,FECHA)=@MINUTO 
	))
		SET @BIT='1';
	RETURN @BIT;
END
GO



CREATE PROCEDURE TERCER_IMPACTO.CANCELAR_TURNO_PROF (@FECHA DATETIME, @EXPLICACION VARCHAR(255),@ID_MEDICO NUMERIC(18,0))
AS
BEGIN
     
	INSERT INTO TERCER_IMPACTO.CANCELACION
	(ID_TURNO,TIPO,EXPLICACION)

	SELECT DISTINCT ID_TURNO, 'PROFESIONAL', @EXPLICACION	
	FROM TERCER_IMPACTO.TURNO 
	WHERE
	YEAR(FECHA)=YEAR(@FECHA) AND
	MONTH(FECHA)=MONTH(@FECHA) AND
	DAY(FECHA)= DAY(@FECHA)
	AND ID_MEDICO in (select ID_PROF_ESP
	FROM TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD
	WHERE ID_PROFESIONAL=@ID_MEDICO)
	AND HABILITADO='1'
	
	UPDATE TERCER_IMPACTO.TURNO SET HABILITADO='0'
	WHERE
	YEAR(FECHA)=YEAR(@FECHA) AND
	MONTH(FECHA)=MONTH(@FECHA) AND
	DAY(FECHA)= DAY(@FECHA)
	AND ID_MEDICO in (select ID_PROF_ESP
	FROM TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD
	WHERE ID_PROFESIONAL=@ID_MEDICO)
	AND HABILITADO='1'
	
	UPDATE TERCER_IMPACTO.PROFESIONAL_DIA
	SET HABILITADO='0'
	FROM TERCER_IMPACTO.PROFESIONAL_DIA PD
	JOIN TERCER_IMPACTO.DIA D
	ON PD.ID_DIA=D.ID_DIA 
	WHERE
	YEAR(D.FECHA)=YEAR(@FECHA) AND
	MONTH(D.FECHA)=MONTH(@FECHA) AND
	DAY(D.FECHA)= DAY(@FECHA)
	AND PD.ID_PROF_ESP in (select ID_PROF_ESP
	FROM TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD
	WHERE ID_PROFESIONAL=@ID_MEDICO)
	AND HABILITADO='1'
	/*
	  UPDATE TERCER_IMPACTO.BONO SET HABILITADO = 0 
	WHERE ID_TURNO in (select ID_TURNO from TERCER_IMPACTO.CANCELACION )
	*/
END
GO




CREATE PROCEDURE TERCER_IMPACTO.AGREGAR_ID_CONSULTA
(@TURNO NUMERIC(18,0), @FECHA DATETIME)
AS
BEGIN
	DECLARE @ID_C NUMERIC(18,0)
	SET @ID_C=(SELECT ID_CONSULTA FROM TERCER_IMPACTO.CONSULTA
	WHERE ID_TURNO=@TURNO AND FECHA = @FECHA)
	
	UPDATE TOP (1) TERCER_IMPACTO.BONO SET ID_CONSULTA = @ID_C 
	WHERE ID_CONSULTA IS NULL 
END
GO

CREATE PROCEDURE TERCER_IMPACTO.AGREGAR_SINTOMA
(@SINTOMA VARCHAR(255), @ID_CON NUMERIC (18,0))
AS
BEGIN
	
	UPDATE TOP (1) TERCER_IMPACTO.CONSULTA SET SINTOMAS = @SINTOMA 
	WHERE ID_CONSULTA = @ID_CON
END
GO

CREATE PROCEDURE TERCER_IMPACTO.AGREGAR_ENFERMEDAD
(@ENFERMEDAD VARCHAR(255), @ID_CON NUMERIC (18,0))
AS
BEGIN
	
	UPDATE TOP (1) TERCER_IMPACTO.CONSULTA SET DIAGNOSTICO = @ENFERMEDAD 
	WHERE ID_CONSULTA = @ID_CON
END
GO

CREATE FUNCTION TERCER_IMPACTO.EXISTE_CONSULTA
(@TURNO NUMERIC(18,0),@HORA DATETIME)
RETURNS BIT
AS
BEGIN
	DECLARE @BIT BIT;
	SET @BIT='0';
	
	IF (EXISTS(SELECT 1 FROM TERCER_IMPACTO.CONSULTA WHERE ID_TURNO= @TURNO AND FECHA = @HORA))
	
		SET @BIT='1';
	RETURN @BIT;
END
GO

CREATE PROCEDURE TERCER_IMPACTO.MIGRAR_AGENDA
AS BEGIN

	INSERT INTO TERCER_IMPACTO.DIA (FECHA)
	SELECT DISTINCT CONVERT(DATE,TURNO_FECHA) FROM
	gd_esquema.Maestra 
	WHERE Turno_Fecha IS NOT NULL
	GROUP BY CONVERT(DATE,TURNO_FECHA)

	INSERT INTO TERCER_IMPACTO.PROFESIONAL_DIA
	(ID_DIA,COMIENZO,FIN,ID_PROF_ESP)
	SELECT (SELECT ID_DIA FROM
	TERCER_IMPACTO.DIA WHERE FECHA=CONVERT(DATE,TURNO_FECHA)),
	MIN(CONVERT(TIME,TURNO_FECHA)),
	DATEADD(MINUTE,30,MAX(CONVERT(TIME,TURNO_FECHA))),
	ID_PROF_ESP
	FROM gd_esquema.Maestra
	JOIN TERCER_IMPACTO.PROFESIONAL ON
	Medico_Dni=NRO_DOC
	JOIN TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD
	ON ID_PROFESIONAL=MATRICULA
	AND ID_ESPECIALIDAD=Especialidad_Codigo 
	WHERE Turno_Fecha IS NOT NULL
	GROUP BY CONVERT(DATE,TURNO_FECHA),
	ID_PROF_ESP
END
GO

create function TERCER_IMPACTO.NRO_UTILIZADO
(@nro_afiliado_ppal numeric(18,0))
returns BIT
as
begin
	declare @bit bit;
	set @bit=0;

	if @nro_afiliado_ppal in
	(select convert(numeric(18,0),round(ID_AFILIADO/100,0,1))
	from TERCER_IMPACTO.AFILIADO)
		set @bit=1;
	
	return @bit;

end
go
--1)Top 5 de las especialidades que más se registraron cancelaciones, tanto de afiliados como de profesionales.
CREATE FUNCTION TERCER_IMPACTO.ESPECIALIDADES_MAS_CANCELADAS(
@ANIO INT,
@MES_INICIAL INT,
@MES_FINAL INT,
)
RETURNS TABLE
AS
	RETURN(
	SELECT TOP 5 E.ID_ESPECIALIDAD,E.DESCRIPCION, COUNT(C.ID_CANCELACION) NRO_CANCELACIONES 
	FROM TERCER_IMPACTO.ESPECIALIDAD E,TERCER_IMPACTO.CANCELACION C, TERCER_IMPACTO.TURNO T,TERCER_IMPACTO.ESPECIALIDAD_PROFESIONAL EP
	WHERE C.ID_TURNO=T.ID_TURNO
	AND T.ID_MEDICO = EP.ID_PROF_ESP
	AND EP.ID_ESPECIALIDAD = E.ID_ESPECIALIDAD
	AND YEAR(T.FECHA) = @ANIO
    AND MONTH(T.FECHA) BETWEEN @MES_INICIAL AND @MES_FINAL
	GROUP BY E.ID_ESPECIALIDAD,E.DESCRIPCION
	ORDER BY COUNT(C.ID_CANCELACION) DESC
	)
GO
--2) Top 5 de los profesionales más consultados por Plan, detallando también bajo que Especialidad.
CREATE FUNCTION TERCER_IMPACTO.TOP5_PROF_PLAN
(@ANIO INT,@MES_INICIAL INT,@MES_FINAL INT,@PLAN_COD INT)
RETURNS TABLE
AS
	RETURN(
		SELECT TOP 5 P.MATRICULA,P.NOMBRE, P.APELLIDO, E.DESCRIPCION, COUNT(T.ID_TURNO) NRO_CONSULTAS 
		FROM TERCER_IMPACTO.TURNO T,
					  
					  TERCER_IMPACTO.AFILIADOS AFI, 
					  TERCER_IMPACTO.PROFESIONAL P,
					  TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD EP					 
					  TERCER_IMPACTO.ESPECIALIDAD E
			WHERE AFI.ID_AFILIADO = T.ID_AFILIADO
			AND AFI.ID_PLAN_COD = @PLAN_COD			
			AND T.ID_MEDICO=P.MATRICULA
			AND P.MATRICULA = EP.ID_PROFESIONAL
			AND EP.ID_ESPECIALIDAD=E.ID_ESPECIALIDAD
			AND YEAR(T.FECHA)=@ANIO
			AND MONTH(T.FECHA) BETWEEN @MES_INICIAL AND @MES_FINAL
		GROUP BY P.MATRICULA,P.NOMBRE, P.APELLIDO, E.DESCRIPCION
		ORDER BY COUNT(T.ID_TURNO) DESC
		)
GO
--3) Top 5 de los profesionales con menos horas trabajadas filtrando por Plan y Especialidad.
CREATE FUNCTION TERCER_IMPACTO.PROFESIONALES_CON_MENOS_HORAS(
@PLAN INT,
@ESPEC INT,
@ANIO INT,
@MES_INICIAL INT,
@MES_FINAL INT
)
RETURNS TABLE
AS
	RETURN(
		SELECT
		TOP 5 P.ID_PROFESIONAL CODIGO,AFI.NOMBRE NOMBRE,AFI.APELLIDO APELLIDO,P.MATRICULA MATRICULA,E.DESCRIPCION ESPECIALIDAD, count(*)/2 HORAS_TOTAL_TRABAJADAS
				 from TERCER_IMPACTO.TURNO T,
					  TERCER_IMPACTO.PROFESIONAL_DIA PD,
					  TERCER_IMPACTO.AFILIADO AFI, 
					  TERCER_IMPACTO.PROFESIONAL P,
					  TERCER_IMPACTO.USUARIO U,
					  TERCER_IMPACTO.ESPECIALIDAD_PROFESIONAL EP,
					  TERCER_IMPACTO.ESPECIALIDAD E
			WHERE AFI.ID_AFILIADO=T.ID_AFILIADO
			AND T.ID_PROFESIONAL=PD.ID_PROFESIONAL
			AND P.ID_PROFESIONAL=T.ID_PROFESIONAL
			AND P.USUARIO_ID=U.ID_USUARIO
			AND U.ID_USUARIO=AFI.USUARIO_ID
			AND P.ID_PROFESIONAL=EP.ID_PROFESIONAL
			AND EP.ID_ESPECIALIDAD= E.ID_ESPECIALIDAD
			AND E.ID_ESPECIALIDAD = @ESPEC
			AND AFI.ID_PLAN_MEDICO=@PLAN
			AND YEAR(T.FECHA)=@AÑO
			AND MONTH(T.FECHA) BETWEEN @MES_INICIAL AND @MES_FINAL
			GROUP BY AFI.NOMBRE,AFI.APELLIDO,P.ID_PROFESIONAL ,P.MATRICULA,E.DESCRIPCION
			ORDER BY COUNT(*) ASC
			)
GO


--4)
CREATE FUNCTION TERCER_IMPACTO.AFILIADOS_CON_MAS_BONOS(
@ANIO INT,
@MES_INICIAL INT,
@MES_FINAL INT
)
RETURNS TABLE
AS
	RETURN(
		SELECT 
		TOP 5 A.ID_AFILIADO,A.NOMBRE ,A.APELLIDO AFILIADO,
		(CASE  
			WHEN A.CANT_HIJOS IS NULL or A.CANT_HIJOS = 0 THEN 'No'
			ELSE 'Si'
		 END) FAMILIARES_A_CARGO
		, count(A.ID_AFILIADO) CANTIDAD_BONOS
		FROM 
		TERCER_IMPACTO.COMPRA_BONO CB,
		TERCER_IMPACTO.AFILIADO A,
		TERCER_IMPACTO.USUARIO U
		WHERE 
			CB.ID_AFILIADO=A.ID_AFILIADO
			AND A.USUARIO_ID=U.ID_USUARIO
			AND YEAR(CB.FECHA_COMPRA)=@ANIO
		    AND MONTH(CB.FECHA_COMPRA) BETWEEN @MES_INICIAL AND @MES_FINAL
		GROUP BY A.NOMBRE,A.APELLIDO,A.CANT_HIJOS,A.ID_AFILIADO
		ORDER BY COUNT(A.ID_AFILIADO) DESC
		)
GO

--5)
CREATE FUNCTION TERCER_IMPACTO.TOP5_ESP_BONOS
(@ANIO INT, @MES_INICIAL INT, @MES_FINAL INT)
RETURNS TABLE
AS
	RETURN(
		SELECT TOP 5 DESCRIPCION 
		FROM TERCER_IMPACTO.PROFESIONAL P
		JOIN TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD PE ON PE.ID_PROFESIONAL = P.MATRICULA
		JOIN TERCER_IMPACTO.ESPECIALIDAD E ON E.ID_ESPECIALIDAD = PE.ID_ESPECIALIDAD
		JOIN TERCER_IMPACTO.TURNO T ON T.FECHA=C.FECHA
		JOIN TERCER_IMPACTO.BONO B ON B.ID_CONSULTA=C.CONSULTA
		WHERE
		B.ID_CONSULTA IS NOT NULL AND
		AND YEAR(T.FECHA) = @ANIO AND 
		MONTH(T.FECHA) BETWEEN @MES_INICIAL AND @MES_FINAL
		GROUP BY DESCRIPCION
		ORDER BY COUNT(E.ID_ESPECIALIDAD) DESC
		)
GO




EXEC TERCER_IMPACTO.CREAR_ROL_USUA_FUNC
EXEC TERCER_IMPACTO.CREAR_PROFESIONALES;
EXEC TERCER_IMPACTO.CREAR_TIPO_Y_ESPECIALIDAD;
EXEC TERCER_IMPACTO.CREAR_DIA_PROFESIONAL_DIA;
EXEC TERCER_IMPACTO.CREAR_PLAN_MEDICO;

-------------------
EXEC TERCER_IMPACTO.CREAR_AFILIADOS
EXEC TERCER_IMPACTO.CREAR_TURNO
EXEC TERCER_IMPACTO.CREAR_CONSULTA
EXEC TERCER_IMPACTO.CREAR_BONO
EXEC TERCER_IMPACTO.CREAR_CANCELACION
------------------

EXEC TERCER_IMPACTO.MIGRAR_PLAN_MED;
EXEC TERCER_IMPACTO.MIGRAR_PROFESIONALES;
EXEC TERCER_IMPACTO.MIGRAR_ESPECIALIDADES_TIPOS;
EXEC TERCER_IMPACTO.MIGRAR_PROFESIONAL_ESPECIALIDAD;
EXEC TERCER_IMPACTO.LLENAR_TABLA_ROL_FUNC

-----------
EXEC TERCER_IMPACTO.MIGRAR_AFILIADOS
EXEC TERCER_IMPACTO.MIGRAR_TURNO
EXEC TERCER_IMPACTO.MIGRAR_CONSULTA
EXEC TERCER_IMPACTO.MIGRAR_COMPRA_BONO
EXEC TERCER_IMPACTO.MIGRAR_BONO
EXEC TERCER_IMPACTO.MIGRAR_AGENDA

--------------


GO

--TRIGGER PARA EL PASSWORD DE USUARIO
CREATE TRIGGER TERCER_IMPACTO.TRIGGER_PASS on TERCER_IMPACTO.USUARIO
INSTEAD OF INSERT
AS
BEGIN
  INSERT INTO TERCER_IMPACTO.USUARIO (USERNAME,PASS)
	   SELECT USERNAME,HASHBYTES ( 'SHA2_256',PASS )
	   FROM inserted
END
GO

EXEC TERCER_IMPACTO.MIGRAR_USUARIOS




