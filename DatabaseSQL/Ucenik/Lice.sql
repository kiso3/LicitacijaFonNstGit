CREATE TABLE [dbo].[Lice] (
    [LiceId]  INT           IDENTITY (1, 1) NOT NULL,
    [Pib]     INT           NULL,
    [Adresa]  NVARCHAR (100) NULL,
    [MestoId] INT           NULL,
    [Email]   NVARCHAR (50)  NULL,
    [Telefon] VARCHAR (50)  NULL,
    CONSTRAINT [PK_Lice] PRIMARY KEY CLUSTERED ([LiceId] ASC),
    CONSTRAINT [FK_Lice_Mesto] FOREIGN KEY ([MestoId]) REFERENCES [dbo].[Mesto] ([MestoId]) ON DELETE SET NULL
);




