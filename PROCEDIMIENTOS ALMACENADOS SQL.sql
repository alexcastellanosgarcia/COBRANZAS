USE PROYECTO_CSHARP

SELECT * FROM CLIENTES
GO



--PROCEDIMIENTO PARA INSERTAR CLIENTES

ALTER PROCEDURE SP_INSERTAR_CLIENTES
(
	@prmIdentidad varchar(50),
	@prmNombre varchar(350),
	@prmDireccion varchar(500),
	@prmTelefono varchar(500),
	@prmCorreo varchar(100),
	@prmMunicipio varchar(100),
	@prmFechaNacimiento date,
	@prmUsuario varchar(50),
	@Result int = NULL output
)
AS
BEGIN
	
	BEGIN TRY
	BEGIN TRANSACTION

	DECLARE @newID int = 0
	SELECT @newID = ISNULL(MAX(ID),0)+1 FROM CLIENTES
	
	INSERT INTO CLIENTES (ID, IDENTIDAD, NOMBRE, DIRECCION, TELEFONO, CORREO, MUNICIPIO, FECHA_NACIMIENTO, FECHA_CREACION, USUARIO_CREACION)
	VALUES (@newID, @prmIdentidad, @prmNombre, @prmDireccion, @prmTelefono, @prmCorreo, @prmMunicipio, @prmFechaNacimiento, GETDATE(), @prmUsuario)
	COMMIT
	set @Result = 1
	
	END TRY
	BEGIN CATCH
		ROLLBACK
		set @Result = 0
	END CATCH

	RETURN @Result
	END
GO


	--PROCEDIMIENTO PARA ACTUALIZAR CLIENTES

CREATE PROCEDURE SP_ACTUALIZAR_CLIENTES
(
	@prmId int,
	@prmIdentidad varchar(50),
	@prmNombre varchar(350),
	@prmDireccion varchar(500),
	@prmTelefono varchar(500),
	@prmCorreo varchar(100),
	@prmMunicipio varchar(100),
	@prmFechaNacimiento date,
	@prmUsuario varchar(50),
	@Result int = NULL output
)
AS
BEGIN
	
	UPDATE  CLIENTES SET IDENTIDAD = @prmIdentidad, NOMBRE = @prmNombre, DIRECCION = @prmDireccion, TELEFONO = @prmTelefono, CORREO = @prmCorreo, 
						 MUNICIPIO = @prmMunicipio, FECHA_NACIMIENTO = @prmFechaNacimiento, FECHA_MODIFICACION = GETDATE(), 
						 USUARIO_MODIFICACION = @prmUsuario

	WHERE ID = @prmId

	SET @Result = 1

	RETURN @Result
	END
GO



--PROCEDIMIENTO PARA ANULAR CLIENTES

CREATE PROCEDURE SP_ANULAR_CLIENTES
(
	@prmId int,
	@Result int = NULL output
)
AS
BEGIN
	
	UPDATE  CLIENTES SET ACTIVO = 0
		WHERE ID = @prmId

	SET @Result = 1

	RETURN @Result
	END
GO



--PROCEDIMIENTO PARA MOSTRAR EN LISTA LOS CLIENTES

CREATE PROCEDURE SP_LISTAR_CLIENTES

AS
BEGIN
	 SELECT * FROM CLIENTES
END
GO










	--PARA ELIMINAR COLUMNAS DE UNA TABLA
	
	ALTER TABLE CLIENTES ADD ACTIVO BIT
	DROP COLUMN 