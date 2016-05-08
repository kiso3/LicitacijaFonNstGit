CREATE TABLE [dbo].[PravniStatusObj] (
    [PravniStatusObjId] INT          NOT NULL CONSTRAINT [PF_PravniStatusObj] PRIMARY KEY CLUSTERED,
    [Naziv]             VARCHAR (50) NULL
);