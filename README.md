# CleanArchitecture
Clean Architecture implementation example in ASP .NET Core Web API

# Dapper for ORM and SQL Server

Script to create table
---------------------------------------------------------------------------------
CREATE TABLE [dbo].[User](

	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
----------------------------------------------------------------------------------------


# JWT for Authentification
Example Admin USER
        User: admin
        Pass: admin
        
Example Basic USER
        User: user
        Pass: user
