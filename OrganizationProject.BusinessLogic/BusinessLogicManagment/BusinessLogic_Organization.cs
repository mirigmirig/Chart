using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OrganizationProject.BusinessLogic.BusinessLayerObjects;

namespace OrganizationProject.BusinessLogic.BusinessLogicManagment
{
    /// <summary>
    /// The class provides methods of Organization data manipulation
    /// </summary>
    /// 
    public class BusinessLogic_Organization
    {
        /// <summary>
        /// Returns Organization Data by given ID(ID is a primary key and is unique for each organisation)
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Organisation Data in form of Business Logic object</returns>
         public OrganizationBObject getOrganizationByID(int Id)
        {
            using (var context = new OrganizationProject.DataAccess.OrganizationData_DBEntities())
            {
                try
                {
                    var dbOrganization = context.OrganizationDatas.Where(o => o.OrganizationID == Id).FirstOrDefault();
                    return BusinessLogic_Mapper.MapOrganizationBObject(dbOrganization);
                }

                catch (Exception e)
                {
                    throw new Exception("Unable to get organization by Id", e);

                }
            }

        }
    }
}
