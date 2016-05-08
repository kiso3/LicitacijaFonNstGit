CREATE TABLE [dbo].[VrstaZemljista] (
    [VrstaZemljistaId] INT          NOT NULL CONSTRAINT [PK_VrstaZemljista] PRIMARY KEY CLUSTERED,
    [Naziv]            VARCHAR (50) NOT NULL
);
