USE [KellyProject]
GO

/****** Object:  Table [dbo].[YogaPractice]    Script Date: 8/13/16 4:24:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[YogaPractice](
	[YogiId] [int] NULL,
	[PracticeDate] [date] NULL,
	[InstructorName] [nvarchar](128) NULL,
	[ClassType] [nvarchar](max) NULL,
	[Rating] [int] NULL,
	[PracticeId] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK__YogaPrac__352A17F2FC9EB65C] PRIMARY KEY CLUSTERED 
(
	[PracticeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

