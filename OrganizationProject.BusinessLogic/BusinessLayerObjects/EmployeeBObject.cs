using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizationProject.BusinessLogic.BusinessLayerObjects
{
    /// <summary>
    /// Class representing Employee on the business logic level(id, name, id of manager, organization, etc.)
    /// </summary>
    public class EmployeeBObject
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeRoleID { get; set; }
        public int? ReportToEmployeeID { get; set; }
        public int OrganizationID { get; set; }
        public List<EmployeeBObject> ReportingManagees { get; set; }
    }
}