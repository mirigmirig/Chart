ALTER TABLE [dbo].[EmployeesData]
    ADD CONSTRAINT [FK_EmployeesData_EmployeeRoleData] FOREIGN KEY ([EmployeeRoleID]) REFERENCES [dbo].[EmployeeRoleData] ([EmployeeRoleID]) ON DELETE NO ACTION ON UPDATE NO ACTION;

