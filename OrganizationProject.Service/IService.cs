using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using OrganizationProject.Service.ServiceObjects.Responces;
using OrganizationProject.Service.ServiceObjects;

namespace OrganizationProject.Service
{
    /// <summary>
    /// Define the IService contract.
    /// </summary>
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        EmployeeDTOResponce getEmployeeByID(int Id);

        [OperationContract]
        EmployeeDTOResponce getAllEmployees();

        [OperationContract]
        BasicResponce deleteEmployeeByID(int Id);

        [OperationContract]
        BasicResponce editManagerByID(int EmpoyeeID, int ManagerID);

        [OperationContract]
        BasicResponce addEmployee(EmployeeDTObject Employee);
      
        [OperationContract]
        ChartDTOResponce getChartScheme();

        [OperationContract]
        ChartDTOResponce getVerboseChartScheme();

        [OperationContract]
        EmployeeRoleDTOResponce getEmployeeRoleByID(int Id);

        [OperationContract]
        EmployeeRoleDTOResponce getEmployeeRoles();

        [OperationContract]
        OrganizationDTOResponce getOrganizationByID(int Id);

    }
}
