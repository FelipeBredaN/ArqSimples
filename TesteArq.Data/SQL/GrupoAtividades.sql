CREATE TABLE [dbo].[GrupoAtividades](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](Max) NOT NULL,
    [EmailAdress] [varchar](Max) NOT NULL,

    CONSTRAINT PK_GrupoAtividades PRIMARY KEY (Id),
)
