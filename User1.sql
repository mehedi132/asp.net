CREATE TABLE [dbo].[User1] (
    [Id]      INT          NOT NULL,
    [Name]    VARCHAR (50) NULL,
    [Address] VARCHAR (50) NULL,
    [Email]   VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

select * from User1