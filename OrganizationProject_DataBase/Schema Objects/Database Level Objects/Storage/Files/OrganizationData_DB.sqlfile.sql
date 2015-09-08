ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [OrganizationData_DB], FILENAME = '$(DefaultDataPath)$(DatabaseName).mdf', FILEGROWTH = 1024 KB) TO FILEGROUP [PRIMARY];

