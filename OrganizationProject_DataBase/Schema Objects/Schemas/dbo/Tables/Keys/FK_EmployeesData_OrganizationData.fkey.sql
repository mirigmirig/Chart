ALTER TABLE [dbo].[EmployeesData]
    ADD CONSTRAINT [FK_EmployeesData_OrganizationData] FOREIGN KEY ([OrganizationID]) REFERENCES [dbo].[OrganizationData] ([OrganizationID]) ON DELETE NO ACTION ON UPDATE NO ACTION;

