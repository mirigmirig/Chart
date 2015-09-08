CREATE TABLE [dbo].[EmployeesData] (
    [EmployeeID]          INT             NOT NULL,
    [FirstName]           NVARCHAR (1024) NOT NULL,
    [LastName]            NVARCHAR (1024) NOT NULL,
    [EmployeeRoleID]      INT             NOT NULL,
    [ReportsToEmployeeID] INT             NULL,
    [OrganizationID]      INT             NOT NULL
);

