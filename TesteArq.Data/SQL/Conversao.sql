CREATE TABLE [dbo].[Conversao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPontuacao] int not null,
	[NumeroMaximo] int not null,

    CONSTRAINT PK_Conversao PRIMARY KEY (Id),
)

ALTER TABLE [Conversao] ADD CONSTRAINT FK_Conversao_Pontuacao FOREIGN KEY (IdPontuacao) REFERENCES Pontuacao(Id)
