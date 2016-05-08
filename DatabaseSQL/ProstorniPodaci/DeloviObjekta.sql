CREATE TABLE [dbo].[DeloviObjekta] (
    [DeloviObjektaId]          INT             NOT NULL CONSTRAINT [PK_DeloviObjekta] PRIMARY KEY CLUSTERED ,
    [ObjekatId]                INT             NOT NULL,
    [EvidencijskiBroj]         INT             DEFAULT ((1)) NOT NULL,
    [OsnoviObj]                INT             DEFAULT ((1)) NOT NULL,
    [PodbrojObj]               INT             DEFAULT ((0)) NOT NULL,
    [KorisnaPovrsina]          DECIMAL (18, 2) NULL,
    [NacinKoriscenjaDelaObjId] INT             NULL,
    [Sobnost]                  NCHAR (10)      NULL,
    [AdresaPosebnogDelaObj]    VARCHAR (100)   NULL,
    [PravniStatus]             NCHAR (10)      NULL,
    [SpratnostId]              INT             NULL,
    CONSTRAINT [FK_DeloviObjekta_NacinKoriscenjaDelaObj] FOREIGN KEY ([NacinKoriscenjaDelaObjId]) REFERENCES [dbo].[NacinKoriscenjaDelaObj] ([NacinKoriscenjaDelaObjId]),
    CONSTRAINT [FK_DeloviObjekta_Objekat] FOREIGN KEY ([ObjekatId]) REFERENCES [dbo].[Objekat] ([ObjekatId]),
    CONSTRAINT [FK_DeloviObjekta_ProstorniEntitet] FOREIGN KEY ([DeloviObjektaId]) REFERENCES [dbo].[ProstorniEntitet] ([FeatureId]),
    CONSTRAINT [FK_DeloviObjekta_Spratnost] FOREIGN KEY ([SpratnostId]) REFERENCES [dbo].[Spratnost] ([SpratnostId]),
    CONSTRAINT [UN_DeloviObjekta] UNIQUE NONCLUSTERED ([ObjekatId] ASC, [EvidencijskiBroj] ASC, [OsnoviObj] ASC, [PodbrojObj] ASC)
);

