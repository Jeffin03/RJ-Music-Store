CREATE TABLE [dbo].[custtb] (
    [custid] INT           IDENTITY (1, 1) NOT NULL,
    [cname]  NVARCHAR (50) NOT NULL,
    [cnum]   VARCHAR (14)  NOT NULL,
    [cadr]   NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([custid] ASC)
);

