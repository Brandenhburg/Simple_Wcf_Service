
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/07/2021 17:14:13
-- Generated from EDMX file: D:\Programming\C#_practice\WCF\StoredProcedure\CustomerService\BankDatabase.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BankDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_SavingsAccountCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SavingsAccounts] DROP CONSTRAINT [FK_SavingsAccountCustomer];
GO
IF OBJECT_ID(N'[dbo].[FK_CurrentAccountCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CurrentAccounts] DROP CONSTRAINT [FK_CurrentAccountCustomer];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[CurrentAccounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CurrentAccounts];
GO
IF OBJECT_ID(N'[dbo].[SavingsAccounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SavingsAccounts];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Firstname] nvarchar(50)  NOT NULL,
    [Lastname] nvarchar(50)  NOT NULL,
    [Email] nvarchar(50)  NOT NULL,
    [JoinedOnDate] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'CurrentAccounts'
CREATE TABLE [dbo].[CurrentAccounts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CurrentBalance] decimal(18,0)  NOT NULL,
    [CustomerEmail] nvarchar(50)  NOT NULL,
    [Customer_Id] int  NOT NULL
);
GO

-- Creating table 'SavingsAccounts'
CREATE TABLE [dbo].[SavingsAccounts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SavingsBalance] decimal(18,0)  NOT NULL,
    [CustomerEmail] nvarchar(50)  NOT NULL,
    [Customer_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CurrentAccounts'
ALTER TABLE [dbo].[CurrentAccounts]
ADD CONSTRAINT [PK_CurrentAccounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SavingsAccounts'
ALTER TABLE [dbo].[SavingsAccounts]
ADD CONSTRAINT [PK_SavingsAccounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Customer_Id] in table 'SavingsAccounts'
ALTER TABLE [dbo].[SavingsAccounts]
ADD CONSTRAINT [FK_SavingsAccountCustomer]
    FOREIGN KEY ([Customer_Id])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SavingsAccountCustomer'
CREATE INDEX [IX_FK_SavingsAccountCustomer]
ON [dbo].[SavingsAccounts]
    ([Customer_Id]);
GO

-- Creating foreign key on [Customer_Id] in table 'CurrentAccounts'
ALTER TABLE [dbo].[CurrentAccounts]
ADD CONSTRAINT [FK_CurrentAccountCustomer]
    FOREIGN KEY ([Customer_Id])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CurrentAccountCustomer'
CREATE INDEX [IX_FK_CurrentAccountCustomer]
ON [dbo].[CurrentAccounts]
    ([Customer_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------