/****** Object:  Database [hrsf]    Script Date: 22-Apr-20 1:35:07 PM ******/
CREATE DATABASE [hrsf]

CREATE TABLE [dbo].[Convenio](
	[IDConvenio] [int] IDENTITY(1,1) NOT NULL,
	[IDEmpleado] [int] NULL,
	[TipoMedico] [nvarchar](max) NULL,
	[ServicioSolicitante] [nvarchar](max) NULL,
	[Compromiso] [nvarchar](max) NULL,
	[FechaInicio] [datetime2](7) NULL,
	[FechaFinal] [datetime2](7) NULL,
	[Companero] [nvarchar](max) NULL,
	[ServicioCompanero] [nvarchar](max) NULL,
	[CompromisoPago] [nvarchar](max) NULL,
	[motivo] [nvarchar](max) NULL,
	[Turno] [nvarchar](1) NULL,
 CONSTRAINT [PK_Convenio] PRIMARY KEY CLUSTERED 
(
	[IDConvenio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 22-Apr-20 1:35:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[IDEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[FechaIngreso] [datetime2](7) NULL,
	[TipoEmpleado] [int] NULL,
	[TipoContrato] [nvarchar](max) NULL,
	[TieneProfilactica] [nvarchar](max) NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[IDEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Incapacidad]    Script Date: 22-Apr-20 1:35:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incapacidad](
	[IDIncapacidad] [int] IDENTITY(1,1) NOT NULL,
	[IDEmpleado] [int] NULL,
	[Medico] [nvarchar](max) NULL,
	[Diagnostico] [nvarchar](max) NULL,
	[NotificaJefe] [nvarchar](max) NULL,
	[FechaInicio] [datetime2](7) NULL,
	[FechaFinal] [datetime2](7) NULL,
 CONSTRAINT [PK_Incapacidad] PRIMARY KEY CLUSTERED 
(
	[IDIncapacidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 22-Apr-20 1:35:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[IDpermiso] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
	[FechaInicio] [datetime2](7) NULL,
	[FechaFinal] [datetime2](7) NULL,
	[Justificado] [nvarchar](max) NULL,
	[IDEmpleado] [int] NULL,
	[Sala] [nvarchar](max) NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[IDpermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoEmpleado]    Script Date: 22-Apr-20 1:35:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoEmpleado](
	[IDTipo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
 CONSTRAINT [PK_TipoEmpleado] PRIMARY KEY CLUSTERED 
(
	[IDTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vacaciones]    Script Date: 22-Apr-20 1:35:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vacaciones](
	[IDVac] [int] IDENTITY(1,1) NOT NULL,
	[Inicio] [datetime2](7) NULL,
	[Final] [datetime2](7) NULL,
	[TipoVacacion] [nvarchar](max) NULL,
	[IDEmpleado] [int] NULL,
 CONSTRAINT [PK_Vacaciones] PRIMARY KEY CLUSTERED 
(
	[IDVac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Convenio]  WITH CHECK ADD  CONSTRAINT [FK_Convenio_Empleado] FOREIGN KEY([IDEmpleado])
REFERENCES [dbo].[Empleado] ([IDEmpleado])
GO
ALTER TABLE [dbo].[Convenio] CHECK CONSTRAINT [FK_Convenio_Empleado]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_TipoEmpleado] FOREIGN KEY([TipoEmpleado])
REFERENCES [dbo].[TipoEmpleado] ([IDTipo])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_TipoEmpleado]
GO
ALTER TABLE [dbo].[Incapacidad]  WITH CHECK ADD  CONSTRAINT [FK_Incapacidad_Empleado] FOREIGN KEY([IDEmpleado])
REFERENCES [dbo].[Empleado] ([IDEmpleado])
GO
ALTER TABLE [dbo].[Incapacidad] CHECK CONSTRAINT [FK_Incapacidad_Empleado]
GO
ALTER TABLE [dbo].[Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_Empleado] FOREIGN KEY([IDEmpleado])
REFERENCES [dbo].[Empleado] ([IDEmpleado])
GO
ALTER TABLE [dbo].[Permiso] CHECK CONSTRAINT [FK_Permiso_Empleado]
GO
ALTER TABLE [dbo].[Vacaciones]  WITH CHECK ADD  CONSTRAINT [FK_Vacaciones_Empleado] FOREIGN KEY([IDEmpleado])
REFERENCES [dbo].[Empleado] ([IDEmpleado])
GO
ALTER TABLE [dbo].[Vacaciones] CHECK CONSTRAINT [FK_Vacaciones_Empleado]
GO
USE [master]
GO
ALTER DATABASE [hrsf] SET  READ_WRITE 
GO
