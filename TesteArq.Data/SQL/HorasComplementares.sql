CREATE TABLE [dbo].[HorasComplementares](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdAluno] int not null,
	[idAtividade] int not null,
	[Certificado] varchar(max) not null,
	[Status] bit not null,
	[Horas] time not null,

    CONSTRAINT PK_HorasComplementares PRIMARY KEY (Id),
	CONSTRAINT FK_HorasComplementares_aluno FOREIGN KEY (IdAluno) REFERENCES Aluno(Id),
	CONSTRAINT FK_HorasComplementares_Atividade FOREIGN KEY (idAtividade) REFERENCES Aluno(Id),
)

ALTER TABLE Atividades ADD CONSTRAINT FK_Atividades_HorasComplementares FOREIGN KEY (IdHorasComplementares) REFERENCES HorasComplementares(Id)
