CREATE TABLE [dbo].[PrijavaUZapisniku] (
    [ZapisnikId]            INT           NOT NULL,
	[Rb]					INT           NOT NULL,    
    [LicitiranaCena]        MONEY         NULL,
    [BrLicitatorskeKartice] INT           NULL,
    [Prisutan]              BIT           NOT NULL,
    [Pobednik]              BIT           NULL,
    [IzreceneMereId]        INT           NULL,
    [PrigovorPrimedba]      VARCHAR (MAX) NULL,
    [Odluka]                VARCHAR (MAX) NULL,
	[PrijavaId]             INT           NOT NULL,
    CONSTRAINT [PK_PrijavaUZapisniku] PRIMARY KEY ([ZapisnikId],[Rb]), --REFERENCES [dbo].[IzreceneMere] ([IzreceneMereId]),
    CONSTRAINT [FK_PrijavUZapisniku_IzreceneMere] FOREIGN KEY ([IzreceneMereId]) REFERENCES [dbo].[IzreceneMere] ([IzreceneMereId]),
    CONSTRAINT [FK_PrijavUZapisniku_Prijava] FOREIGN KEY ([PrijavaId]) REFERENCES [dbo].[Prijava] ([PrijavaId]),
    CONSTRAINT [FK_PrijavUZapisniku_Zapisnik] FOREIGN KEY ([ZapisnikId]) REFERENCES [dbo].[Zapisnik] ([ZapisnikId]),
	CONSTRAINT [UK_PrijavaId] UNIQUE NONCLUSTERED ([PrijavaId])    
);

