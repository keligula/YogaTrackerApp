USE [KellyProject]
GO

/****** Object:  StoredProcedure [dbo].[YogaPractice_Insert]    Script Date: 8/13/16 4:23:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[YogaPractice_Insert]

	@YogiId int,
	@PracticeDate date,
	@InstructorName nvarchar(128),
	@PracticeId int OUTPUT

AS

BEGIN

	INSERT INTO [dbo].[YogaPractice]
	(
	[YogiId],
	[PracticeDate],
	[InstructorName]
	)

	VALUES
		(@YogiId, @PracticeDate, @InstructorName)

	SET	@PracticeId = SCOPE_IDENTITY()

END
GO

