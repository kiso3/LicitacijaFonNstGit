CREATE TABLE [dbo].[KomisijaZaIzraduPonude] (
    [Rb]                   INT NOT NULL,
    [Resenjeid]            INT NOT NULL,
    [UlogaClanaKomisijeId] INT NOT NULL,
    [LiceId]           INT NOT NULL,
    CONSTRAINT [PK_KomisijaZaIzraduPonude] PRIMARY KEY CLUSTERED ([Rb] ASC, [Resenjeid] ASC),
    CONSTRAINT [FK_KomisijaZaIzraduPonude_Komisija] FOREIGN KEY ([LiceId]) REFERENCES [dbo].[Komisija] ([LiceId]),
    CONSTRAINT [FK_KomisijaZaIzraduPonude_Resenje] FOREIGN KEY ([Resenjeid]) REFERENCES [dbo].[Resenje] ([ResenjeId]),
    CONSTRAINT [FK_KomisijaZaIzraduPonude_UlogaCLanaKomisije] FOREIGN KEY ([UlogaClanaKomisijeId]) REFERENCES [dbo].[UlogaClanaKomisije] ([UlogaClanaKomisijeId])
);
