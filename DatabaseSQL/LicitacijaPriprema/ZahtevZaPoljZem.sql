CREATE TABLE [dbo].[ZahtevZaPoljZem] (
    [ZahtevZaPoljZemId] INT           NOT NULL CONSTRAINT [PK_ZahtevZaPoljZem] PRIMARY KEY CLUSTERED,
    [ResenjeId]         INT           NOT NULL,
    [SluzbaKnId]        INT           NOT NULL,
    [LiceId]    INT           NOT NULL,
    [DatumPodnosenja]   DATE          NULL,
    [NazivOdeljenja]    VARCHAR (100) NULL,
    CONSTRAINT [FK_zahtevZapoljZem_KontakOsoba] FOREIGN KEY ([LiceId]) REFERENCES [dbo].[KontaktOsoba] ([LiceId]),
    CONSTRAINT [FK_zahtevZapoljZem_Resenje] FOREIGN KEY ([ResenjeId]) REFERENCES [dbo].[Resenje] ([ResenjeId]),
    CONSTRAINT [FK_zahtevZapoljZem_SluzbaKn] FOREIGN KEY ([SluzbaKnId]) REFERENCES [dbo].[SluzbaKn] ([SluzbaKnId])
);

