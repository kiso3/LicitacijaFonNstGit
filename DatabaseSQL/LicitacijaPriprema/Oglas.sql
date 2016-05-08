CREATE TABLE [dbo].[Oglas] (
    [OglasId]      INT  IDENTITY (1, 1) NOT NULL,
    [ResenjeId]    INT  NOT NULL,
    [DatumObjave]  DATE NULL,
    [MaxpovZakupa] INT  NULL,
    CONSTRAINT [PK_Oglas] PRIMARY KEY CLUSTERED ([OglasId] ASC),
    CONSTRAINT [FK_Oglas_Resenje] FOREIGN KEY ([ResenjeId]) REFERENCES [dbo].[Resenje] ([ResenjeId]),
	CONSTRAINT [UK_ ResenjeId] UNIQUE NONCLUSTERED ([ResenjeId]) 
);
