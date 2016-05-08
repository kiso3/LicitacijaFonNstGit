CREATE TABLE [dbo].[Opstina] (
    [OpstinaId]    INT           IDENTITY (1, 1) NOT NULL,
    [NazivOpstine] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Opstina] PRIMARY KEY CLUSTERED ([OpstinaId] ASC)
);

