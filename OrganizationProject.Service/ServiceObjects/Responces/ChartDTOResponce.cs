using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace OrganizationProject.Service.ServiceObjects.Responces
{
    /// <summary>
    /// Chart Responce object including information
    /// about chart(both types) and possible transfer success or fail incliding error message
    /// </summary>
    [DataContract]
    public class ChartDTOResponce:BasicResponce
    {
          [DataMember]
          public List<EmployeeDTObject> Chart { get; set; }
          [DataMember]
          public List<EmployeeVerbDTObject> VerboseChart { get; set; }
    }
}