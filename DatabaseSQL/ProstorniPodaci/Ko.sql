CREATE TABLE [dbo].[Ko] (
    [KoId]    INT           NOT NULL CONSTRAINT [PK_Ko] PRIMARY KEY CLUSTERED,
    [NazivKO] VARCHAR (100) NULL,
    CONSTRAINT [FK_Ko_ProstorniEntitet] FOREIGN KEY ([KoId]) REFERENCES [dbo].[ProstorniEntitet] ([FeatureId])
);