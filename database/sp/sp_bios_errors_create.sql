USE [BIOS_TESTING]
GO

/****** Object:  StoredProcedure [dbo].[sp_bios_errors_create]    Script Date: 7/2/2019 9:47:38 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Freddy Iñiguez
-- Create date: 2019070202
-- Description:	This stored procedure registers all information
-- when an error is catched.
-- =============================================
CREATE PROCEDURE [dbo].[sp_bios_errors_create]
	@ErrorMessageUser VARCHAR(MAX)
AS
BEGIN
	INSERT INTO Tb_BIOS_Errors(
		ErrorNumber,
		ErrorSeverity,
		ErrorState,
		ErrorProcedure,
		ErrorLine,
		ErrorMessage,
		ErrorMessageUser,
		FechaRegistro)
	VALUES(
		ERROR_NUMBER(),  
		ERROR_SEVERITY(),  
		ERROR_STATE(),  
		ERROR_PROCEDURE(),  
		ERROR_LINE(), 
		ERROR_MESSAGE(),
		@ErrorMessageUser,
		GETDATE());
END
GO

