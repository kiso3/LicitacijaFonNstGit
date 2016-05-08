CREATE TABLE [dbo].[Mesto] (
    [MestoId] INT           IDENTITY (1, 1) NOT NULL,
    [Naziv]   VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Mesto] PRIMARY KEY CLUSTERED ([MestoId] ASC)
);


