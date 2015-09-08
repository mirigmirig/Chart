using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OrganizationProject.BusinessLogic.BusinessLayerObjects;
using System.Data.Objects.DataClasses;
using System.Data.Objects;

namespace OrganizationProject.BusinessLogic
{
    static class BusinessLogic_Mapper
    {
//======================================Employee Transforamtion============================================================


        /// <summary>
        /// The function converts employee data from database object to business-logic object
        /// </summary>
        /// <param name="Employee">The passed parameter includes
        /// information about employee from database</param>
        /// <returns>Transforem object ov business-logic type</returns>
        public static EmployeeBObject MapEmployeeBObject(OrganizationProject.DataAccess.EmployeesData EmployeeData)
        {
            if (EmployeeData == null) return null;

            var obj = new EmployeeBObject()
            {

                EmployeeID = EmployeeData.EmployeeID,
                FirstName = EmployeeData.FirstName,
                LastName = EmployeeData.LastName,
                EmployeeRoleID = EmployeeData.EmployeeRoleID,
                ReportToEmployeeID = EmployeeData.ReportsToEmployeeID,
                OrganizationID = EmployeeData.OrganizationID,
                ReportingManagees = convert(EmployeeData.ChidEmployeesData)

            };

            return obj;
        }

        /// <summary>
        /// The function aim is to provide recursive
        /// conversion of employee's managees from database type to business-logic type
        /// </summary>
        /// <param name="listDAL">List of employees's managees</param>
        /// <returns>Converted list of business-logic objects</returns>
        private static List<EmployeeBObject> convert(EntityCollection<DataAccess.EmployeesData> listDAL)
        {
            if (listDAL == null) return null;
            List<EmployeeBObject> res = new List<EmployeeBObject>();
            foreach (var item in listDAL) {            
            res.Add(MapEmployeeBObject(item));
            }
            return res;
        }


        /// <summary>
        /// The function converts employee data from  business-logic object to database object
        /// </summary>
        /// <param name="Employee">The passed parameter includes
        /// information about employee of business-logic level</param>
        /// <returns>Transformed object of database type</returns>
        public static OrganizationProject.DataAccess.EmployeesData mapDBEmplyee(EmployeeBObject EmployeeData)
        {
            if (EmployeeData == null) return null;

            var obj = new OrganizationProject.DataAccess.EmployeesData()
            {
                EmployeeID = EmployeeData.EmployeeID,
                FirstName = EmployeeData.FirstName,
                LastName = EmployeeData.LastName,
                EmployeeRoleID = EmployeeData.EmployeeRoleID,
                ReportsToEmployeeID = EmployeeData.ReportToEmployeeID,
                OrganizationID = EmployeeData.OrganizationID
            };
            return obj;

        }

//==================================================Employee Role Transformation===========================================================
        
        /// <summary>
        /// The function converts employee role data from database object to business-logic object
        /// </summary>
        /// <param name="Employee">The passed parameter includes
        /// information about employee role from database</param>
        /// <returns>Transformed object of business-logic type</returns>
        public static EmployeeRoleBObject MapEmployeeRoleBObject(OrganizationProject.DataAccess.EmployeeRoleData RoleData)
        {

            if (RoleData == null) return null;
            var obj = new EmployeeRoleBObject() {        
            EmployeeRoleID = RoleData.EmployeeRoleID,
            EmployeeRoleName = RoleData.EmployeeRoleName,
            EmployeeRoleDescription = RoleData.EmployeeRoleDescription                      
            };

            return obj;
        }

//==================================================Organization Transformation=================================================================

        /// <summary>
        /// The function converts organization data from database object to business-logic object
        /// </summary>
        /// <param name="Employee">The passed parameter includes
        /// information about organization from database</param>
        /// <returns>Transformed object of business-logic type</returns>
        public static OrganizationBObject MapOrganizationBObject(OrganizationProject.DataAccess.OrganizationData OrganizationData)
        {
            if (OrganizationData == null) return null;

            var obj = new OrganizationBObject() { 
            
                OrganizationID = OrganizationData.OrganizationID,
                OrganizationName = OrganizationData.OrganizationName,
                OrganizationDescription = OrganizationData.OrganizationDecription
                     
            };
            return obj;
        }

//=======================================================Chart Transformation=============================================================


        /// <summary>
        /// It might be necessaru to make information in chart more user friendly,
        /// e.g. name of employee role instead of id. I think it's better to leave this job as close to database
        /// level as possible, and give the client opportunity use ready functions
        /// </summary>
        /// <param name="chart">The object representing chart</param>
        /// <param name="allRoles">The list of role objects(id, role name, decription) from database</param>
        public static EmployeeVerbBObject  mapToVerboseChart(OrganizationProject.DataAccess.EmployeesData Chart, ObjectSet<DataAccess.EmployeeRoleData> AllRoles)
        {

            if (Chart == null) return null;
                return new EmployeeVerbBObject()
                {                
                EmployeeID = Chart.EmployeeID,
                FirstName = Chart.FirstName,
                LastName = Chart.LastName,
                ReportToEmployeeID = Chart.ReportsToEmployeeID,
                OrganizationID = Chart.OrganizationID,
                EmployeeRole = AllRoles.Where(o => o.EmployeeRoleID == Chart.EmployeeRoleID).FirstOrDefault().EmployeeRoleName,
                ReportingManagees = convertVerb(Chart.ChidEmployeesData, AllRoles)          
                };
        }

        /// <summary>
        /// The function aim is to provide recursive
        /// conversion of chart to add verbosity(currently role name instaed of role id)
        /// </summary>
        /// <param name="listDAL">List of employees's managees</param>
        /// <returns>Converted list of business-logic objects</returns>
        public static List<EmployeeVerbBObject> convertVerb(EntityCollection<DataAccess.EmployeesData> listDAL, ObjectSet<DataAccess.EmployeeRoleData>AllRoles)
        {
            if (listDAL == null) return null;
            List<EmployeeVerbBObject> res = new List<EmployeeVerbBObject>();
            foreach (var item in listDAL) {            
            res.Add(mapToVerboseChart(item, AllRoles));
            }
            return res;
        }
    }
}
