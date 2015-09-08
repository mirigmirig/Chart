using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace OrganizationProject.Service.ServiceObjects
{
    /// <summary>
    /// Data tfransfer object representing organisation
    /// </summary>
    [DataContract]
    public class OrganizationDTObject
    {
        [DataMember]
        public int OrganizationID { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
        [DataMember]
        public string OrganizationDescription { get; set; }
    }
}