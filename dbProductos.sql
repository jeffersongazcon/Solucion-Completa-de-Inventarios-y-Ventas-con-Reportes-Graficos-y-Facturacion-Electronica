USE [master]
GO
/****** Object:  Database [SistemaDeUsuario]    Script Date: 30/04/2024 05:38:36 p. m. ******/
CREATE DATABASE [SistemaDeUsuario]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaDeUsuario', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SistemaDeUsuario.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SistemaDeUsuario_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SistemaDeUsuario_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SistemaDeUsuario] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaDeUsuario].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaDeUsuario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SistemaDeUsuario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaDeUsuario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaDeUsuario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SistemaDeUsuario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaDeUsuario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SistemaDeUsuario] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaDeUsuario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaDeUsuario] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaDeUsuario] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaDeUsuario] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SistemaDeUsuario] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SistemaDeUsuario] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SistemaDeUsuario] SET QUERY_STORE = ON
GO
ALTER DATABASE [SistemaDeUsuario] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SistemaDeUsuario]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 30/04/2024 05:38:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductoID] [int] IDENTITY(1,1) NOT NULL,
	[CodigoDeBarras] [int] NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[DescripcionProducto] [nvarchar](250) NOT NULL,
	[Categoria] [nvarchar](100) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioCompra] [money] NOT NULL,
	[PrecioVenta] [money] NOT NULL,
	[Estado] [nvarchar](100) NOT NULL,
	[FechaRegistro] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 30/04/2024 05:38:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[LoginName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[FirsName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[Cargo] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (1, 11285, N'Logitech f10', N'teclado qwerty', N'teclado', 50, 50000.0000, 90000.0000, N'disponible', N'30/04/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (2, 11286, N'Logitech j1', N'teclado qwerty', N'teclado', 10, 40000.0000, 80000.0000, N'agotado', N'30/04/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (3, 11287, N'Razer mini', N'mouse 6 botones', N'mouse', 5, 150000.0000, 250000.0000, N'disponible', N'30/04/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (4, 11288, N'Asus vivobook go', N'portatil 15.6" 6Gb intel core', N'computador', 10, 1400000.0000, 1600000.0000, N'disponible', N'2/05/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (5, 11289, N'Lenovo ideapad', N'portatil 14" 4Gb', N'computador', 10, 500000.0000, 686304.0000, N'disponible', N'10/05/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (6, 11290, N'Lenovo icn4020', N'portatil 14" 4Gb', N'computador', 5, 800000.0000, 969900.0000, N'disponible', N'30/06/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (7, 11291, N'Logitech f10', N'teclado qwerty', N'teclado', 50, 50000.0000, 90000.0000, N'disponible', N'24/05/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (8, 11292, N'Star tec', N'mouse alambrico', N'mouse', 5, 5500.0000, 6900.0000, N'agotado', N'20/07/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (9, 11293, N'Mouse HP ', N'mouse alambrico optico 100', N'mouse', 5, 20000.0000, 29900.0000, N'disponible', N'15/07/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (10, 11294, N'Telado basico', N'teclado basico usm Esebses', N'teclado', 5, 33500.0000, 37900.0000, N'disponible', N'4/08/2024')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [LoginName], [Password], [FirsName], [LastName], [Cargo], [Email]) VALUES (1, N'Jgazcon', N'PanConQueso', N'Jefferson', N'Gazcon', N'Administrator', N'Support@SystemAll.biz')
INSERT [dbo].[Users] ([UserID], [LoginName], [Password], [FirsName], [LastName], [Cargo], [Email]) VALUES (2, N'Daniel', N'admin', N'Lopez', N'Gomez', N'Recepcionista', N'AndresGomez@MyCompany.com')
INSERT [dbo].[Users] ([UserID], [LoginName], [Password], [FirsName], [LastName], [Cargo], [Email]) VALUES (3, N'jtlopez', N'clave', N'Kathrine', N'Smith', N'Recepcionista', N'KathySmith@MyCompany.com')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
/****** Object:  Index [UQ__Products__F6D2C3DB905D1BE1]    Script Date: 30/04/2024 05:38:37 p. m. ******/
ALTER TABLE [dbo].[Products] ADD UNIQUE NONCLUSTERED 
(
	[CodigoDeBarras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__DB8464FF3B3F675B]    Script Date: 30/04/2024 05:38:37 p. m. ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[LoginName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [SistemaDeUsuario] SET  READ_WRITE 
GO
