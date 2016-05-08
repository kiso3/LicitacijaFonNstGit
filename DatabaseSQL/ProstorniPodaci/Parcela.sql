CREATE TABLE [dbo].[Parcela] (
    [ParcelaId]           INT           NOT NULL CONSTRAINT [PK_Parcela] PRIMARY KEY CLUSTERED,
    [Osnovni]             INT           NOT NULL,
    [Podbroj]             INT           DEFAULT ((0)) NOT NULL,
    [PotesUlica]          VARCHAR (100) NULL,
    [VrstaZemljistaId]    INT           NULL,
    [ListNepokretnostiId] INT           NULL,
    [KoId]                INT           NULL,
    CONSTRAINT [FK_Parcela_Ko] FOREIGN KEY ([KoId]) REFERENCES [dbo].[Ko] ([KoId]),
    CONSTRAINT [FK_Parcela_ProstorniEntitet] FOREIGN KEY ([ParcelaId]) REFERENCES [dbo].[ProstorniEntitet] ([FeatureId]),
    CONSTRAINT [FK_Parcela_VrstaZemljista] FOREIGN KEY ([VrstaZemljistaId]) REFERENCES [dbo].[VrstaZemljista] ([VrstaZemljistaId]),
    CONSTRAINT [UN_Parcela] UNIQUE NONCLUSTERED ([Osnovni] ASC, [Podbroj] ASC)
);