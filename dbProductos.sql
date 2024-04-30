﻿{"metadata":{"kernel_spec":{"name":"SQL","language":"sql","display_name":"SQL"},"language_info":{"name":"sql","version":""}},"nbformat":4,"nbformat_minor":2,"cells":[{"cell_type":"markdown","source":["# [SistemaDeUsuario]"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']","object_type":"Database"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["USE [master]\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']","object_type":"Database"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["/****** Object:  Database [SistemaDeUsuario]    Script Date: 30/04/2024 05:31:04 p. m. ******/\r\nCREATE DATABASE [SistemaDeUsuario]\r\n CONTAINMENT = NONE\r\n ON  PRIMARY \r\n( NAME = N'SistemaDeUsuario', FILENAME = N'C:\\Program Files\\Microsoft SQL Server\\MSSQL16.SQLEXPRESS\\MSSQL\\DATA\\SistemaDeUsuario.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )\r\n LOG ON \r\n( NAME = N'SistemaDeUsuario_log', FILENAME = N'C:\\Program Files\\Microsoft SQL Server\\MSSQL16.SQLEXPRESS\\MSSQL\\DATA\\SistemaDeUsuario_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )\r\n WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF\r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET COMPATIBILITY_LEVEL = 160\r\n","GO\r\n","IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))\r\nbegin\r\nEXEC [SistemaDeUsuario].[dbo].[sp_fulltext_database] @action = 'enable'\r\nend\r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET ANSI_NULL_DEFAULT OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET ANSI_NULLS OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET ANSI_PADDING OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET ANSI_WARNINGS OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET ARITHABORT OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET AUTO_CLOSE ON \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET AUTO_SHRINK OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET AUTO_UPDATE_STATISTICS ON \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET CURSOR_CLOSE_ON_COMMIT OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET CURSOR_DEFAULT  GLOBAL \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET CONCAT_NULL_YIELDS_NULL OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET NUMERIC_ROUNDABORT OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET QUOTED_IDENTIFIER OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET RECURSIVE_TRIGGERS OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET  ENABLE_BROKER \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET DATE_CORRELATION_OPTIMIZATION OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET TRUSTWORTHY OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET ALLOW_SNAPSHOT_ISOLATION OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET PARAMETERIZATION SIMPLE \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET READ_COMMITTED_SNAPSHOT OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET HONOR_BROKER_PRIORITY OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET RECOVERY SIMPLE \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET  MULTI_USER \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET PAGE_VERIFY CHECKSUM  \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET DB_CHAINING OFF \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET TARGET_RECOVERY_TIME = 60 SECONDS \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET DELAYED_DURABILITY = DISABLED \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET ACCELERATED_DATABASE_RECOVERY = OFF  \r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET QUERY_STORE = ON\r\n","GO\r\n","ALTER DATABASE [SistemaDeUsuario] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']","object_type":"Database"}},{"cell_type":"markdown","source":["# [dbo].[Products]"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']/Table[@Name='Products' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["USE [SistemaDeUsuario]\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']/Table[@Name='Products' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["/****** Object:  Table [dbo].[Products]    Script Date: 30/04/2024 05:31:04 p. m. ******/\r\nSET ANSI_NULLS ON\r\n","GO\r\n","SET QUOTED_IDENTIFIER ON\r\n","GO\r\n","CREATE TABLE [dbo].[Products](\r\n\t[ProductoID] [int] IDENTITY(1,1) NOT NULL,\r\n\t[CodigoDeBarras] [int] NOT NULL,\r\n\t[Nombre] [nvarchar](100) NOT NULL,\r\n\t[DescripcionProducto] [nvarchar](250) NOT NULL,\r\n\t[Categoria] [nvarchar](100) NOT NULL,\r\n\t[Cantidad] [int] NOT NULL,\r\n\t[PrecioCompra] [money] NOT NULL,\r\n\t[PrecioVenta] [money] NOT NULL,\r\n\t[Estado] [nvarchar](100) NOT NULL,\r\n\t[FechaRegistro] [nvarchar](100) NOT NULL,\r\nPRIMARY KEY CLUSTERED \r\n(\r\n\t[ProductoID] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]\r\n) ON [PRIMARY]\r\nGO\r\n"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']/Table[@Name='Products' and @Schema='dbo']","object_type":"Table"}},{"cell_type":"markdown","source":["# [dbo].[Users]"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']/Table[@Name='Users' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["/****** Object:  Table [dbo].[Users]    Script Date: 30/04/2024 05:31:04 p. m. ******/\r\nSET ANSI_NULLS ON\r\n","GO\r\n","SET QUOTED_IDENTIFIER ON\r\n","GO\r\n","CREATE TABLE [dbo].[Users](\r\n\t[UserID] [int] IDENTITY(1,1) NOT NULL,\r\n\t[LoginName] [nvarchar](100) NOT NULL,\r\n\t[Password] [nvarchar](100) NOT NULL,\r\n\t[FirsName] [nvarchar](100) NOT NULL,\r\n\t[LastName] [nvarchar](100) NOT NULL,\r\n\t[Cargo] [nvarchar](100) NOT NULL,\r\n\t[Email] [nvarchar](150) NOT NULL,\r\nPRIMARY KEY CLUSTERED \r\n(\r\n\t[UserID] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]\r\n) ON [PRIMARY]\r\nGO\r\n"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']/Table[@Name='Users' and @Schema='dbo']","object_type":"Table"}},{"cell_type":"markdown","source":["# [dbo].[Products]"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']/Table[@Name='Products' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["SET IDENTITY_INSERT [dbo].[Products] ON \r\n","INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (1, 11285, N'Logitech f10', N'teclado qwerty', N'teclado', 50, 50000.0000, 90000.0000, N'disponible', N'30/04/2024')\r\n","INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (2, 11286, N'Logitech j1', N'teclado qwerty', N'teclado', 10, 40000.0000, 80000.0000, N'agotado', N'30/04/2024')\r\n","INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (3, 11287, N'Razer mini', N'mouse 6 botones', N'mouse', 5, 150000.0000, 250000.0000, N'disponible', N'30/04/2024')\r\n","INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (4, 11288, N'Asus vivobook go', N'portatil 15.6\" 6Gb intel core', N'computador', 10, 1400000.0000, 1600000.0000, N'disponible', N'2/05/2024')\r\n","INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (5, 11289, N'Lenovo ideapad', N'portatil 14\" 4Gb', N'computador', 10, 500000.0000, 686304.0000, N'disponible', N'10/05/2024')\r\n","INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (6, 11290, N'Lenovo icn4020', N'portatil 14\" 4Gb', N'computador', 5, 800000.0000, 969900.0000, N'disponible', N'30/06/2024')\r\n","INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (7, 11291, N'Logitech f10', N'teclado qwerty', N'teclado', 50, 50000.0000, 90000.0000, N'disponible', N'24/05/2024')\r\n","INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (8, 11292, N'Star tec', N'mouse alambrico', N'mouse', 5, 5500.0000, 6900.0000, N'agotado', N'20/07/2024')\r\n","INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (9, 11293, N'Mouse HP ', N'mouse alambrico optico 100', N'mouse', 5, 20000.0000, 29900.0000, N'disponible', N'15/07/2024')\r\n","INSERT [dbo].[Products] ([ProductoID], [CodigoDeBarras], [Nombre], [DescripcionProducto], [Categoria], [Cantidad], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (10, 11294, N'Telado basico', N'teclado basico usm Esebses', N'teclado', 5, 33500.0000, 37900.0000, N'disponible', N'4/08/2024')\r\n","SET IDENTITY_INSERT [dbo].[Products] OFF\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']/Table[@Name='Products' and @Schema='dbo']","object_type":"Table"}},{"cell_type":"markdown","source":["# [dbo].[Users]"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']/Table[@Name='Users' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["SET IDENTITY_INSERT [dbo].[Users] ON \r\n","INSERT [dbo].[Users] ([UserID], [LoginName], [Password], [FirsName], [LastName], [Cargo], [Email]) VALUES (1, N'Jgazcon', N'PanConQueso', N'Jefferson', N'Gazcon', N'Administrator', N'Support@SystemAll.biz')\r\n","INSERT [dbo].[Users] ([UserID], [LoginName], [Password], [FirsName], [LastName], [Cargo], [Email]) VALUES (2, N'Daniel', N'admin', N'Lopez', N'Gomez', N'Recepcionista', N'AndresGomez@MyCompany.com')\r\n","INSERT [dbo].[Users] ([UserID], [LoginName], [Password], [FirsName], [LastName], [Cargo], [Email]) VALUES (3, N'jtlopez', N'clave', N'Kathrine', N'Smith', N'Recepcionista', N'KathySmith@MyCompany.com')\r\n","SET IDENTITY_INSERT [dbo].[Users] OFF\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']/Table[@Name='Users' and @Schema='dbo']","object_type":"Table"}},{"cell_type":"markdown","source":["# [UQ__Products__F6D2C3DB905D1BE1]"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']/Table[@Name='Products' and @Schema='dbo']/Index[@Name='UQ__Products__F6D2C3DB905D1BE1']","object_type":"Index"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["/****** Object:  Index [UQ__Products__F6D2C3DB905D1BE1]    Script Date: 30/04/2024 05:31:04 p. m. ******/\r\nALTER TABLE [dbo].[Products] ADD UNIQUE NONCLUSTERED \r\n(\r\n\t[CodigoDeBarras] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']/Table[@Name='Products' and @Schema='dbo']/Index[@Name='UQ__Products__F6D2C3DB905D1BE1']","object_type":"Index"}},{"cell_type":"markdown","source":["# [UQ__Users__DB8464FF3B3F675B]"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']/Table[@Name='Users' and @Schema='dbo']/Index[@Name='UQ__Users__DB8464FF3B3F675B']","object_type":"Index"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["SET ANSI_PADDING ON\r\nGO\r\n","/****** Object:  Index [UQ__Users__DB8464FF3B3F675B]    Script Date: 30/04/2024 05:31:04 p. m. ******/\r\nALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED \r\n(\r\n\t[LoginName] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']/Table[@Name='Users' and @Schema='dbo']/Index[@Name='UQ__Users__DB8464FF3B3F675B']","object_type":"Index"}},{"cell_type":"markdown","source":["# [SistemaDeUsuario]"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']","object_type":"Database"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["USE [master]\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']","object_type":"Database"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["ALTER DATABASE [SistemaDeUsuario] SET  READ_WRITE \r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='DESKTOP-S55V9U6\\SQLEXPRESS']/Database[@Name='SistemaDeUsuario']","object_type":"Database"}}]}