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
--@ClassType nvarchar(MAX),
--@Rating int

AS
BEGIN

UPDATE [dbo].[YogaPractice]

SET		[YogiId] = @YogiId,
		[PracticeDate] = @PracticeDate,
		[InstructorName] = @InstructorName
		--[ClassType] = @ClassType,
		--[Rating] = @Rating

WHERE	[PracticeId] = @PracticeId

--DECLARE	@YogiId int = '1',
--		@PracticeDate date = '2016-07-20',
--		@InstructorName nvarchar(128) = 'Christelle',
--		@PracticeId int = '15'

--EXECUTE [dbo].[YogaPractice_UpdatePracticeById] @YogiId, @PracticeDate, @InstructorName, @PracticeId;


END	
GO

