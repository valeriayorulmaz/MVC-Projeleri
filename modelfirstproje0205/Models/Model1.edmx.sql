
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/02/2023 14:49:19
-- Generated from EDMX file: C:\Users\Valeria YORULMAZ\source\repos\modelfirstproje0205\modelfirstproje0205\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Firma];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PersonelSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonelSet];
GO
IF OBJECT_ID(N'[dbo].[ProjeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjeSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PersonelSet'
CREATE TABLE [dbo].[PersonelSet] (
    [PersonelNo] int IDENTITY(1,1) NOT NULL,
    [AdSoyad] nvarchar(max)  NOT NULL,
    [Telefon] nvarchar(max)  NOT NULL,
    [Adres] nvarchar(max)  NOT NULL,
    [Unvan] nvarchar(max)  NOT NULL,
    [Proje] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProjeSet'
CREATE TABLE [dbo].[ProjeSet] (
    [ProjeNo] int IDENTITY(1,1) NOT NULL,
    [ProjeAdi] nvarchar(max)  NOT NULL,
    [Aciklama] nvarchar(max)  NOT NULL,
    [CalisanSayisi] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PersonelNo] in table 'PersonelSet'
ALTER TABLE [dbo].[PersonelSet]
ADD CONSTRAINT [PK_PersonelSet]
    PRIMARY KEY CLUSTERED ([PersonelNo] ASC);
GO

-- Creating primary key on [ProjeNo] in table 'ProjeSet'
ALTER TABLE [dbo].[ProjeSet]
ADD CONSTRAINT [PK_ProjeSet]
    PRIMARY KEY CLUSTERED ([ProjeNo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------