using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using OrganizationProject.Service.ServiceObjects.Responces;
using OrganizationProject.BusinessLogic.BusinessLogicManagment;
using OrganizationProject.Service.ServiceObjects;

namespace OrganizationProject.Service
{
    /// <summary>
    /// Implement IService contract
    /// </summary>
    public class Service : IService
    {

//==============================================Employee Manipulations ================================================

        /// <summary>
        /// Returns Employee Data by given ID(ID is a primary key and is unique for each employee)
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Employee Data included in DTO Response</returns>
        public EmployeeDTOResponce getEmployeeByID(int Id)
        {
            var result = new EmployeeDTOResponce();
            try
            {
                var businessLogic = new BusinessLogic_Employee();
                var employee = Service_Mapper.MapEmployeeBObject(businessLogic.getEmployeeByID(Id));

                result.Employee = employee;
                result.IsSucsessfull = true;
                result.ErrorMessage = null;
            }
            catch (Exception e)
            {
                result.Employee = null;
                result.IsSucsessfull = false;
                result.ErrorMessage = e.Message;
            }
            return result;
        }

        /// <summary>
        /// Get list of all Employees include in DTO response
        /// </summary>
        /// <returns>All employes List included in DTO Response</returns>
        public EmployeeDTOResponce getAllEmployees()
        {
            var result = new EmployeeDTOResponce();
            result.AllEmployees = new List<EmployeeDTObject>();
            try
            {
                var businessLogic = new BusinessLogic_Employee();
                var allEmployees = businessLogic.getAllEmployees();
                foreach (var item in allEmployees)
                {
                    result.AllEmployees.Add(Service_Mapper.MapEmployeeBObject(item));                
                }
                result.IsSucsessfull = true;
                result.ErrorMessage = null;
            }
            catch (Exception e)
            {
                result.Employee = null;
                result.IsSucsessfull = false;
                result.ErrorMessage = e.Message; //change error code error message 
            }
            return result;               
     }

        /// <summary>
        /// Delete data of employee by a given Id
        /// </summary>
        /// <param name="Id">ID</param>
        ///<returns>Basic Response</returns>
        public BasicResponce deleteEmployeeByID(int Id)
        {
            var result = new BasicResponce();
            try
            {
                var businessLogic = new BusinessLogic_Employee();
                businessLogic.deleteEmployeeByID(Id);
                result.IsSucsessfull = true;
                result.ErrorMessage = null;
            }
            catch (Exception e)
            {
                result.IsSucsessfull = false;
                result.ErrorMessage = e.Message;
            }
            return result;
        }

        /// <summary>
        /// Allows to edit the employee's manager by given Idss
        /// </summary>
        /// <param name="EmpoyeeID">Employee Id</param>
        /// <param name="ManagerID">Manager Id</param>
        /// <returns>Basic Responce</returns>
        public BasicResponce editManagerByID(int EmpoyeeID, int ManagerID)        
        {
            var result = new BasicResponce();
            try
            {
                var businessLogic = new BusinessLogic_Employee();
                businessLogic.editManagerByID(EmpoyeeID, ManagerID);
                result.IsSucsessfull = true;
                result.ErrorMessage = null;
            }
            catch (Exception e)
            {
                result.IsSucsessfull = false;
                result.ErrorMessage = e.Message;
            }
            return result;       
        }

        /// <summary>
        /// Allows to add a given employee to the data base
        /// </summary>
        /// <param name="employee">Employee Data as Data Transfer Object</param>
        /// <returns></returns>
        public BasicResponce addEmployee(EmployeeDTObject employee)
        {
            var result = new BasicResponce();
            try
            {
                var businessLogic = new BusinessLogic_Employee();
                businessLogic.addEmployee(Service_Mapper.mapDTOEmployee(employee));
                result.IsSucsessfull = true;
                result.ErrorMessage = null;
            }
            catch (Exception e)
            {
                result.IsSucsessfull = false;
                result.ErrorMessage = e.Message;
            }
            return result;
        }


//====================================Chart Manipulations====================================================================
        /// <summary>
        /// Returns Chart Scheme
        /// </summary>
        /// <returns>Chart included in DTO Response</returns>
        public ChartDTOResponce getChartScheme() 
        {
            var result = new ChartDTOResponce();
            result.Chart = new List<EmployeeDTObject>();
            try
            {
                var businessLogic = new BusinessLogic_Employee();
                var chart = businessLogic.getChartScheme();
                foreach (var item in chart)
                {
                    
                    result.Chart.Add(Service_Mapper.MapEmployeeBObject(item));
                }
                result.IsSucsessfull = true;
                result.ErrorMessage = null;
            }
            catch (Exception e)
            {
                result.Chart = null;
                result.IsSucsessfull = false;
                result.ErrorMessage = e.Message;
            }
         return result;       
   }

