CREATE TABLE [dbo].[Nadmetanje] (
    [NadmetanjeId]     INT             IDENTITY (1, 1) NOT NULL,
    [OglasId]          INT             NOT NULL,
    [KompleksId]       INT             NOT NULL,
    [PocetnaCena]      NUMERIC (18, 2) NOT NULL,
    [DatumNadmetanja]  DATE            NULL,
    [Depozit]          MONEY           NOT NULL,
    [OznakaNadmetanja] CHAR (10)       NULL,
    [PeriodZakupa]     INT             NULL,
    CONSTRAINT [PK_Nadmetanje_1] PRIMARY KEY CLUSTERED ([NadmetanjeId] ASC),
    CONSTRAINT [FK_Nadmetanje_Kompleks] FOREIGN KEY ([KompleksId]) REFERENCES [dbo].[Kompleks] ([KompleksId]),
    CONSTRAINT [FK_Nadmetanje_Oglas] FOREIGN KEY ([OglasId]) REFERENCES [dbo].[Oglas] ([OglasId])
);

