using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace OrganizationProject.Service.ServiceObjects.Responces
{
    /// <summary>
    /// Basic Responce object including information
    /// about possible transfer success or fail incliding error message
    /// </summary>
    [DataContract]
    public class BasicResponce
    {
        [DataMember]
        public bool IsSucsessfull { get; set; }
        [DataMember]
        public string ErrorMessage { get; set; }

    }
}