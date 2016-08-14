USE [KellyProject]
GO

/****** Object:  StoredProcedure [dbo].[YogaPractice_ListAll]    Script Date: 8/13/16 4:23:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[YogaPractice_ListAll]

AS
BEGIN

SELECT

	[PracticeId]
	, [YogiId]
	, [PracticeDate]
	, [InstructorName]

FROM [dbo].[YogaPractice]

ORDER BY PracticeId ASC;

END
GO

