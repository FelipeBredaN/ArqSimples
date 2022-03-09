CREATE TABLE [dbo].[Atividades](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPontuacao] int not null,
	[IdHorasComplementares] int not null

    CONSTRAINT PK_Atividades PRIMARY KEY (Id),
	--Acrescentar Constraint para id pontuacao e id horas complementares
)
