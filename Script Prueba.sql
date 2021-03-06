USE [master]
GO
/****** Object:  Database [pruebas_dp]    Script Date: 03/07/2022 04:22:08 a. m. ******/
CREATE DATABASE [pruebas_dp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pruebas_dp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\pruebas_dp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'pruebas_dp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\pruebas_dp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [pruebas_dp] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pruebas_dp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pruebas_dp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pruebas_dp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pruebas_dp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pruebas_dp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pruebas_dp] SET ARITHABORT OFF 
GO
ALTER DATABASE [pruebas_dp] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [pruebas_dp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pruebas_dp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pruebas_dp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pruebas_dp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pruebas_dp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pruebas_dp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pruebas_dp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pruebas_dp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pruebas_dp] SET  ENABLE_BROKER 
GO
ALTER DATABASE [pruebas_dp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pruebas_dp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pruebas_dp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pruebas_dp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pruebas_dp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pruebas_dp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [pruebas_dp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pruebas_dp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [pruebas_dp] SET  MULTI_USER 
GO
ALTER DATABASE [pruebas_dp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pruebas_dp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pruebas_dp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pruebas_dp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [pruebas_dp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [pruebas_dp] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [pruebas_dp] SET QUERY_STORE = OFF
GO
USE [pruebas_dp]
GO
/****** Object:  User [usersql]    Script Date: 03/07/2022 04:22:08 a. m. ******/
CREATE USER [usersql] FOR LOGIN [usersql] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[addresses]    Script Date: 03/07/2022 04:22:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[addresses](
	[Id] [int] NOT NULL,
	[Calle] [varchar](30) NULL,
	[Numero] [varchar](10) NULL,
	[Colonia] [varchar](40) NULL,
 CONSTRAINT [PK_addresses_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[distributors]    Script Date: 03/07/2022 04:22:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[distributors](
	[Id] [int] NOT NULL,
	[FechaRegistro] [date] NOT NULL,
 CONSTRAINT [PK_distributors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[FechaRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[persons]    Script Date: 03/07/2022 04:22:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persons](
	[Id] [int] NOT NULL,
	[Nombre] [varchar](30) NULL,
	[Appaterno] [varchar](30) NULL,
	[Apmaterno] [varchar](30) NULL,
 CONSTRAINT [PK_persons] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[addresses] ([Id], [Calle], [Numero], [Colonia]) VALUES (1, N'Callesini', N'555', N'Colinas')
INSERT [dbo].[addresses] ([Id], [Calle], [Numero], [Colonia]) VALUES (2, N'Por ahi', N'323', N'Palos Prietos')
INSERT [dbo].[addresses] ([Id], [Calle], [Numero], [Colonia]) VALUES (3, N'juasjuasjuas', N'33111', N'Colonia c')
INSERT [dbo].[addresses] ([Id], [Calle], [Numero], [Colonia]) VALUES (4, N'Calle Rio', N'222', N'Brisas')
INSERT [dbo].[addresses] ([Id], [Calle], [Numero], [Colonia]) VALUES (5, N'Rio', N'333', N'Brisas')
INSERT [dbo].[addresses] ([Id], [Calle], [Numero], [Colonia]) VALUES (6, N'asdad', N'asdsad', N'sdasd')
INSERT [dbo].[addresses] ([Id], [Calle], [Numero], [Colonia]) VALUES (7, N'', N'', N'')
INSERT [dbo].[addresses] ([Id], [Calle], [Numero], [Colonia]) VALUES (8, N'Breaking', N'111', N'Bad')
INSERT [dbo].[addresses] ([Id], [Calle], [Numero], [Colonia]) VALUES (9, N'Calle', N'222', N'COlonia')
GO
INSERT [dbo].[distributors] ([Id], [FechaRegistro]) VALUES (1, CAST(N'2022-07-02' AS Date))
INSERT [dbo].[distributors] ([Id], [FechaRegistro]) VALUES (2, CAST(N'2022-07-02' AS Date))
INSERT [dbo].[distributors] ([Id], [FechaRegistro]) VALUES (3, CAST(N'2022-07-02' AS Date))
INSERT [dbo].[distributors] ([Id], [FechaRegistro]) VALUES (4, CAST(N'2022-07-02' AS Date))
INSERT [dbo].[distributors] ([Id], [FechaRegistro]) VALUES (5, CAST(N'2022-07-02' AS Date))
INSERT [dbo].[distributors] ([Id], [FechaRegistro]) VALUES (6, CAST(N'2022-07-02' AS Date))
INSERT [dbo].[distributors] ([Id], [FechaRegistro]) VALUES (7, CAST(N'2022-07-02' AS Date))
INSERT [dbo].[distributors] ([Id], [FechaRegistro]) VALUES (8, CAST(N'2022-07-02' AS Date))
INSERT [dbo].[distributors] ([Id], [FechaRegistro]) VALUES (9, CAST(N'2022-07-03' AS Date))
GO
INSERT [dbo].[persons] ([Id], [Nombre], [Appaterno], [Apmaterno]) VALUES (1, N'Jesus', N'Perez', N'Perez')
INSERT [dbo].[persons] ([Id], [Nombre], [Appaterno], [Apmaterno]) VALUES (2, N'Juan', N'Osuna', N'Perez')
INSERT [dbo].[persons] ([Id], [Nombre], [Appaterno], [Apmaterno]) VALUES (3, N'Nuevo', N'Usuario', N':)')
INSERT [dbo].[persons] ([Id], [Nombre], [Appaterno], [Apmaterno]) VALUES (4, N'Javier', N'Cravioto', N'Savin')
INSERT [dbo].[persons] ([Id], [Nombre], [Appaterno], [Apmaterno]) VALUES (5, N'Roberto', N'Martinez', N'Martinez')
INSERT [dbo].[persons] ([Id], [Nombre], [Appaterno], [Apmaterno]) VALUES (6, N'Nombre', N'Juasjuas', N'asdkasdasd')
INSERT [dbo].[persons] ([Id], [Nombre], [Appaterno], [Apmaterno]) VALUES (7, N'Juan', N'Perez', N'')
INSERT [dbo].[persons] ([Id], [Nombre], [Appaterno], [Apmaterno]) VALUES (8, N'Nacho', N'Varga', N'Matador')
INSERT [dbo].[persons] ([Id], [Nombre], [Appaterno], [Apmaterno]) VALUES (9, N'Juan', N'Perez', N'Martinez')
GO
/****** Object:  StoredProcedure [dbo].[PROC_AGREGARDISTRIBUIDOR]    Script Date: 03/07/2022 04:22:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_AGREGARDISTRIBUIDOR] ( @Nombre varchar(30), @Appaterno varchar(30), @Apmaterno varchar(30),    
@Calle varchar(50),  @Numero varchar(7), @Colonia varchar(50))    
    

AS    

Declare @IDActual Int
Set @IDActual = (select top 1 ID from persons order by ID desc) +1

  
BEGIN    
    
 INSERT INTO addresses(Calle, Numero, Colonia,Id)    
 VALUES(@Calle,@Numero, @Colonia, @IDActual );    
    
 INSERT INTO distributors(Id, Fecharegistro)    
 VALUES(@IDActual, GETDATE());    
    
 INSERT INTO persons(Nombre,Appaterno, Apmaterno, Id)    
 VALUES(@Nombre, @Appaterno, @Apmaterno, @IDActual);    
     
    
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarDistribuidor]    Script Date: 03/07/2022 04:22:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BuscarDistribuidor] ( @id int)    
AS  
BEGIN  
  
select p.Nombre + ' ' + p.appaterno + ' ' + p.appaterno As Nombre_Completo, a.Calle,a.Numero As Numero_de_Casa, a.Colonia from persons p inner join addresses a on p.id = a.id where p.id = @id  
  
END
GO
USE [master]
GO
ALTER DATABASE [pruebas_dp] SET  READ_WRITE 
GO
