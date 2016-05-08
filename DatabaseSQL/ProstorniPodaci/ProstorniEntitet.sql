CREATE TABLE [dbo].[ProstorniEntitet] (
    [FeatureId]        INT              NOT NULL CONSTRAINT [FeatureId] PRIMARY KEY CLUSTERED,
    [Povrsina]         DECIMAL (18, 2)  NULL,
    [ManagerFeatureId] INT              NULL,
    [Geometry]         [sys].[geometry] NULL,
    CONSTRAINT [FK_ProstorniEntitet_ProstorniEntitet_ManagerFeatureId] FOREIGN KEY ([ManagerFeatureId]) REFERENCES [dbo].[ProstorniEntitet] ([FeatureId])
);