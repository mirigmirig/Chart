using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace OrganizationProject.Service.ServiceObjects
{
    /// <summary>
    /// Data Transfer Object representing employee(verbose)
    /// </summary>
    [DataContract]
    public class EmployeeVerbDTObject
    {
        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string EmployeeRole { get; set; }
        [DataMember]
        public int? ReportToEmployeeID { get; set; }
        [DataMember]
        public int OrganizationID { get; set; }
        [DataMember]
        public List<EmployeeVerbDTObject> ReportingManagees { get; set; }

    }
}