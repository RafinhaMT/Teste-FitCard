USE [FitCard]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 18/01/2020 19:55:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estabelecimento]    Script Date: 18/01/2020 19:55:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estabelecimento](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[razaoSocial] [varchar](50) NOT NULL,
	[nomeFantasia] [varchar](50) NULL,
	[cnpj] [varchar](50) NOT NULL,
	[email] [varchar](50) NULL,
	[endereco] [varchar](50) NULL,
	[cidade] [varchar](50) NULL,
	[estado] [varchar](50) NULL,
	[telefone] [varchar](50) NULL,
	[dataDeCadastro] [datetime] NULL,
	[idCategoria] [int] NULL,
	[status] [bit] NULL,
	[agencia] [varchar](50) NULL,
	[conta] [varchar](50) NULL,
 CONSTRAINT [PK_Estabelecimento] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([id], [nome]) VALUES (1, N'Supermercado')
INSERT [dbo].[Categoria] ([id], [nome]) VALUES (2, N'Restaurante')
INSERT [dbo].[Categoria] ([id], [nome]) VALUES (3, N'Borracharia')
INSERT [dbo].[Categoria] ([id], [nome]) VALUES (4, N'Posto')
INSERT [dbo].[Categoria] ([id], [nome]) VALUES (5, N'Oficina')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
