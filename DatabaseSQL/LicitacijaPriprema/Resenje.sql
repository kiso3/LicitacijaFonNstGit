CREATE TABLE [dbo].[Resenje] (
    [ResenjeId]          INT           IDENTITY (1, 1) NOT NULL,
    [OpstinaId]          INT           NOT NULL,
    [DaumSednice]        DATE          NULL,
    [SluzbeniListBr]     VARCHAR (50)  NULL,
    [ClasnStatuta]       INT           NULL,
    [DarumIzradeResenja] DATE          NULL,
    [ZaGodinu]           DATE          NULL,
    [TekstOdluke]        VARCHAR (MAX) NULL,
    CONSTRAINT [PK_Resenje] PRIMARY KEY CLUSTERED ([ResenjeId] ASC),
    CONSTRAINT [FK_Resenje_Opstina] FOREIGN KEY ([OpstinaId]) REFERENCES [dbo].[Opstina] ([OpstinaId])
);

