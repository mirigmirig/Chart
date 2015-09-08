using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OrganizationProject.BusinessLogic.BusinessLayerObjects;

namespace OrganizationProject.BusinessLogic.BusinessLogicManagment
{
    /// <summary>
    /// The class provides methods of Employee Role data manipulation
    /// </summary>
    public class BusinessLogic_EmployeeRole
    {
        /// <summary>
        /// Returns Employee Role Data by given ID(ID is a primary key and is unique for each employee role)
        /// </summary>
        /// <param name="Id">Id</param>
        /// <returns>Employee Role Data in form of Business Logic object</returns>
        public EmployeeRoleBObject getEmployeeRoleByID(int Id)
        {
            using (var context = new OrganizationProject.DataAccess.OrganizationData_DBEntities())
            {
                try
                {
                    var dbEmployeeRole = context.EmployeeRoleDatas.Where(o => o.EmployeeRoleID == Id).FirstOrDefault();
                    return BusinessLogic_Mapper.MapEmployeeRoleBObject(dbEmployeeRole);
                }

                catch (Exception e)
                {
                    throw new Exception("Unable to get EmployeeRole by Id", e);
                }
            }

        }

        /// <summary>
        /// Returns full list of Employee Roles
        /// </summary>
        /// <returns>List of Employee Roles in form of list of Business Logoc objects</returns>
        public List<EmployeeRoleBObject> getEmployeeRoles()
        {
            List<EmployeeRoleBObject> result = new List<EmployeeRoleBObject>();
            using (var context = new OrganizationProject.DataAccess.OrganizationData_DBEntities())
            {
                try
                {
                   var dbEmployeeRoles = context.EmployeeRoleDatas;
                    foreach (var item in dbEmployeeRoles)
                    {
                        result.Add(BusinessLogic_Mapper.MapEmployeeRoleBObject(item));
                    }
                    return result;
                }

                catch (Exception e)
                {
                    throw new Exception("Unable to get EmployeeRoles", e);

                }
            }
        }
    }
}
