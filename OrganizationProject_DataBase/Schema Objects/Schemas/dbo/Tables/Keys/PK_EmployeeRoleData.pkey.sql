﻿ALTER TABLE [dbo].[EmployeeRoleData]
    ADD CONSTRAINT [PK_EmployeeRoleData] PRIMARY KEY CLUSTERED ([EmployeeRoleID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
