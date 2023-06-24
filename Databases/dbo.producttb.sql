CREATE TABLE [dbo].[producttb] (
    [pid]   INT           IDENTITY (1, 1) NOT NULL,
    [pname] NVARCHAR (50) NOT NULL,
    [pcat]  NVARCHAR (50) NOT NULL,
    [quan]  NVARCHAR (50) NOT NULL,
    [price] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([pid] ASC)
);

