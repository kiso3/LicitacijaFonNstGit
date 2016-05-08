CREATE TABLE [dbo].[DeoParcele] (
    [DeoParceleId]      INT   NOT NULL CONSTRAINT [PK_DeoParcele] PRIMARY KEY CLUSTERED,
    [ParcelaId]         INT   NOT NULL,
    [BrojDela]          INT   DEFAULT ((0)) NOT NULL,
    [NacinKoriscenjaId] INT   NULL,
    [Klasa]             INT   NULL,
    [KatPrih]           MONEY NULL,
    CONSTRAINT [CK_DeoParcele_Klasa] CHECK ([Klasa]=(8) OR [Klasa]=(7) OR [Klasa]=(6) OR [Klasa]=(5) OR [Klasa]=(4) OR [Klasa]=(3) OR [Klasa]=(2) OR [Klasa]=(1)),
    CONSTRAINT [FK_DeoParcele_NacinKoriscenja] FOREIGN KEY ([NacinKoriscenjaId]) REFERENCES [dbo].[NacinKoriscenja] ([NacinKoriscenjaId]),
    CONSTRAINT [FK_DeoParcele_Parcela] FOREIGN KEY ([ParcelaId]) REFERENCES [dbo].[Parcela] ([ParcelaId]),
    CONSTRAINT [FK_DeoParcele_ProstorniEntitet] FOREIGN KEY ([DeoParceleId]) REFERENCES [dbo].[ProstorniEntitet] ([FeatureId]),
    CONSTRAINT [UN_DeoParcele] UNIQUE NONCLUSTERED ([ParcelaId] ASC, [BrojDela] ASC)
);