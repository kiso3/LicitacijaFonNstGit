CREATE TABLE [dbo].[Predstavnik] (
    [LiceId] INT NOT NULL CONSTRAINT [PK_Predstavnik] PRIMARY KEY CLUSTERED,     
    CONSTRAINT [FK_Predstavik_Ucesnik] FOREIGN KEY ([LiceId]) REFERENCES [dbo].[Fizicko] ([LiceId])
);
