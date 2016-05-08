CREATE TABLE [dbo].[Kompleks] (
    [KompleksId]     INT  IDENTITY (1, 1) NOT NULL,
    [DatumKreiranja] DATE NULL,
    [Povrsina]       INT  NOT NULL,
    [PovrsinaPodObj] INT  CONSTRAINT [DF__Kompleks__Povrsi__7D439ABD] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Kompleks] PRIMARY KEY CLUSTERED ([KompleksId] ASC)
);

