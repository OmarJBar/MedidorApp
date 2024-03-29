USE [MedidoreDB]
GO
/****** Object:  Table [dbo].[Lecturas]    Script Date: 18-07-2022 4:16:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lecturas](
	[idLecturas] [int] NOT NULL,
	[date] [date] NOT NULL,
	[consumo] [varchar](45) NOT NULL,
	[FK_Usuario] [varchar](50) NOT NULL,
	[FK_Medidor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idLecturas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medidores]    Script Date: 18-07-2022 4:16:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medidores](
	[idMedidores] [int] NOT NULL,
	[tipo] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idMedidores] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 18-07-2022 4:16:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[rut] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[passwd] [varchar](45) NOT NULL,
	[mail] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[rut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Lecturas]  WITH CHECK ADD  CONSTRAINT [fk_Lecturas_Medidores1] FOREIGN KEY([FK_Medidor])
REFERENCES [dbo].[Medidores] ([idMedidores])
GO
ALTER TABLE [dbo].[Lecturas] CHECK CONSTRAINT [fk_Lecturas_Medidores1]
GO
ALTER TABLE [dbo].[Lecturas]  WITH CHECK ADD  CONSTRAINT [fk_Lecturas_Usuarios] FOREIGN KEY([FK_Usuario])
REFERENCES [dbo].[Usuarios] ([rut])
GO
ALTER TABLE [dbo].[Lecturas] CHECK CONSTRAINT [fk_Lecturas_Usuarios]
GO
