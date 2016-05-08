CREATE TABLE [dbo].[Komisija] (
    [LiceId]      INT NOT NULL CONSTRAINT [PK_Komisija] PRIMARY KEY CLUSTERED,
    [StrucnaSpremaId] INT NULL,
    CONSTRAINT [FK_Komisija_Fizicko] FOREIGN KEY ([LiceId]) REFERENCES [dbo].[Fizicko] ([LiceId]),
    CONSTRAINT [FK_Komisija_StrucnaSprema] FOREIGN KEY ([StrucnaSpremaId]) REFERENCES [dbo].[StrucnaSprema] ([StrucnaSpremaId])
);