CREATE TABLE [dbo].[VlasnikNepo] (
    [VlasnikNnepoId] INT            NOT NULL CONSTRAINT [PK_VlasnikNepo] PRIMARY KEY CLUSTERED,
    [VrstaPravaId]   INT            NULL,
    [OblikSvojineId] INT            NULL,
    [Udeo]           DECIMAL (2, 2) NULL,
    CONSTRAINT [FK_VlasnikNepo_OblikSvojine] FOREIGN KEY ([OblikSvojineId]) REFERENCES [dbo].[OblikSvojine] ([OblikSvojineId]),
    CONSTRAINT [FK_VlasnikNepo_UpisPrava] FOREIGN KEY ([VlasnikNnepoId]) REFERENCES [dbo].[UpisPrava] ([UpisPravaId]),
    CONSTRAINT [FK_VlasnikNepo_VrstaPrava] FOREIGN KEY ([VrstaPravaId]) REFERENCES [dbo].[VrstaPrava] ([VrstaPravaId])
);