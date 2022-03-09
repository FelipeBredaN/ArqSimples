CREATE TABLE [dbo].[Pontuacao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Pontuacao] Decimal(2,2) not null,
	[NumeroMaximo] int not null,
	[Converter] bit not null,
	[IdConversao] int not null

    CONSTRAINT PK_Pontuacao PRIMARY KEY (Id),
)

ALTER TABLE Atividades ADD CONSTRAINT FK_Atividades_Pontuacao FOREIGN KEY (IdPontuacao) REFERENCES Pontuacao(Id)