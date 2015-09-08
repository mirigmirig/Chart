using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OrganizationProject.BusinessLogic.BusinessLayerObjects;
using System.Data.Objects;

namespace OrganizationProject.BusinessLogic.BusinessLogicManagment
{
    /// <summary>
    /// The class provides methods of Employee data manipulation
    /// </summary>
    public class BusinessLogic_Employee
    {
        /// <summary>
        /// Returns Employee Data by given ID(ID is a primary key and is unique for each employee)
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Employee Data in form of Business Logic object</returns>
        public EmployeeBObject getEmployeeByID(int Id)
        {
             using (var context = new OrganizationProject.DataAccess.OrganizationData_DBEntities())
                {
                    try
                        {
                            var dbEmployee = context.EmployeesDatas.Where(o => o.EmployeeID == Id).FirstOrDefault();
                            return BusinessLogic_Mapper.MapEmployeeBObject(dbEmployee);
                        }

                    catch (Exception e)
                      {
                            throw new Exception("Unable to get Employee by Id", e);

                      }
              }      
        }

        /// <summary>
        /// Deletes Employee with a given id
        /// </summary>
        /// <param name="Id">Id</param>
        public void deleteEmployeeByID(int Id)
        {
            using (var context = new OrganizationProject.DataAccess.OrganizationData_DBEntities())
            {
                try
                {
                    var dbEmployee = context.EmployeesDatas.Where(o => o.EmployeeID == Id).FirstOrDefault();
                    context.DeleteObject(dbEmployee);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("Unable to delete Employee by Id", e);

                }
            }

        }

        /// <summary>
        /// Adds new Employee to the database
        /// </summary>
        /// <param name="Employee">Object of business-logic type including employee data</param>
        public void addEmployee(EmployeeBObject Employee)
        {
            //employee can't be his own manager
            if (Employee.ReportToEmployeeID != null && Employee.EmployeeID == Employee.ReportToEmployeeID)
            {
                throw new Exception("Employee can't be it's own manager");
            }


            using (var context = new OrganizationProject.DataAccess.OrganizationData_DBEntities())
            {
                try
                {
                   var dbEmployee = BusinessLogic_Mapper.mapDBEmplyee(Employee);
                   if (Employee.ReportToEmployeeID != null)
                   {
                       //role of emploee should be lower than of managaer(secretary can't be manger of CEO)
                       var manager = context.EmployeesDatas.Where(o => o.EmployeeID == Employee.ReportToEmployeeID).FirstOrDefault();
                       if (manager != null && Employee.EmployeeRoleID >= manager.EmployeeRoleID)
                       {
                           throw new Exception("Manager should have higher position than employee");                     
                       }                   
                   }
                   context.EmployeesDatas.AddObject(dbEmployee);
                   context.SaveChanges();
                }

                catch (Exception e)
                {
                    throw new Exception("Unable to add new employee", e);

                }
            }

        }

        /// <summary>
        /// Returns the chart scheme in the form of business logic object
        /// </summary>
        /// <returns>chart data</returns>
        public List<EmployeeBObject> getChartScheme()
        {
            List<EmployeeBObject> res = new List<EmployeeBObject>();

            using (var context = new OrganizationProject.DataAccess.OrganizationData_DBEntities())
            {
                try
                {
                    var noReportingEmpoyees = context.EmployeesDatas.Where(o => o.ReportsToEmployeeID == null);
                    foreach (var item in noReportingEmpoyees)
                    {
                        res.Add(BusinessLogic_Mapper.MapEmployeeBObject(item));
                    }

                    return res;
                }

                catch (Exception e)
                {
                    throw new Exception("Unable to return chartScheem", e);

                }
            }
        }

        /// <summary>
        /// Returns the chart scheme in the form of business logic object(verbose, eg role name instead of role id)
        /// </summary>
        /// <returns>chart data</returns>
        public List<EmployeeVerbBObject> getVerboseChartScheme()
        {
            List<EmployeeVerbBObject> result = new List<EmployeeVerbBObject>();
            using (var context = new OrganizationProject.DataAccess.OrganizationData_DBEntities())
            {
                try
                {
                    ObjectSet<DataAccess.EmployeeRoleData> allRoles = context.EmployeeRoleDatas;
                    IQueryable<OrganizationProject.DataAccess.EmployeesData> chart = context.EmployeesDatas.Where(o => o.ReportsToEmployeeID == null);
                    foreach (var item in chart)
                    {
                        result.Add(BusinessLogic_Mapper.mapToVerboseChart(item, allRoles));
                    }

                    return result;

                }
                catch (Exception e)
                {
                    throw new Exception("Unable to return verbose chartScheme", e);

                }
            }
        }

        /// <summary>
        /// Get list of all empoyees from database
        /// </summary>
        /// <returns>list of employees as list of business logic objects</returns>
        public List<EmployeeBObject> getAllEmployees()
        {
            List<EmployeeBObject> result = new List<EmployeeBObject>();
            using (var context = new OrganizationProject.DataAccess.OrganizationData_DBEntities())
            {
                try
                {
                    var dbEmployee = context.EmployeesDatas;
                    foreach (var item in dbEmployee)
                    {
                        result.Add(BusinessLogic_Mapper.MapEmployeeBObject(item));
                    }
                    return result;
                }
                catch (Exception e)
                {
                    throw new Exception("Unable to get Employee by Id", e);

                }
            }
        }

        /// <summary>
        /// Edits employee's manager by their IDs
        /// </summary>
        /// <param name="EmpoyeeID">Employee ID</param>
        /// <param name="ManagerID">Manager ID</param>
        public void editManagerByID(int EmpoyeeID, int ManagerID)
        {
            //employee can't be his own manager
            if (ManagerID != null && EmpoyeeID == ManagerID)
            {
                throw new Exception("Employee can't be it's own manager");
            }
            using (var context = new OrganizationProject.DataAccess.OrganizationData_DBEntities())
            {
                try
                {
                    if (ManagerID != null)
                    {
                        //role of emploee should be lower than of managaer(secretary can't be manger of CEO)
                        var manager = context.EmployeesDatas.Where(o => o.EmployeeID == ManagerID).FirstOrDefault();
                        var employee = context.EmployeesDatas.Where(o => o.EmployeeID == EmpoyeeID).FirstOrDefault();
                        if (manager != null && employee.EmployeeRoleID >= manager.EmployeeRoleID)
                        {
                            throw new Exception("Manager should have higher position than employee");
                        }
                    }

                    var dbEmployee = context.EmployeesDatas.Where(o => o.EmployeeID == EmpoyeeID).FirstOrDefault();
                    dbEmployee.ReportsToEmployeeID = ManagerID;
                    context.SaveChanges();
                }

                catch (Exception e)
                {
                    throw new Exception("This combination employee-manager is imossible", e);

                }
            }

        }


    }
}
