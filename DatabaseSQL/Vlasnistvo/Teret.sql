CREATE TABLE [dbo].[Teret] (
    [TeretId]       INT  NOT NULL CONSTRAINT [PK_Teret] PRIMARY KEY CLUSTERED,
    [DatumUpisa]    DATE NULL,
    [Trajanje]      INT  NULL,
    [VrstaTeretaId] INT  NULL,
    [DatumBrisanja] DATE NULL,
    CONSTRAINT [FK_Teret_UpisPrava] FOREIGN KEY ([TeretId]) REFERENCES [dbo].[UpisPrava] ([UpisPravaId]),
    CONSTRAINT [FK_Teret_VrstaTereta] FOREIGN KEY ([VrstaTeretaId]) REFERENCES [dbo].[VrstaTereta] ([VrstaTeretaId])
);