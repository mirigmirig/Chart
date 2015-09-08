using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizationProject.BusinessLogic.BusinessLayerObjects
{
    /// <summary>
    /// Class representing Employee on the business logic level in a more user friendly way (role name instead of id)
    ///
    /// </summary>
    public class EmployeeVerbBObject
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeRole { get; set; }
        public int? ReportToEmployeeID { get; set; }
        public int OrganizationID { get; set; }
        public List<EmployeeVerbBObject> ReportingManagees { get; set; }
    }
}
