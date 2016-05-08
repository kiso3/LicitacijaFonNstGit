CREATE TABLE [dbo].[UpisPrava] (
    [UpisPravaId] INT NOT NULL CONSTRAINT [PK_UpisPrava] PRIMARY KEY CLUSTERED,
    [FeatureId]   INT NOT NULL,
    [LiceId]   INT NOT NULL,
    CONSTRAINT [FK_UpisPrava_ProstorniEntitet] FOREIGN KEY ([FeatureId]) REFERENCES [dbo].[ProstorniEntitet] ([FeatureId]),
    CONSTRAINT [FK_UpisPrava_Vlasnik] FOREIGN KEY ([LiceId]) REFERENCES [dbo].[Vlasnik] ([LiceId])
);