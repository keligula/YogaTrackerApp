USE [KellyProject]
GO

/****** Object:  StoredProcedure [dbo].[YogaPractice_GetByYogiId]    Script Date: 8/13/16 4:23:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[YogaPractice_GetByYogiId]

@YogiId int

AS
BEGIN

SELECT

	[PracticeId]
	, [YogiId]
	, [PracticeDate]
	, [InstructorName]
	, [ClassType]
	, [Rating]

FROM [dbo].[YogaPractice]
WHERE @YogiId = YogiId

ORDER BY YogiId DESC

END
GO