        /// <summary>
        /// Returns Chart Scheme
        /// </summary>
        /// <returns>Chart included in DTO Response</returns>
        public ChartDTOResponce getVerboseChartScheme()
        {

            var result = new ChartDTOResponce();
            result.VerboseChart = new List<EmployeeVerbDTObject>();

            try
            {
                var businessLogic = new BusinessLogic_Employee();
                var chart = businessLogic.getVerboseChartScheme();
                foreach (var item in chart)
                {

                    result.VerboseChart.Add(Service_Mapper.MapEmployeeVerbBObject(item));
                }
                result.IsSucsessfull = true;
                result.ErrorMessage = null;

            }
            catch (Exception e)
            {
                result.Chart = null;
                result.IsSucsessfull = false;
                result.ErrorMessage = e.Message;
            }

            return result;
    }


//=============================Employee Role Manipulations================================================================
        /// <summary>
        /// returns Employee Role data by given ID
        /// </summary>
        /// <param name="Id">Id</param>
        /// <returns>Employee Role Data included in DTO Response</returns>
        public EmployeeRoleDTOResponce getEmployeeRoleByID(int Id)
        {
            var result = new EmployeeRoleDTOResponce();
            try
            {
                var businessLogic = new BusinessLogic_EmployeeRole();
                var role = businessLogic.getEmployeeRoleByID(Id);
                result.Role = Service_Mapper.MapEmployeeRoleBObject(role);
                result.IsSucsessfull = true;
                result.ErrorMessage = null;
            
            }
            catch (Exception e)
            {
                result.Role = null;
                result.IsSucsessfull = false;
                result.ErrorMessage = e.Message;
            }

         return result;
        }

        /// <summary>
        /// get list of all Employees
        /// </summary>
        /// <returns>list of all Employees included in DTO response</returns>
        public EmployeeRoleDTOResponce getEmployeeRoles()
        {
            var result = new EmployeeRoleDTOResponce();
            result.AllRoles = new List<EmployeeRoleDTObject>();
            try
            {
                var businessLogic = new BusinessLogic_EmployeeRole();

                var roles = businessLogic.getEmployeeRoles();
                foreach(var item in roles)
                result.AllRoles.Add(Service_Mapper.MapEmployeeRoleBObject(item));
                result.IsSucsessfull = true;
                result.ErrorMessage = null;
            }

            catch (Exception e)
            {
                result.Role = null;
                result.IsSucsessfull = false;
                result.ErrorMessage = e.Message;
            }

            return result;
      }

//======================================Organisation Manipulations============================================================

        /// <summary>
        /// Returns Organisation Data by ID
        /// </summary>
        /// <param name="Id">Id</param>
        /// <returns>Organisation Data by ID included in DTO response</returns>
        public OrganizationDTOResponce getOrganizationByID(int Id)
        {
            var result = new OrganizationDTOResponce();
            try
            {
                var businessLogic = new BusinessLogic_Organization();
                var role = businessLogic.getOrganizationByID(Id);
                result.Organization = Service_Mapper.MapOrganizationBObject(role);
                result.IsSucsessfull = true;
                result.ErrorMessage = null;
            }

            catch (Exception e)
            {
                result.Organization = null;
                result.IsSucsessfull = false;
                result.ErrorMessage = e.Message;
            }

            return result;        
        
        }




    }
}

