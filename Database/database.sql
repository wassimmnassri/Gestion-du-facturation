USE [master]
GO
/****** Object:  Database [DB_GestionFacture]    Script Date: 20/09/2025 21:43:45 ******/
CREATE DATABASE [DB_GestionFacture]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_GestionFacture', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DB_GestionFacture.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_GestionFacture_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DB_GestionFacture_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DB_GestionFacture] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_GestionFacture].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_GestionFacture] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_GestionFacture] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_GestionFacture] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_GestionFacture] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_GestionFacture] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET RECOVERY FULL 
GO
ALTER DATABASE [DB_GestionFacture] SET  MULTI_USER 
GO
ALTER DATABASE [DB_GestionFacture] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_GestionFacture] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_GestionFacture] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_GestionFacture] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_GestionFacture] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_GestionFacture] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DB_GestionFacture] SET QUERY_STORE = ON
GO
ALTER DATABASE [DB_GestionFacture] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DB_GestionFacture]
GO
/****** Object:  Table [dbo].[Article]    Script Date: 20/09/2025 21:43:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Article](
	[Code_Article] [int] IDENTITY(1,1) NOT NULL,
	[Nom_Article] [varchar](100) NOT NULL,
	[Qte_Stock] [int] NOT NULL,
	[PUHTVA] [decimal](10, 2) NOT NULL,
	[TVA] [decimal](5, 2) NOT NULL,
	[Creer_Par] [varchar](50) NULL,
	[Date_Creation] [datetime] NULL,
	[Modifier_Par] [varchar](50) NULL,
	[Date_Modification] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Code_Article] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 20/09/2025 21:43:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Code_Client] [int] IDENTITY(1,1) NOT NULL,
	[Nom_Prenom] [varchar](100) NOT NULL,
	[Matricule_Fiscale] [varchar](50) NULL,
	[Adresse] [varchar](255) NULL,
	[Num_Telephone] [varchar](20) NULL,
	[Creer_Par] [varchar](50) NULL,
	[Date_Creation] [datetime] NULL,
	[Modifier_Par] [varchar](50) NULL,
	[Date_Modification] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Code_Client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facture]    Script Date: 20/09/2025 21:43:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facture](
	[Num_Facture] [int] IDENTITY(1,1) NOT NULL,
	[Date_Facture] [date] NOT NULL,
	[Code_Client] [int] NOT NULL,
	[Total_HTVA] [decimal](10, 2) NOT NULL,
	[Montant_TVA_Facture] [decimal](10, 2) NOT NULL,
	[Montant_HTVA_Facture] [decimal](10, 2) NOT NULL,
	[Droit_Timbre] [decimal](10, 2) NULL,
	[Creer_Par] [varchar](50) NULL,
	[Date_Creation] [datetime] NULL,
	[Modifier_Par] [varchar](50) NULL,
	[Date_Modification] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Num_Facture] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ligne_Facture]    Script Date: 20/09/2025 21:43:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ligne_Facture](
	[Num_Facture] [int] NOT NULL,
	[Code_Article] [int] NOT NULL,
	[Qte_Vendu] [int] NOT NULL,
	[Remise] [decimal](10, 2) NULL,
	[Totale_HTVA] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Num_Facture] ASC,
	[Code_Article] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilisateur]    Script Date: 20/09/2025 21:43:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilisateur](
	[Login] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Type_Utilisateur] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Article] ADD  DEFAULT (getdate()) FOR [Date_Creation]
GO
ALTER TABLE [dbo].[Article] ADD  DEFAULT (getdate()) FOR [Date_Modification]
GO
ALTER TABLE [dbo].[Client] ADD  DEFAULT (getdate()) FOR [Date_Creation]
GO
ALTER TABLE [dbo].[Client] ADD  DEFAULT (getdate()) FOR [Date_Modification]
GO
ALTER TABLE [dbo].[Facture] ADD  DEFAULT (getdate()) FOR [Date_Creation]
GO
ALTER TABLE [dbo].[Facture] ADD  DEFAULT (getdate()) FOR [Date_Modification]
GO
ALTER TABLE [dbo].[Article]  WITH CHECK ADD FOREIGN KEY([Creer_Par])
REFERENCES [dbo].[Utilisateur] ([Login])
GO
ALTER TABLE [dbo].[Article]  WITH CHECK ADD FOREIGN KEY([Modifier_Par])
REFERENCES [dbo].[Utilisateur] ([Login])
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD FOREIGN KEY([Creer_Par])
REFERENCES [dbo].[Utilisateur] ([Login])
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD FOREIGN KEY([Modifier_Par])
REFERENCES [dbo].[Utilisateur] ([Login])
GO
ALTER TABLE [dbo].[Facture]  WITH CHECK ADD FOREIGN KEY([Code_Client])
REFERENCES [dbo].[Client] ([Code_Client])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Facture]  WITH CHECK ADD FOREIGN KEY([Creer_Par])
REFERENCES [dbo].[Utilisateur] ([Login])
GO
ALTER TABLE [dbo].[Facture]  WITH CHECK ADD FOREIGN KEY([Modifier_Par])
REFERENCES [dbo].[Utilisateur] ([Login])
GO
ALTER TABLE [dbo].[Ligne_Facture]  WITH CHECK ADD  CONSTRAINT [FK__Ligne_Fac__Code___4E88ABD4] FOREIGN KEY([Code_Article])
REFERENCES [dbo].[Article] ([Code_Article])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ligne_Facture] CHECK CONSTRAINT [FK__Ligne_Fac__Code___4E88ABD4]
GO
ALTER TABLE [dbo].[Ligne_Facture]  WITH CHECK ADD  CONSTRAINT [FK__Ligne_Fac__Num_F__4D94879B] FOREIGN KEY([Num_Facture])
REFERENCES [dbo].[Facture] ([Num_Facture])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ligne_Facture] CHECK CONSTRAINT [FK__Ligne_Fac__Num_F__4D94879B]
GO
ALTER TABLE [dbo].[Article]  WITH CHECK ADD  CONSTRAINT [CK_Qte_Stock_Positive] CHECK  (([Qte_Stock]>=(0)))
GO
ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [CK_Qte_Stock_Positive]
GO
ALTER TABLE [dbo].[Ligne_Facture]  WITH CHECK ADD  CONSTRAINT [CK__Ligne_Fac__Qte_V__4CA06362] CHECK  (([Qte_Vendu]>(0)))
GO
ALTER TABLE [dbo].[Ligne_Facture] CHECK CONSTRAINT [CK__Ligne_Fac__Qte_V__4CA06362]
GO
USE [master]
GO
ALTER DATABASE [DB_GestionFacture] SET  READ_WRITE 
GO
