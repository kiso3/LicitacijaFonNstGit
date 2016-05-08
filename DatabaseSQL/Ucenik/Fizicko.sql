CREATE TABLE [dbo].[Fizicko] (
    [LiceId]       INT          NOT NULL,
    [Jmbg]         CHAR (13)    NULL,
    [Ime]          VARCHAR (50) NULL,
    [ImeRoditelja] VARCHAR (50) NULL,
    [Prezime]      NCHAR (10)   NULL,
    CONSTRAINT [PK_Fizicko] PRIMARY KEY CLUSTERED ([LiceId] ASC),
    CONSTRAINT [FK_Fizicko_Ucesnik] FOREIGN KEY ([LiceId]) REFERENCES [dbo].[Lice] ([LiceId]) ON DELETE CASCADE
);


