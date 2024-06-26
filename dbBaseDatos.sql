USE [master]
GO
/****** Object:  Database [SistemaDeUsuario]    Script Date: 31/05/2024 7:52:04 p. m. ******/
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
/****** Object:  Table [dbo].[DetalleVentas]    Script Date: 31/05/2024 7:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVentas](
	[DetalleVentaID] [int] IDENTITY(1,1) NOT NULL,
	[VentaID] [int] NULL,
	[ProductoID] [int] NULL,
	[Cantidad] [int] NULL,
	[PrecioVenta] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[DetalleVentaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 31/05/2024 7:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[Producto] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](100) NOT NULL,
	[Precio] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Total] [int] NOT NULL,
	[PrecioCompra] [decimal](18, 0) NULL,
	[FechaVenta] [datetime] NOT NULL,
	[NombreCliente] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 31/05/2024 7:52:04 p. m. ******/
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
/****** Object:  Table [dbo].[Users]    Script Date: 31/05/2024 7:52:04 p. m. ******/
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
/****** Object:  Table [dbo].[Ventas]    Script Date: 31/05/2024 7:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[VentaID] [int] IDENTITY(1,1) NOT NULL,
	[FechaRegistro] [datetime] NULL,
	[UserID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[VentaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Logitech f10', N'teclado qwerty', 90000, 5, 450000, CAST(50000 AS Decimal(18, 0)), CAST(N'2024-05-25T09:14:22.817' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Logitech f10', N'teclado qwerty', 90000, 12, 1080000, CAST(50000 AS Decimal(18, 0)), CAST(N'2024-05-25T09:14:22.817' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Asus vivobook go', N'portatil 15.6" 6Gb intel core', 1600000, 6, 9600000, CAST(1400000 AS Decimal(18, 0)), CAST(N'2024-05-25T11:01:06.317' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Mouse HP ', N'mouse alambrico optico 100', 29900, 2, 59800, CAST(20000 AS Decimal(18, 0)), CAST(N'2024-05-26T18:06:53.123' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Lenovo ideapad', N'portatil 14" 4Gb', 686304, 2, 1372608, CAST(500000 AS Decimal(18, 0)), CAST(N'2024-05-27T08:16:57.143' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Asus vivobook go', N'portatil 15.6" 6Gb intel core', 1600000, 1, 1600000, CAST(1400000 AS Decimal(18, 0)), CAST(N'2024-05-27T08:16:57.143' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Asus vivobook go', N'portatil 15.6" 6Gb intel core', 1600000, 1, 1600000, CAST(1400000 AS Decimal(18, 0)), CAST(N'2024-05-27T08:03:53.410' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Lenovo icn4020', N'portatil 14" 4Gb', 969900, 2, 1939800, CAST(800000 AS Decimal(18, 0)), CAST(N'2024-05-27T08:03:53.410' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Razer mini', N'mouse 6 botones', 250000, 3, 750000, CAST(150000 AS Decimal(18, 0)), CAST(N'2024-05-28T20:10:51.120' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'LibroDigital', N'Enseñansa', 1500000, 2, 3000000, CAST(1200000 AS Decimal(18, 0)), CAST(N'2024-05-27T08:30:40.353' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Lenovo ideapad', N'portatil 14" 4Gb', 686304, 2, 1372608, CAST(500000 AS Decimal(18, 0)), CAST(N'2024-05-27T08:30:40.353' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Laptop', N'Laptop de 15 pulgadas', 12000, 50, 600000, CAST(10000 AS Decimal(18, 0)), CAST(N'2024-01-05T10:15:30.000' AS DateTime), N'Juan Pérez')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Lenovo icn4020', N'portatil 14" 4Gb', 969900, 2, 1939800, CAST(800000 AS Decimal(18, 0)), CAST(N'2024-05-27T13:32:02.767' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Lenovo ideapad', N'portatil 14" 4Gb', 686304, 2, 1372608, CAST(500000 AS Decimal(18, 0)), CAST(N'2024-05-27T17:25:51.047' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Logitech f10', N'teclado qwerty', 90000, 3, 270000, CAST(50000 AS Decimal(18, 0)), CAST(N'2024-05-27T17:25:51.053' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Mouse HP ', N'mouse alambrico optico 100', 29900, 1, 29900, CAST(20000 AS Decimal(18, 0)), CAST(N'2024-05-27T17:25:51.053' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Razer mini', N'mouse 6 botones', 250000, 1, 250000, CAST(150000 AS Decimal(18, 0)), CAST(N'2024-05-27T17:25:51.057' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Razer mini', N'mouse 6 botones', 250000, 42, 10500000, CAST(150000 AS Decimal(18, 0)), CAST(N'2024-05-27T19:49:03.977' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'LibroDigital', N'Enseñansa', 1500000, 18, 27000000, CAST(1200000 AS Decimal(18, 0)), CAST(N'2024-05-27T19:52:11.440' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Lenovo icn4020', N'portatil 14" 4Gb', 969900, 2, 1939800, CAST(800000 AS Decimal(18, 0)), CAST(N'2024-05-27T19:54:14.620' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Lenovo icn4020', N'portatil 14" 4Gb', 969900, 2, 1939800, CAST(800000 AS Decimal(18, 0)), CAST(N'2024-05-27T20:18:36.823' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Lenovo ideapad', N'portatil 14" 4Gb', 686304, 2, 1372608, CAST(500000 AS Decimal(18, 0)), CAST(N'2024-05-27T20:18:36.823' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Asus vivobook go', N'portatil 15.6" 6Gb intel core', 1600000, 2, 3200000, CAST(1400000 AS Decimal(18, 0)), CAST(N'2024-05-27T20:26:50.933' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Lenovo icn4020', N'portatil 14" 4Gb', 969900, 2, 1939800, CAST(800000 AS Decimal(18, 0)), CAST(N'2024-05-27T20:26:50.933' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Lenovo ideapad', N'portatil 14" 4Gb', 686304, 2, 1372608, CAST(500000 AS Decimal(18, 0)), CAST(N'2024-05-27T20:26:50.933' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'LibroDigital', N'Enseñansa', 1500000, 3, 4500000, CAST(1200000 AS Decimal(18, 0)), CAST(N'2024-05-27T20:26:50.933' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'LibroDigital', N'Enseñansa', 1500000, 2, 3000000, CAST(1200000 AS Decimal(18, 0)), CAST(N'2024-05-27T20:30:27.153' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Asus vivobook go', N'portatil 15.6" 6Gb intel core', 1600000, 3, 4800000, CAST(1400000 AS Decimal(18, 0)), CAST(N'2024-05-27T20:31:27.780' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Mouse HP ', N'mouse alambrico optico 100', 29900, 2, 59800, CAST(20000 AS Decimal(18, 0)), CAST(N'2024-05-27T20:33:04.837' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Asus vivobook go', N'portatil 15.6" 6Gb intel core', 1600000, 2, 3200000, CAST(1400000 AS Decimal(18, 0)), CAST(N'2024-05-27T21:42:01.850' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Asus vivobook go', N'portatil 15.6" 6Gb intel core', 1600000, 2, 3200000, CAST(1400000 AS Decimal(18, 0)), CAST(N'2024-05-27T21:50:26.080' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Mouse HP ', N'mouse alambrico optico 100', 29900, 2, 59800, CAST(20000 AS Decimal(18, 0)), CAST(N'2024-05-27T22:00:59.117' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Razer mini', N'mouse 6 botones', 250000, 3, 750000, CAST(150000 AS Decimal(18, 0)), CAST(N'2024-05-27T22:00:59.127' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Logitech f10', N'teclado qwerty', 90000, 3, 270000, CAST(50000 AS Decimal(18, 0)), CAST(N'2024-05-27T22:02:27.963' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Logitech j1', N'teclado qwerty', 80000, 2, 160000, CAST(40000 AS Decimal(18, 0)), CAST(N'2024-05-27T22:02:27.967' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Razer mini', N'mouse 6 botones', 250000, 3, 750000, CAST(150000 AS Decimal(18, 0)), CAST(N'2024-05-28T07:42:54.257' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Star tec', N'mouse alambrico', 6900, 2, 13800, CAST(5500 AS Decimal(18, 0)), CAST(N'2024-05-28T07:42:54.257' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Asus vivobook go', N'portatil 15.6" 6Gb intel core', 1600000, 2, 3200000, CAST(1400000 AS Decimal(18, 0)), CAST(N'2024-05-28T08:35:15.230' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Lenovo icn4020', N'portatil 14" 4Gb', 969900, 4, 3879600, CAST(800000 AS Decimal(18, 0)), CAST(N'2024-05-28T08:37:16.687' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Lenovo ideapad', N'portatil 14" 4Gb', 686304, 3, 2058912, CAST(500000 AS Decimal(18, 0)), CAST(N'2024-05-28T08:37:16.687' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Asus vivobook go', N'portatil 15.6" 6Gb intel core', 1600000, 2, 3200000, CAST(1400000 AS Decimal(18, 0)), CAST(N'2024-05-28T08:56:54.333' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Asus vivobook go', N'portatil 15.6" 6Gb intel core', 1600000, 3, 4800000, CAST(1400000 AS Decimal(18, 0)), CAST(N'2024-05-28T20:49:03.170' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Asus vivobook go', N'portatil 15.6" 6Gb intel core', 1600000, 2, 3200000, CAST(1400000 AS Decimal(18, 0)), CAST(N'2024-05-28T21:10:47.860' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Lenovo icn4020', N'portatil 14" 4Gb', 969900, 4, 3879600, CAST(800000 AS Decimal(18, 0)), CAST(N'2024-05-28T20:49:03.180' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Lenovo ideapad', N'portatil 14" 4Gb', 686304, 3, 2058912, CAST(500000 AS Decimal(18, 0)), CAST(N'2024-05-28T20:49:03.180' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Mouse HP ', N'mouse alambrico optico 100', 29900, 2, 59800, CAST(20000 AS Decimal(18, 0)), CAST(N'2024-05-28T21:18:37.713' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Razer mini', N'mouse 6 botones', 250000, 2, 500000, CAST(150000 AS Decimal(18, 0)), CAST(N'2024-05-28T21:18:37.720' AS DateTime), N'Jefferson Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Smartphone', N'Smartphone de última generación', 15000, 60, 900000, CAST(12000 AS Decimal(18, 0)), CAST(N'2024-01-10T11:20:45.000' AS DateTime), N'María García')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Tablet', N'Tablet con pantalla HD', 11000, 45, 495000, CAST(8000 AS Decimal(18, 0)), CAST(N'2024-01-15T12:30:00.000' AS DateTime), N'Carlos López')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Monitor', N'Monitor de 27 pulgadas', 14000, 70, 980000, CAST(12000 AS Decimal(18, 0)), CAST(N'2024-01-20T13:40:15.000' AS DateTime), N'Laura Martínez')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Teclado', N'Teclado mecánico', 10500, 55, 577500, CAST(9000 AS Decimal(18, 0)), CAST(N'2024-01-25T14:50:30.000' AS DateTime), N'Ana Rodríguez')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Ratón', N'Ratón inalámbrico', 13000, 65, 845000, CAST(11000 AS Decimal(18, 0)), CAST(N'2024-02-05T15:00:45.000' AS DateTime), N'José Sánchez')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Impresora', N'Impresora multifuncional', 16000, 50, 800000, CAST(14000 AS Decimal(18, 0)), CAST(N'2024-02-10T16:10:00.000' AS DateTime), N'Lucía Fernández')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Auriculares', N'Auriculares con cancelación de ruido', 12500, 60, 750000, CAST(10000 AS Decimal(18, 0)), CAST(N'2024-02-15T17:20:15.000' AS DateTime), N'Miguel Gómez')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Altavoces', N'Altavoces Bluetooth', 15000, 70, 1050000, CAST(12000 AS Decimal(18, 0)), CAST(N'2024-02-20T18:30:30.000' AS DateTime), N'Isabel Ramírez')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Webcam', N'Webcam HD', 11500, 55, 632500, CAST(9500 AS Decimal(18, 0)), CAST(N'2024-02-25T19:40:45.000' AS DateTime), N'David Díaz')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Router', N'Router Wi-Fi 6', 14000, 50, 700000, CAST(11000 AS Decimal(18, 0)), CAST(N'2024-03-05T20:50:00.000' AS DateTime), N'Sofía Torres')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Disco Duro', N'Disco duro externo 1TB', 15000, 60, 900000, CAST(12000 AS Decimal(18, 0)), CAST(N'2024-03-10T21:00:15.000' AS DateTime), N'Pablo Vázquez')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Memoria USB', N'Memoria USB 64GB', 10000, 75, 750000, CAST(8000 AS Decimal(18, 0)), CAST(N'2024-03-15T22:10:30.000' AS DateTime), N'Clara Ruiz')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Silla', N'Silla ergonómica', 12000, 55, 660000, CAST(10000 AS Decimal(18, 0)), CAST(N'2024-03-20T23:20:45.000' AS DateTime), N'Jorge Castillo')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Escritorio', N'Escritorio de oficina', 18000, 50, 900000, CAST(15000 AS Decimal(18, 0)), CAST(N'2024-03-25T08:30:00.000' AS DateTime), N'Teresa Morales')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Proyector', N'Proyector Full HD', 20000, 60, 1200000, CAST(16000 AS Decimal(18, 0)), CAST(N'2024-04-05T09:40:15.000' AS DateTime), N'Raúl Ortiz')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Cámara', N'Cámara digital', 21000, 45, 945000, CAST(18000 AS Decimal(18, 0)), CAST(N'2024-04-10T10:50:30.000' AS DateTime), N'Natalia Mendoza')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Smartwatch', N'Reloj inteligente', 15000, 70, 1050000, CAST(13000 AS Decimal(18, 0)), CAST(N'2024-04-15T11:00:45.000' AS DateTime), N'Luis Herrera')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Drone', N'Drone con cámara 4K', 24000, 55, 1320000, CAST(20000 AS Decimal(18, 0)), CAST(N'2024-04-20T12:10:00.000' AS DateTime), N'Paula Navarro')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Consola', N'Consola de videojuegos', 22000, 65, 1430000, CAST(18000 AS Decimal(18, 0)), CAST(N'2024-04-25T13:20:15.000' AS DateTime), N'Andrés Campos')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Laptop', N'Laptop de 15 pulgadas', 12000, 50, 600000, CAST(10000 AS Decimal(18, 0)), CAST(N'2024-05-05T10:15:30.000' AS DateTime), N'Gabriela Vega')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Smartphone', N'Smartphone de última generación', 15000, 60, 900000, CAST(12000 AS Decimal(18, 0)), CAST(N'2024-05-10T11:20:45.000' AS DateTime), N'Adrián Castro')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Tablet', N'Tablet con pantalla HD', 11000, 45, 495000, CAST(8000 AS Decimal(18, 0)), CAST(N'2024-05-15T12:30:00.000' AS DateTime), N'Elena Silva')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Monitor', N'Monitor de 27 pulgadas', 14000, 70, 980000, CAST(12000 AS Decimal(18, 0)), CAST(N'2024-05-20T13:40:15.000' AS DateTime), N'Fernando Delgado')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Teclado', N'Teclado mecánico', 10500, 55, 577500, CAST(9000 AS Decimal(18, 0)), CAST(N'2024-05-25T14:50:30.000' AS DateTime), N'Valeria Ramos')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Ratón', N'Ratón inalámbrico', 13000, 65, 845000, CAST(11000 AS Decimal(18, 0)), CAST(N'2024-06-05T15:00:45.000' AS DateTime), N'Alejandro Gómez')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Impresora', N'Impresora multifuncional', 16000, 50, 800000, CAST(14000 AS Decimal(18, 0)), CAST(N'2024-06-10T16:10:00.000' AS DateTime), N'Andrea Vargas')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Auriculares', N'Auriculares con cancelación de ruido', 12500, 60, 750000, CAST(10000 AS Decimal(18, 0)), CAST(N'2024-06-15T17:20:15.000' AS DateTime), N'Patricia Soto')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Altavoces', N'Altavoces Bluetooth', 15000, 70, 1050000, CAST(12000 AS Decimal(18, 0)), CAST(N'2024-06-20T18:30:30.000' AS DateTime), N'Iván Muñoz')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Webcam', N'Webcam HD', 11500, 55, 632500, CAST(9500 AS Decimal(18, 0)), CAST(N'2024-06-25T19:40:45.000' AS DateTime), N'Daniela Rojas')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Router', N'Router Wi-Fi 6', 14000, 50, 700000, CAST(11000 AS Decimal(18, 0)), CAST(N'2024-07-05T20:50:00.000' AS DateTime), N'Martín Peña')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Disco Duro', N'Disco duro externo 1TB', 15000, 60, 900000, CAST(12000 AS Decimal(18, 0)), CAST(N'2024-07-10T21:00:15.000' AS DateTime), N'Sandra Cruz')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Memoria USB', N'Memoria USB 64GB', 10000, 75, 750000, CAST(8000 AS Decimal(18, 0)), CAST(N'2024-07-15T22:10:30.000' AS DateTime), N'Emilio Morales')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Silla', N'Silla ergonómica', 12000, 55, 660000, CAST(10000 AS Decimal(18, 0)), CAST(N'2024-07-20T23:20:45.000' AS DateTime), N'Lorena Álvarez')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Escritorio', N'Escritorio de oficina', 18000, 50, 900000, CAST(15000 AS Decimal(18, 0)), CAST(N'2024-07-25T08:30:00.000' AS DateTime), N'Francisco Gil')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Proyector', N'Proyector Full HD', 20000, 60, 1200000, CAST(16000 AS Decimal(18, 0)), CAST(N'2024-08-05T09:40:15.000' AS DateTime), N'Manuel López')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Cámara', N'Cámara digital', 21000, 45, 945000, CAST(18000 AS Decimal(18, 0)), CAST(N'2024-08-10T10:50:30.000' AS DateTime), N'Cristina Guerrero')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Smartwatch', N'Reloj inteligente', 15000, 70, 1050000, CAST(13000 AS Decimal(18, 0)), CAST(N'2024-08-15T11:00:45.000' AS DateTime), N'Oscar Ortiz')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Drone', N'Drone con cámara 4K', 24000, 55, 1320000, CAST(20000 AS Decimal(18, 0)), CAST(N'2024-08-20T12:10:00.000' AS DateTime), N'Silvia Flores')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Consola', N'Consola de videojuegos', 22000, 65, 1430000, CAST(18000 AS Decimal(18, 0)), CAST(N'2024-08-25T13:20:15.000' AS DateTime), N'Roberto Ramos')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Laptop', N'Laptop de 15 pulgadas', 12000, 50, 600000, CAST(10000 AS Decimal(18, 0)), CAST(N'2024-09-05T10:15:30.000' AS DateTime), N'Miguel Ángel Herrera')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Smartphone', N'Smartphone de última generación', 15000, 60, 900000, CAST(12000 AS Decimal(18, 0)), CAST(N'2024-09-10T11:20:45.000' AS DateTime), N'Beatriz Méndez')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Tablet', N'Tablet con pantalla HD', 11000, 45, 495000, CAST(8000 AS Decimal(18, 0)), CAST(N'2024-09-15T12:30:00.000' AS DateTime), N'Vicente Guzmán')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Monitor', N'Monitor de 27 pulgadas', 14000, 70, 980000, CAST(12000 AS Decimal(18, 0)), CAST(N'2024-09-20T13:40:15.000' AS DateTime), N'Camila León')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Teclado', N'Teclado mecánico', 10500, 55, 577500, CAST(9000 AS Decimal(18, 0)), CAST(N'2024-09-25T14:50:30.000' AS DateTime), N'Sebastián Romero')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Ratón', N'Ratón inalámbrico', 13000, 65, 845000, CAST(11000 AS Decimal(18, 0)), CAST(N'2024-10-05T15:00:45.000' AS DateTime), N'Marcos Aguilar')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Impresora', N'Impresora multifuncional', 16000, 50, 800000, CAST(14000 AS Decimal(18, 0)), CAST(N'2024-10-10T16:10:00.000' AS DateTime), N'Isabel Fernández')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Auriculares', N'Auriculares con cancelación de ruido', 12500, 60, 750000, CAST(10000 AS Decimal(18, 0)), CAST(N'2024-10-15T17:20:15.000' AS DateTime), N'Julio Cortés')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Altavoces', N'Altavoces Bluetooth', 15000, 70, 1050000, CAST(12000 AS Decimal(18, 0)), CAST(N'2024-10-20T18:30:30.000' AS DateTime), N'Amalia Ruiz')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Webcam', N'Webcam HD', 11500, 55, 632500, CAST(9500 AS Decimal(18, 0)), CAST(N'2024-10-25T19:40:45.000' AS DateTime), N'Natalia Peña')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Router', N'Router Wi-Fi 6', 14000, 50, 700000, CAST(11000 AS Decimal(18, 0)), CAST(N'2024-11-05T20:50:00.000' AS DateTime), N'Ernesto Gutiérrez')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Disco Duro', N'Disco duro externo 1TB', 15000, 60, 900000, CAST(12000 AS Decimal(18, 0)), CAST(N'2024-11-10T21:00:15.000' AS DateTime), N'Alicia Paredes')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Memoria USB', N'Memoria USB 64GB', 10000, 75, 750000, CAST(8000 AS Decimal(18, 0)), CAST(N'2024-11-15T22:10:30.000' AS DateTime), N'Joaquín Maldonado')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Silla', N'Silla ergonómica', 12000, 55, 660000, CAST(10000 AS Decimal(18, 0)), CAST(N'2024-11-20T23:20:45.000' AS DateTime), N'Estela Lara')
GO
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Escritorio', N'Escritorio de oficina', 18000, 50, 900000, CAST(15000 AS Decimal(18, 0)), CAST(N'2024-11-25T08:30:00.000' AS DateTime), N'Romina Medina')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Proyector', N'Proyector Full HD', 20000, 60, 1200000, CAST(16000 AS Decimal(18, 0)), CAST(N'2024-12-05T09:40:15.000' AS DateTime), N'Rafael Serrano')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Cámara', N'Cámara digital', 21000, 45, 945000, CAST(18000 AS Decimal(18, 0)), CAST(N'2024-12-10T10:50:30.000' AS DateTime), N'Mercedes Ortega')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Smartwatch', N'Reloj inteligente', 15000, 70, 1050000, CAST(13000 AS Decimal(18, 0)), CAST(N'2024-12-15T11:00:45.000' AS DateTime), N'Fabián Pacheco')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Drone', N'Drone con cámara 4K', 24000, 55, 1320000, CAST(20000 AS Decimal(18, 0)), CAST(N'2024-12-20T12:10:00.000' AS DateTime), N'Cristina Ramos')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Consola', N'Consola de videojuegos', 22000, 65, 1430000, CAST(18000 AS Decimal(18, 0)), CAST(N'2024-12-25T13:20:15.000' AS DateTime), N'Leonor Villalobos')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Mouse HP ', N'mouse alambrico optico 100', 29900, 1, 29900, CAST(20000 AS Decimal(18, 0)), CAST(N'2024-05-29T15:53:29.197' AS DateTime), N'Jefferson  Gazcon')
INSERT [dbo].[Factura] ([Producto], [Descripcion], [Precio], [Cantidad], [Total], [PrecioCompra], [FechaVenta], [NombreCliente]) VALUES (N'Razer mini', N'mouse 6 botones', 250000, 3, 750000, CAST(150000 AS Decimal(18, 0)), CAST(N'2024-05-31T19:10:21.257' AS DateTime), N'Jefferson  Gazcon')
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (1, 11285, N'Logitech f10', N'teclado qwerty', N'teclado', 37, 50000.0000, 90000.0000, N'disponible', N'30/04/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (2, 11286, N'Logitech j1', N'teclado qwerty', N'teclado', 4, 40000.0000, 80000.0000, N'agotado', N'30/04/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (3, 11287, N'Razer mini', N'mouse 6 botones', N'mouse', 36, 150000.0000, 250000.0000, N'disponible', N'30/04/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (4, 11288, N'Asus vivobook go', N'portatil 15.6" 6Gb intel core', N'computador', 12, 1400000.0000, 1600000.0000, N'disponible', N'2/05/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (5, 11289, N'Lenovo ideapad', N'portatil 14" 4Gb', N'computador', 14, 500000.0000, 686304.0000, N'disponible', N'10/05/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (6, 11290, N'Lenovo icn4020', N'portatil 14" 4Gb', N'computador', 59, 800000.0000, 969900.0000, N'disponible', N'30/06/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (7, 11291, N'Logitech f10', N'teclado qwerty', N'teclado', 23, 50000.0000, 90000.0000, N'disponible', N'24/05/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (8, 11292, N'Star tec', N'mouse alambrico', N'mouse', 58, 5500.0000, 6900.0000, N'agotado', N'20/07/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (9, 11293, N'Mouse HP ', N'mouse alambrico optico 100', N'mouse', 13, 20000.0000, 29900.0000, N'disponible', N'15/07/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (10, 11294, N'Telado basico', N'teclado basico usm Esebses', N'teclado', 58, 33500.0000, 37900.0000, N'disponible', N'4/08/2024')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (11, 979555, N'LibroDigital', N'Enseñansa', N'Tablet', 15, 1200000.0000, 1500000.0000, N'Registrado', N'8/05/2024 2:01:40 p. m.')
INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (12, 585455, N'Teglado R', N'teclado lec', N'teclado', 32, 60000.0000, 75000.0000, N'Disponible', N'27/05/2024 4:02:29 p. m.')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [LoginName], [Password], [FirsName], [LastName], [Cargo], [Email]) VALUES (1, N'Jgazcon', N'123456', N'Jefferson', N'Gazcon', N'Administrador', N'gazconjefferson@gmail.com')
INSERT [dbo].[Users] ([UserID], [LoginName], [Password], [FirsName], [LastName], [Cargo], [Email]) VALUES (2, N'Daniel', N'admin', N'Lopez', N'Gomez', N'Recepcionista', N'gomez.daniel.1001joseumar@gmail.com')
INSERT [dbo].[Users] ([UserID], [LoginName], [Password], [FirsName], [LastName], [Cargo], [Email]) VALUES (3, N'jtlopez', N'clave', N'Lopez', N'Pinzon', N'Administrador', N'josetlopez@unicesar.edu.co')
INSERT [dbo].[Users] ([UserID], [LoginName], [Password], [FirsName], [LastName], [Cargo], [Email]) VALUES (4, N'Roberto', N'desayuno', N'jade', N'herrera', N'Cliente', N'alvarogazconcardenas@gmail.com')
INSERT [dbo].[Users] ([UserID], [LoginName], [Password], [FirsName], [LastName], [Cargo], [Email]) VALUES (5, N'Prueva', N'clave', N'Nose', N'Tomaz', N'Cliente', N'josetlopez@unicesar.edu.co')
INSERT [dbo].[Users] ([UserID], [LoginName], [Password], [FirsName], [LastName], [Cargo], [Email]) VALUES (6, N'Jao', N'amigo01', N'Jonathan', N'rincon', N'Administrador', N'jao*jefferson@gmail.com')
INSERT [dbo].[Users] ([UserID], [LoginName], [Password], [FirsName], [LastName], [Cargo], [Email]) VALUES (7, N'Jose12', N'computador', N'perito', N'petrico', N'Cliente', N'so.435@466')
INSERT [dbo].[Users] ([UserID], [LoginName], [Password], [FirsName], [LastName], [Cargo], [Email]) VALUES (8, N'17karma', N'123', N'Jao', N'Gomez', N'Cliente', N'as@gmail.com')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
/****** Object:  Index [UQ__Products__F6D2C3DB0610C548]    Script Date: 31/05/2024 7:52:04 p. m. ******/
ALTER TABLE [dbo].[Products] ADD UNIQUE NONCLUSTERED 
(
	[CodigoDeBarras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__Products__F6D2C3DBA3B38708]    Script Date: 31/05/2024 7:52:04 p. m. ******/
ALTER TABLE [dbo].[Products] ADD UNIQUE NONCLUSTERED 
(
	[CodigoDeBarras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__Products__F6D2C3DBC1D2052D]    Script Date: 31/05/2024 7:52:04 p. m. ******/
ALTER TABLE [dbo].[Products] ADD UNIQUE NONCLUSTERED 
(
	[CodigoDeBarras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__DB8464FF095FDFF1]    Script Date: 31/05/2024 7:52:04 p. m. ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[LoginName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__DB8464FF365E14DE]    Script Date: 31/05/2024 7:52:04 p. m. ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[LoginName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__DB8464FF38A4064A]    Script Date: 31/05/2024 7:52:04 p. m. ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[LoginName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__DB8464FF4A0C5390]    Script Date: 31/05/2024 7:52:04 p. m. ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[LoginName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__DB8464FFC6BB4DED]    Script Date: 31/05/2024 7:52:04 p. m. ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[LoginName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Factura] ADD  DEFAULT (getdate()) FOR [FechaVenta]
GO
ALTER TABLE [dbo].[DetalleVentas]  WITH CHECK ADD FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Products] ([ProductoID])
GO
ALTER TABLE [dbo].[DetalleVentas]  WITH CHECK ADD FOREIGN KEY([VentaID])
REFERENCES [dbo].[Ventas] ([VentaID])
GO
/****** Object:  StoredProcedure [dbo].[Grafico]    Script Date: 31/05/2024 7:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Grafico]
@catidadInvertida decimal out,
@ganancia decimal out,
@cantidadDeClientes int out,
@numeroDeCategorias int out,
@cantidadDeProductos int out
AS
set @catidadInvertida = (SELECT SUM(PrecioCompra * Cantidad) AS CantidadInvertida FROM Factura);

set @ganancia = (SELECT SUM((Precio-PrecioCompra)*Cantidad) AS Ganancia From Factura);

set @cantidadDeClientes = (Select COUNT(NombreCliente) AS CantidaDeClientes From Factura);

set @numeroDeCategorias = (SELECT COUNT(DISTINCT Categoria) AS NumeroDeCategorias FROM Products);

set @cantidadDeProductos = (Select Count(DISTINCT Producto) AS CantidadDeProductos From Factura);
GO
/****** Object:  StoredProcedure [dbo].[ListaProductos]    Script Date: 31/05/2024 7:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListaProductos] 
@inicio INT, @final INT
as
declare @TablaAux table
(
ProductoID INT,
CodigoDeBarras INT,
Nombre NVARCHAR (100),
DescripcionProducto NVARCHAR (250),
Categoria NVARCHAR (100),
Cantidad INT,
PrecioCompra MONEY,
PrecioVenta MONEY,
Estado NVARCHAR (100),
FechaRegistro NVARCHAR (100)
)
INSERT INTO @TablaAux (ProductoID, CodigoDeBarras, Nombre, DescripcionProducto, Categoria, Cantidad, PrecioCompra, PrecioVenta, Estado, FechaRegistro) SELECT ROW_NUMBER() over (order by ProductoID asc) ProductoID, CodigoDeBarras, Nombre, DescripcionProducto, Categoria, Cantidad, PrecioCompra, PrecioVenta, Estado, FechaRegistro FROM Products
SELECT COUNT(*) as cantidad FROM @TablaAux
SELECT * FROM @TablaAux WHERE ProductoID between @inicio and @final
GO
/****** Object:  StoredProcedure [dbo].[ListasUsuarios]    Script Date: 31/05/2024 7:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ListasUsuarios] 
@inicio int, @final int
as
declare @TablaAux table
(
UserID int,
LoginName nvarchar(100),
Password nvarchar(100),
FirsName nvarchar(100),
LastName nvarchar(100),
Cargo nvarchar(100),
Email nvarchar(150)
)
INSERT INTO @TablaAux (UserID, LoginName, Password, FirsName, LastName, Cargo, Email) SELECT ROW_NUMBER() over (order by UserID asc) UserID, LoginName, Password, FirsName, LastName, Cargo, Email FROM Users
SELECT COUNT(*) as cantidad FROM @TablaAux
SELECT * FROM @TablaAux WHERE UserID between @inicio and @final
GO
/****** Object:  StoredProcedure [dbo].[ProductosVendidos]    Script Date: 31/05/2024 7:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProductosVendidos]
as
select Producto, COUNT(Producto)AS CantidadDeVecesVendidos from Factura group by Producto order by COUNT(2)
GO
/****** Object:  StoredProcedure [dbo].[SP_MOSTRARTABLACLIENTES]    Script Date: 31/05/2024 7:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MOSTRARTABLACLIENTES]
AS
SELECT *FROM Users
GO
/****** Object:  StoredProcedure [dbo].[TopDeProductos]    Script Date: 31/05/2024 7:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TopDeProductos]
as
---Produstos mas comprados ;) andres es flojo
select top 5 Producto, COUNT(Producto)AS MasVendido from Factura group by Producto order by COUNT(2) desc 

---Productos menos vendidos :,( lopez es tonto
select top 5 Producto, COUNT(Producto)AS ManesVendido from Factura group by Producto order by COUNT(2) 
GO
/****** Object:  StoredProcedure [dbo].[TopDeProductosMenosPreferidos]    Script Date: 31/05/2024 7:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TopDeProductosMenosPreferidos]
as
---Productos menos vendidos :,( lopez es tonto
select top 5 Producto, COUNT(Producto)AS MenosVendido from Factura group by Producto order by COUNT(2) 
GO
/****** Object:  StoredProcedure [dbo].[TopDeProductosPreferidos]    Script Date: 31/05/2024 7:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TopDeProductosPreferidos]
as
---Produstos mas comprados ;) andres es flojo
select top 5 Producto, COUNT(Producto)AS MasVendido from Factura group by Producto order by COUNT(2) desc 
GO
USE [master]
GO
ALTER DATABASE [SistemaDeUsuario] SET  READ_WRITE 
GO
