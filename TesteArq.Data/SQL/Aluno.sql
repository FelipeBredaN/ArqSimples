CREATE TABLE [dbo].[Aluno](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Matricula] [int] NOT NULL,
	[Nome] [varchar](Max) NOT NULL,
    CursoId [int] NOT NULL

    CONSTRAINT PK_Aluno PRIMARY KEY (Id),
    CONSTRAINT FK_Aluno_Curso FOREIGN KEY (CursoId) REFERENCES Curso(Id)
)
