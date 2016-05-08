CREATE TABLE [dbo].[Prijava] (
    [PrijavaId]            INT           IDENTITY (1, 1) NOT NULL,
    [LiceId]               INT           NULL,
    [DatumPodnosenja]      DATE          NULL,
    [UMestu]               VARCHAR (100) NULL,
    [ResenjePio]           BIT           NOT NULL,
    [DokazOVlasnistvu]     BIT           NOT NULL,
    [RegistarPoljGazd]     BIT           NOT NULL,
    [UpoznatSaPonudom]     BIT           NOT NULL,
    [DatumObilaska]        DATE          NULL,
    [DokazOUplatiDepozita] BIT           NOT NULL,
    [NadmetanjeId]         INT           NOT NULL,
	[Obisao]               BIT           NULL,
    CONSTRAINT [PK_Prijava] PRIMARY KEY CLUSTERED ([PrijavaId] ASC),
    CONSTRAINT [FK_Prijava_Nadmetanje] FOREIGN KEY ([NadmetanjeId]) REFERENCES [dbo].[Nadmetanje] ([NadmetanjeId]),
    CONSTRAINT [FK_Prijava_Predstavnik] FOREIGN KEY ([LiceId]) REFERENCES [dbo].[Predstavnik] ([LiceId])
);



