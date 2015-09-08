using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace OrganizationProject.Service.ServiceObjects.Responces
{
    /// <summary>
    /// Organisation Responce object including information
    /// about Organisation and possible transfer success or fail incliding error message
    /// </summary>
    [DataContract]
    public class OrganizationDTOResponce:BasicResponce
    {
            [DataMember]
            public OrganizationDTObject Organization { get; set; }
    }
}