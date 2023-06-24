CREATE TABLE [dbo].[salestb] (
    [billid] INT           IDENTITY (1, 1) NOT NULL,
    [paym]   NVARCHAR (50) NOT NULL,
    [netamt] INT           NOT NULL,
    [bdate]  DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([billid] ASC)
);

