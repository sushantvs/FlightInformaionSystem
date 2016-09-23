USE [master]
GO

/****** Object:  Table [dbo].[tblFlightInformation]    Script Date: 09/23/2016 03:54:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblFlightInformation](
	[FlightNumber] [varchar](50) NOT NULL,
	[Destination] [varchar](max) NOT NULL,
	[FlightTime] [datetime] NOT NULL,
	[Airline] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[FlightNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


