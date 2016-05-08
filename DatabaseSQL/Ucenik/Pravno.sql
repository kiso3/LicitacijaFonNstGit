CREATE TABLE [dbo].[Pravno] (
    [LiceId] INT           NOT NULL,
    [Mb]     CHAR (8)      NULL,
    [Naziv]  VARCHAR (100) NULL,
    CONSTRAINT [PK_Pravno] PRIMARY KEY CLUSTERED ([LiceId] ASC),
    CONSTRAINT [FK_Pravno_Lice] FOREIGN KEY ([LiceId]) REFERENCES [dbo].[Lice] ([LiceId]) ON DELETE CASCADE
);

