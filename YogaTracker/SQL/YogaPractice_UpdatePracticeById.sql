USE [KellyProject]
GO

/****** Object:  StoredProcedure [dbo].[YogaPractice_UpdatePracticeById]    Script Date: 8/13/16 4:24:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[YogaPractice_UpdatePracticeById]

@YogiId int,
@PracticeDate date,
@InstructorName nvarchar(128),
@PracticeId int

AS
BEGIN

UPDATE [dbo].[YogaPractice]

SET		[YogiId] = @YogiId,
		[PracticeDate] = @PracticeDate,
		[InstructorName] = @InstructorName

WHERE	[PracticeId] = @PracticeId


END	
GO

