CREATE TABLE [dbo].[Payment] (
    [PaymentId] INT           IDENTITY (1000, 1) NOT NULL,
    [MemberId] INT NOT NULL,
	[PaymentAmount] NUMERIC(10,2) NOT NULL,
    [PaymentType]  VARCHAR (100) NULL,
    [PayNarrative]    VARCHAR (350) NULL,
    [RequestedDate]      DATETIME  NULL,
    [PaymentSent] BIT NULL,
    [PaymentSentDate] DATETIME NULL,
	[PaymentReceived] BIT NULL,
	[PaymentReceivedDate] DATETIME NULL,
    [Active]   BIT           DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([PaymentId] ASC)
);