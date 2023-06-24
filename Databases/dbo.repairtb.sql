CREATE TABLE [dbo].[repairtb] (
    [ordid] INT           IDENTITY (1, 1) NOT NULL,
    [cname] CHAR (10)     NOT NULL,
    [cnum]  NVARCHAR (50) NOT NULL,
    [itnum] NCHAR (10)    NOT NULL,
    [itdes] NVARCHAR (50) NOT NULL,
    [itcat] NCHAR (10)    NOT NULL,
    PRIMARY KEY CLUSTERED ([ordid] ASC)
);

