CREATE TABLE [dbo].[Table] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (MAX) NULL,
    [LastName]    NVARCHAR (MAX) NULL,
    [Email]       NVARCHAR (MAX) NULL,
    [Pesel]       NVARCHAR (11)  NULL,
    [PhoneNumber] NVARCHAR (9)   NULL,
    [Adress]      NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

