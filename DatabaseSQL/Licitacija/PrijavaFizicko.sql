CREATE TABLE [dbo].[PrijavaFizicko] (
    [PrijavaId]                INT NOT NULL,
    [LiceId]                   INT NULL,
    [LicnaKarta]               BIT NOT NULL,
    [DokazOGranicnomZemljistu] BIT NOT NULL,
    CONSTRAINT [PK_PrijavaFizicko] PRIMARY KEY CLUSTERED ([PrijavaId] ASC),
    CONSTRAINT [FK_PrijavaFizicko_Fizicko] FOREIGN KEY ([LiceId]) REFERENCES [dbo].[Fizicko] ([LiceId]),
    CONSTRAINT [FK_PrijavaFizicko_Prijava] FOREIGN KEY ([PrijavaId]) REFERENCES [dbo].[Prijava] ([PrijavaId])
);



