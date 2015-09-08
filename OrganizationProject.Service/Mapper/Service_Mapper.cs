using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrganizationProject.BusinessLogic.BusinessLayerObjects;
using OrganizationProject.Service.ServiceObjects;

namespace OrganizationProject.Service
{
    public static class Service_Mapper
    {

//=============================================Employee transform ======================================================

        /// <summary>
        /// The function converts employee from business-logic object to dto object
        /// </summary>
        /// <param name="Employee">Employee data</param>
        /// <returns>Converted dto object</returns>
         public static EmployeeDTObject MapEmployeeBObject(EmployeeBObject Employee)
        {
            if (Employee == null) return null;
            var obj = new EmployeeDTObject()
            {
                EmployeeID = Employee.EmployeeID,
                FirstName = Employee.FirstName,
                LastName = Employee.LastName,
                EmployeeRoleID = Employee.EmployeeRoleID,
                OrganizationID = Employee.OrganizationID,
                ReportToEmployeeID = Employee.ReportToEmployeeID,
                ReportingManagees = convert(Employee.ReportingManagees)
            };

            return obj;
        }


        /// <summary>
         /// The function aim is to provide recursive
         /// conversion of employee's managees from business-logic type to dto type
        /// </summary>
        /// <param name="ListDTO"></param>
        /// <returns></returns>
        private static List<EmployeeDTObject> convert(List<EmployeeBObject> ListDTO)
        {
            if (ListDTO == null) return null;
            List<EmployeeDTObject> res = new List<EmployeeDTObject>();
            foreach (var item in ListDTO) {
                res.Add(MapEmployeeBObject(item));
            }
            return res;
        }


        /// <summary>
        /// The function converts employee from business-logic object to dto object(verbose)
        /// </summary>
        /// <param name="Employee">Employee data</param>
        /// <returns>Converted dto object</returns>
        public static EmployeeVerbDTObject MapEmployeeVerbBObject(EmployeeVerbBObject Employee)
        {
            if (Employee == null) return null;
            var obj = new EmployeeVerbDTObject()
            {
                EmployeeID = Employee.EmployeeID,
                FirstName = Employee.FirstName,
                LastName = Employee.LastName,
                EmployeeRole = Employee.EmployeeRole,
                OrganizationID = Employee.OrganizationID,
                ReportToEmployeeID = Employee.ReportToEmployeeID,
                ReportingManagees = convertVerb(Employee.ReportingManagees)
            };

            return obj;
        }

        /// <summary>
        /// The function aim is to provide recursive
        /// conversion of employee's managees from business-logic type to dto type
        /// </summary>
        /// <param name="ListDTO"></param>
        /// <returns></returns>
        private static List<EmployeeVerbDTObject> convertVerb(List<EmployeeVerbBObject> ListVerbDTO)
        {
            if ( ListVerbDTO == null) return null;
            List<EmployeeVerbDTObject> res = new List<EmployeeVerbDTObject>();
            foreach (var item in ListVerbDTO)
            {
                res.Add(MapEmployeeVerbBObject(item));
            }
            return res;
        }


        /// <summary>
        /// The function converts employee from dto object to business-logic object
        /// </summary>
        /// <param name="Employee">Dt object employee</param>
        /// <returns>Business Logic object</returns>
        public static EmployeeBObject mapDTOEmployee(EmployeeDTObject Employee)
        {
            if (Employee == null) return null;
            var obj = new EmployeeBObject
            {
                EmployeeID = Employee.EmployeeID,
                FirstName = Employee.FirstName,
                LastName = Employee.LastName,
                EmployeeRoleID = Employee.EmployeeRoleID,
                ReportToEmployeeID = Employee.ReportToEmployeeID,
                OrganizationID = Employee.OrganizationID,
                ReportingManagees = null
            };
            return obj;
        }

//=================================Employee Role Transform===============================================================
        /// <summary>
        /// The function converts employee role from business-logic object to dto object
        /// </summary>
        /// <param name="RoleData">Employee role Data</param>
        /// <returns>Converted DT object</returns>
        public static EmployeeRoleDTObject MapEmployeeRoleBObject(EmployeeRoleBObject RoleData)
        {

            if (RoleData == null) return null;
            var obj = new EmployeeRoleDTObject() {

                EmployeeRoleDescription = RoleData.EmployeeRoleDescription,
                EmployeeRoleID = RoleData.EmployeeRoleID,
                EmployeeRoleName = RoleData.EmployeeRoleName                     
            };

            return obj;
        }

//=============================================Organisation transform=========================================================
        /// <summary>
        /// The function converts organisation from business-logic object to dto object
        /// </summary>
        /// <param name="Organization">Organisation data</param>
        /// <returns>Dt object</returns>
        public static OrganizationDTObject MapOrganizationBObject(OrganizationBObject Organization)
        {
            if (Organization == null) return null;
            var obj = new OrganizationDTObject() { 
                OrganizationDescription = Organization.OrganizationDescription,
                OrganizationID = Organization.OrganizationID,
                OrganizationName = Organization.OrganizationName                    
            };
            return obj;
        }


       
    }

    }
