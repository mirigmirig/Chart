ALTER TABLE [dbo].[EmployeesData]
    ADD CONSTRAINT [FK_EmployeesData_EmployeesData] FOREIGN KEY ([ReportsToEmployeeID]) REFERENCES [dbo].[EmployeesData] ([EmployeeID]) ON DELETE NO ACTION ON UPDATE NO ACTION;

