CREATE TABLE [dbo].[ClanoviZapisnikKomisije] (
    [ZapisnikId]           INT NOT NULL,
    [LiceId]           INT NOT NULL,
    [UlogaClanaKomisijeId] INT NOT NULL,
	CONSTRAINT [PK_ClanoviZapisnikKomisije_1] PRIMARY KEY CLUSTERED ([ZapisnikId] ASC, [LiceId] ASC, [UlogaClanaKomisijeId] ASC),
    CONSTRAINT [FK_ClanoviZapisnikKomisije_Komisija] FOREIGN KEY ([LiceId]) REFERENCES [dbo].[Komisija] ([LiceId]),
    CONSTRAINT [FK_ClanoviZapisnikKomisije_UlogaClana] FOREIGN KEY ([UlogaClanaKomisijeId]) REFERENCES [dbo].[UlogaClanaKomisije] ([UlogaClanaKomisijeId]),
    CONSTRAINT [FK_ClanoviZapisnikKomisije_Zapisnik] FOREIGN KEY ([ZapisnikId]) REFERENCES [dbo].[Zapisnik] ([ZapisnikId])
);