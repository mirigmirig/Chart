using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace OrganizationProject.Service.ServiceObjects.Responces
{
    /// <summary>
    /// Employee Responce object including information
    /// about Employee and possible transfer success or fail incliding error message
    /// </summary>
    [DataContract]
    public class EmployeeRoleDTOResponce:BasicResponce
    {
            [DataMember]
            public EmployeeRoleDTObject Role { get; set; }
            [DataMember]
            public List<EmployeeRoleDTObject> AllRoles { get; set; }

    }
}