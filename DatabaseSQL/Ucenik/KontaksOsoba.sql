CREATE TABLE [dbo].[KontaktOsoba] (
    [LiceId] INT NOT NULL CONSTRAINT [PK_KontaktOsoba] PRIMARY KEY CLUSTERED,
    CONSTRAINT [FK_KontaktOsoba_Fizicko] FOREIGN KEY ([LiceId]) REFERENCES [dbo].[Fizicko] ([LiceId])
);
