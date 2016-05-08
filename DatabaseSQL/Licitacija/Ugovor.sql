CREATE TABLE [dbo].[Ugovor] (
    [UgovorId]        INT           NOT NULL CONSTRAINT [PK_Ugovor] PRIMARY KEY CLUSTERED,
    [ZapisnikId]      INT           NOT NULL,
    [DatumFormiranja] DATE          NULL,
    [CenaZakupa]      MONEY         NULL,
    [GarancijeId]     INT           NULL,
    [Tekst]           VARCHAR (MAX) NULL,
    CONSTRAINT [FK_Ugovor_Garancije] FOREIGN KEY ([GarancijeId]) REFERENCES [dbo].[Garancije] ([GarancijeId]),
    CONSTRAINT [FK_Ugovor_Zapisnik] FOREIGN KEY ([ZapisnikId]) REFERENCES [dbo].[Zapisnik] ([ZapisnikId])
);