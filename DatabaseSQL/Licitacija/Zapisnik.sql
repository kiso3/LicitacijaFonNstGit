CREATE TABLE [dbo].[Zapisnik] (
    [ZapisnikId]         INT           NOT NULL CONSTRAINT [PK_Zapisnik] PRIMARY KEY CLUSTERED,
    [NadmetanjeId]       INT           NOT NULL,
    [OglasId]            INT           NOT NULL,
    [AdresaLicitacije]   VARCHAR (100) NULL,
    [Odrzana]            BIT           NOT NULL,
    [Mesto]              VARCHAR (100) NULL,
    [DatumVremePocetka]  DATETIME      NULL,
    [DateVremeZavrsetak] DATETIME      NULL,
    CONSTRAINT [FK_Zapisnik_Nadmetanje] FOREIGN KEY ([NadmetanjeId]) REFERENCES [dbo].[Nadmetanje] ([NadmetanjeId])
);

