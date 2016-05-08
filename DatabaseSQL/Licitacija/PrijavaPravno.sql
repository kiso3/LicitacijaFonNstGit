CREATE TABLE [dbo].[PrijavaPravno] (
    [PrijavaId]                 INT NOT NULL,
    [LiceId]                    INT NULL,
    [IzvodIzPrivrednogRegistra] BIT NOT NULL,
    CONSTRAINT [PK_PrijavaPravno] PRIMARY KEY CLUSTERED ([PrijavaId] ASC),
    CONSTRAINT [FK_PrijavaPravno_Pravno] FOREIGN KEY ([LiceId]) REFERENCES [dbo].[Pravno] ([LiceId]),
    CONSTRAINT [FK_PrijavaPravno_Prijava] FOREIGN KEY ([PrijavaId]) REFERENCES [dbo].[Prijava] ([PrijavaId])
);



