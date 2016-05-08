CREATE TABLE [dbo].[KopleksProstorniEntitet] (
    [ProstorniEntitetId] INT NOT NULL,
    [KompleksId]         INT NOT NULL,
	CONSTRAINT [PK_KopleksProstorniEntitet] PRIMARY KEY ([KompleksId],[ProstorniEntitetId]),
    CONSTRAINT [FK_KopleksProstorniEntitet_Kompleks] FOREIGN KEY ([KompleksId]) REFERENCES [dbo].[Kompleks] ([KompleksId]),
    CONSTRAINT [FK_KopleksProstorniEntitet_ProstorniEntitet] FOREIGN KEY ([ProstorniEntitetId]) REFERENCES [dbo].[ProstorniEntitet] ([FeatureId])
);