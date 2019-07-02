USE [BIOS_TESTING]
GO

/****** Object:  StoredProcedure [dbo].[sp_bios_candidates_getById]    Script Date: 7/2/2019 2:20:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Freddy Iniguez
-- Create date: 2019070202
-- Description:	Thos stored procedure retrieves the information
-- for a given candidate.
-- =============================================
CREATE PROCEDURE [dbo].[sp_bios_candidates_getById]
	@IdCandidate INT
AS
BEGIN
	SELECT IdCandidate,
		FirstName,
		SecondName,
		LastName,
		SecondLastName,
		BirthDate,
		Email,
		Phone,
		Cellphone,
		FOJ,
		Location,
		Site,
		Market
	FROM Tb_BIOS_Candidates
	WHERE IdCandidate = @IdCandidate
		AND Active = 1
END
GO

