CREATE TABLE [dbo].[Vlasnik] (
    [LiceId] INT NOT NULL CONSTRAINT [PK_Vlasnik] PRIMARY KEY CLUSTERED,    
    CONSTRAINT [FK_Vlasnik_Lice] FOREIGN KEY ([LiceId]) REFERENCES [dbo].[Lice] ([LiceId])
);