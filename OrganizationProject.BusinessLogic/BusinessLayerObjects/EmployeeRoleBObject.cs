using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizationProject.BusinessLogic.BusinessLayerObjects
{
    public class EmployeeRoleBObject
    {
        /// <summary>
        /// Class representing Employee Role on the business logic level(id, name, description)
        /// </summary>
        public int EmployeeRoleID { get; set; }
        public string EmployeeRoleName { get; set; }
        public string EmployeeRoleDescription { get; set; }
    }
}
