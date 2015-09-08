using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace OrganizationProject.Service.ServiceObjects.Responces
{
    /// <summary>
    /// Employee Responce object including information
    /// about employee and possible transfer success or fail incliding error message
    /// </summary>
    [DataContract]
    public class EmployeeDTOResponce:BasicResponce
    {
        [DataMember]
        public EmployeeDTObject Employee { get; set; }
        [DataMember]
        public List<EmployeeDTObject> AllEmployees { get; set; }   
    }
}