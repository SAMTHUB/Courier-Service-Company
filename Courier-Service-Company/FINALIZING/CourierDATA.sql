USE [AOAPROJECT]
GO
/****** Object:  Table [dbo].[customerdata]    Script Date: 12/7/2019 6:41:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customerdata](
	[DelieveryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[PhoneNo] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Date] [nchar](50) NULL,
	[DeliveryFee] [int] NULL,
	[Time] [nchar](50) NULL,
	[Claim] [nchar](50) NULL,
	[Description] [nchar](50) NULL,
	[Item] [nchar](10) NULL,
 CONSTRAINT [PK_customerdata] PRIMARY KEY CLUSTERED 
(
	[DelieveryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 12/7/2019 6:41:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[Name] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[customerdata] ON 

INSERT [dbo].[customerdata] ([DelieveryID], [Name], [PhoneNo], [Address], [Email], [Date], [DeliveryFee], [Time], [Claim], [Description], [Item]) VALUES (5, N'Usama Tariq', N'02313123', N'lahore', N'lahore', N'2019-12-07                                        ', 2100, N'21:00:00.0000000                                  ', N'yes                                               ', N'docs                                              ', N'small     ')
SET IDENTITY_INSERT [dbo].[customerdata] OFF
INSERT [dbo].[login] ([Name], [UserName], [Password]) VALUES (N'Ali', N'mooroo', N'123')
INSERT [dbo].[login] ([Name], [UserName], [Password]) VALUES (N'Usama', N'utari', N'1111')
