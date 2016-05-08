CREATE TABLE [dbo].[Objekat] (
    [ObjekatId]            INT           NOT NULL CONSTRAINT [PK_Objekat] PRIMARY KEY CLUSTERED,
    [DeoParceleId]         INT           NOT NULL,
    [IspodPrizemlja]       INT           DEFAULT ((0)) NULL,
    [Prizemlje]            INT           DEFAULT ((0)) NULL,
    [IznadPrizemlja]       INT           DEFAULT ((0)) NULL,
    [UPodkrovlju]          INT           DEFAULT ((0)) NULL,
    [UkupnoEtaza]          INT           DEFAULT ((0)) NULL,
    [NacinKoriscenjaObjId] INT           NULL,
    [AdresaObj]            VARCHAR (100) NULL,
    [PravniStatusObjId]    INT           NULL,
    CONSTRAINT [CK_Objekat_IspodPrizemlja] CHECK ([IspodPrizemlja]>=(0)),
    CONSTRAINT [FK_Objekat_DeoParcele] FOREIGN KEY ([DeoParceleId]) REFERENCES [dbo].[DeoParcele] ([DeoParceleId]),
    CONSTRAINT [FK_Objekat_NacinKoriscenjaObj] FOREIGN KEY ([NacinKoriscenjaObjId]) REFERENCES [dbo].[NacinKoriscenjaObj] ([NacinKoriscenjaObjId]),
    CONSTRAINT [FK_Objekat_PravniStatusObj] FOREIGN KEY ([PravniStatusObjId]) REFERENCES [dbo].[PravniStatusObj] ([PravniStatusObjId]),
    CONSTRAINT [FK_Objekat_ProstorniEntitet] FOREIGN KEY ([ObjekatId]) REFERENCES [dbo].[ProstorniEntitet] ([FeatureId])
);

