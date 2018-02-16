USE [WPFTEST]
GO

/****** Object: Table [dbo].[Person] Script Date: 2/16/2018 12:14:33 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Person] (
    [Id]           INT           NOT NULL,
    [FirstName]    NVARCHAR (50) NOT NULL,
    [LastName]     NVARCHAR (50) NOT NULL,
    [Dob]          DATETIME      NOT NULL,
    [Dod]          DATETIME      NULL,
    [BirthCity]    NVARCHAR (50) NULL,
    [BirthCountry] NVARCHAR (50) NULL
);


