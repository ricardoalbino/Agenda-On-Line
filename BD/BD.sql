SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE DATABASE agendaonline
GO
CREATE TABLE [usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[senha] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
CREATE TABLE [contato](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[telefone] [varchar](15) NOT NULL,
	[celular] [varchar](15) NOT NULL,
	[recado] [varchar](15) NOT NULL
) ON [PRIMARY]

