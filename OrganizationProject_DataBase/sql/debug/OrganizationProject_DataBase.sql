/*
Deployment script for OrganizationProject_DataBase
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "OrganizationProject_DataBase"
:setvar DefaultDataPath ""
:setvar DefaultLogPath ""

GO
:on error exit
GO
USE [master]
GO
IF (DB_ID(N'$(DatabaseName)') IS NOT NULL
    AND DATABASEPROPERTYEX(N'$(DatabaseName)','Status') <> N'ONLINE')
BEGIN
    RAISERROR(N'The state of the target database, %s, is not set to ONLINE. To deploy to this database, its state must be set to ONLINE.', 16, 127,N'$(DatabaseName)') WITH NOWAIT
    RETURN
END

GO
IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [OrganizationData_DB], FILENAME = '$(DefaultDataPath)$(DatabaseName).mdf', FILEGROWTH = 1024 KB)
    LOG ON (NAME = [OrganizationData_DB_log], FILENAME = '$(DefaultLogPath)$(DatabaseName)_log.LDF', MAXSIZE = 2097152 MB, FILEGROWTH = 10 %) COLLATE Hebrew_CI_AS
GO
EXECUTE sp_dbcmptlevel [$(DatabaseName)], 100;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                RECOVERY FULL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
USE [$(DatabaseName)]
GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

GO
PRINT N'Creating [dbo].[EmployeeRoleData]...';


GO
CREATE TABLE [dbo].[EmployeeRoleData] (
    [EmployeeRoleID]          INT             NOT NULL,
    [EmployeeRoleName]        NVARCHAR (512)  NOT NULL,
    [EmployeeRoleDescription] NVARCHAR (1024) NOT NULL
);


GO
PRINT N'Creating PK_EmployeeRoleData...';


GO
ALTER TABLE [dbo].[EmployeeRoleData]
    ADD CONSTRAINT [PK_EmployeeRoleData] PRIMARY KEY CLUSTERED ([EmployeeRoleID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);


GO
PRINT N'Creating [dbo].[EmployeesData]...';


GO
CREATE TABLE [dbo].[EmployeesData] (
    [EmployeeID]          INT             NOT NULL,
    [FirstName]           NVARCHAR (1024) NOT NULL,
    [LastName]            NVARCHAR (1024) NOT NULL,
    [EmployeeRoleID]      INT             NOT NULL,
    [ReportsToEmployeeID] INT             NULL,
    [OrganizationID]      INT             NOT NULL
);


GO
PRINT N'Creating PK_EmployeesData...';


GO
ALTER TABLE [dbo].[EmployeesData]
    ADD CONSTRAINT [PK_EmployeesData] PRIMARY KEY CLUSTERED ([EmployeeID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);


GO
PRINT N'Creating [dbo].[OrganizationData]...';


GO
CREATE TABLE [dbo].[OrganizationData] (
    [OrganizationID]         INT             NOT NULL,
    [OrganizationName]       NVARCHAR (50)   NOT NULL,
    [OrganizationDecription] NVARCHAR (1024) NOT NULL
);


GO
PRINT N'Creating PK_OrganizationData...';


GO
ALTER TABLE [dbo].[OrganizationData]
    ADD CONSTRAINT [PK_OrganizationData] PRIMARY KEY CLUSTERED ([OrganizationID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);


GO
PRINT N'Creating FK_EmployeesData_EmployeeRoleData...';


GO
ALTER TABLE [dbo].[EmployeesData] WITH NOCHECK
    ADD CONSTRAINT [FK_EmployeesData_EmployeeRoleData] FOREIGN KEY ([EmployeeRoleID]) REFERENCES [dbo].[EmployeeRoleData] ([EmployeeRoleID]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating FK_EmployeesData_EmployeesData...';


GO
ALTER TABLE [dbo].[EmployeesData] WITH NOCHECK
    ADD CONSTRAINT [FK_EmployeesData_EmployeesData] FOREIGN KEY ([ReportsToEmployeeID]) REFERENCES [dbo].[EmployeesData] ([EmployeeID]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating FK_EmployeesData_OrganizationData...';


GO
ALTER TABLE [dbo].[EmployeesData] WITH NOCHECK
    ADD CONSTRAINT [FK_EmployeesData_OrganizationData] FOREIGN KEY ([OrganizationID]) REFERENCES [dbo].[OrganizationData] ([OrganizationID]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
-- Refactoring step to update target server with deployed transaction logs
CREATE TABLE  [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
GO
sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
GO

GO
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[EmployeesData] WITH CHECK CHECK CONSTRAINT [FK_EmployeesData_EmployeeRoleData];

ALTER TABLE [dbo].[EmployeesData] WITH CHECK CHECK CONSTRAINT [FK_EmployeesData_EmployeesData];

ALTER TABLE [dbo].[EmployeesData] WITH CHECK CHECK CONSTRAINT [FK_EmployeesData_OrganizationData];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        DECLARE @VarDecimalSupported AS BIT;
        SELECT @VarDecimalSupported = 0;
        IF ((ServerProperty(N'EngineEdition') = 3)
            AND (((@@microsoftversion / power(2, 24) = 9)
                  AND (@@microsoftversion & 0xffff >= 3024))
                 OR ((@@microsoftversion / power(2, 24) = 10)
                     AND (@@microsoftversion & 0xffff >= 1600))))
            SELECT @VarDecimalSupported = 1;
        IF (@VarDecimalSupported > 0)
            BEGIN
                EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
            END
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET MULTI_USER 
    WITH ROLLBACK IMMEDIATE;


GO
