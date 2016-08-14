USE [KellyProject]
GO

/****** Object:  StoredProcedure [dbo].[YogaPractice_DeleteByPracticeId]    Script Date: 8/13/16 4:22:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[YogaPractice_DeleteByPracticeId]

@PracticeId int

AS
BEGIN

DELETE FROM [dbo].[YogaPractice]

WHERE PracticeId = @PracticeId

END
GO

