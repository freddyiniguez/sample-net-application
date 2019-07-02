USE [BIOS_TESTING]
GO

/****** Object:  StoredProcedure [dbo].[sp_bios_candidates_get]    Script Date: 7/2/2019 9:47:25 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Freddy Iniguez
-- Create date: 2019070101
-- Description:	This stored procedure retrieves all registered active candidates.
-- =============================================
CREATE PROCEDURE [dbo].[sp_bios_candidates_get]
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
	WHERE Active = 1
END
GO

