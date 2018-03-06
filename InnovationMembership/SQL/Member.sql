CREATE TABLE [dbo].[Member]
(
	[MemberId] INT identity (1000, 1) PRIMARY KEY,
	[ForeName] Varchar(100),
	[SurName] Varchar(100),
	[Email] Varchar(150),
	[SMS] Varchar(50), 
    [Address1] VARCHAR(250) NULL, 
    [Address2] VARCHAR(250) NULL, 
    [Address3] VARCHAR(250) NULL, 
    [Age] VARCHAR(50) NULL, 
    [Type] INT NOT NULL DEFAULT 0,
)
