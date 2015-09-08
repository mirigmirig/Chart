using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OrganizationProject.BusinessLogic.BusinessLayerObjects
{
    /// <summary>
    /// Class representing Organization on the business logic level(id, name, description)
    /// </summary>
    public class OrganizationBObject
    {
        public int OrganizationID {get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationDescription { get; set; }
    }
}
