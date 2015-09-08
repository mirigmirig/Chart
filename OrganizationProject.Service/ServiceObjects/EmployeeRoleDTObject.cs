using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace OrganizationProject.Service.ServiceObjects
{
    /// <summary>
    /// Data Transfer Object representing employee role
    /// </summary>
    [DataContract]
    public class EmployeeRoleDTObject
    {
        [DataMember]
        public int EmployeeRoleID { get; set; }
        [DataMember]
        public string EmployeeRoleName { get; set; }
        [DataMember]
        public string EmployeeRoleDescription { get; set; }
    }
}