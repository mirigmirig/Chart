using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace OrganizationProject.Service.ServiceObjects
{
    /// <summary>
    /// Data Transfer Object representing employee
    /// </summary>
    [DataContract]
    public class EmployeeDTObject
    {
        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public int EmployeeRoleID { get; set; }
        [DataMember]
        public int? ReportToEmployeeID { get; set; }
        [DataMember]
        public int OrganizationID { get; set; }
        [DataMember]
        public List<EmployeeDTObject> ReportingManagees { get; set; }

    }
}