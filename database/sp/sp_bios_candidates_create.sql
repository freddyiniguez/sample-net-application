USE [BIOS_TESTING]
GO

/****** Object:  StoredProcedure [dbo].[sp_bios_candidates_create]    Script Date: 7/2/2019 9:47:15 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Freddy Iniguez
-- Create date: 2019070202
-- Description:	This stored procedure receives all information
-- to create a new Candidate.
-- =============================================
CREATE PROCEDURE [dbo].[sp_bios_candidates_create]
	@FirstName VARCHAR(100),
	@SecondName VARCHAR(100) = NULL,
	@LastName VARCHAR(100),
	@SecondLastName VARCHAR(100) = NULL,
	@ShortName VARCHAR(100),
	@BirthDate DATE,
	@Email VARCHAR(100),
	@Phone VARCHAR(10),
	@Cellphone VARCHAR(10),
	@FOJ INT = NULL,
	@Location INT = NULL,
	@Site INT = NULL,
	@Market INT = NULL,
	@Hashtag VARCHAR(MAX) = NULL
AS
BEGIN
	BEGIN TRY
		-- 1) Variables to create a ResponseObject
		DECLARE @Message VARCHAR(MAX) = NULL,
				@SuccessCode INT = NULL,
				@ErrorCode INT = NULL;

		-- 2) Validation section
		IF (@FirstName IS NULL)
		BEGIN
			SET @Message = 'Candidate first name is required.';
			THROW 50001, @Message, 1;
		END

		IF (@LastName IS NULL)
		BEGIN
			SET @Message = 'Candidate last name is required';
			THROW 50002, @Message, 1;
		END

		IF (@ShortName IS NULL)
		BEGIN
			SET @Message = 'Candidate short name is required.';
			THROW 50002, @Message, 1;
		END

		-- 3) Operation section
		INSERT INTO Tb_BIOS_Candidates (FirstName,
			SecondName,
			LastName,
			SecondLastName,
			ShortName,
			BirthDate,
			Email,
			Phone,
			Cellphone,
			FOJ,
			Location,
			Site,
			Market,
			Hashtag,
			Active)
		VALUES (
			@FirstName,
			@SecondName,
			@LastName,
			@SecondLastName,
			@ShortName,
			@BirthDate,
			@Email,
			@Phone,
			@Cellphone,
			@FOJ,
			@Location,
			@Site,
			@Market,
			@Hashtag,
			1) -- Active

		-- 4) Return positive response
		SET @SuccessCode = SCOPE_IDENTITY();

		SELECT @SuccessCode								AS ID,
				'Candidate was registered successfully.' AS Message,
				0										AS Code;
	END TRY
	BEGIN CATCH
		-- 5) Catching error
		IF @@ERROR <> 0
		BEGIN
			SET @ErrorCode = @@ERROR;
		END
		
		-- 6) Return negative response
		EXECUTE sp_bios_errors_create 'An error occurred. Please contact your system administrator.';

		SELECT (ERROR_NUMBER() * -1)					AS ID,
			@Message									AS Message,
			@ErrorCode									AS Code;
	END CATCH
END
GO

