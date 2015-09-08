using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using presentation.OrganizationProjectServiceReference;
using System.Web.Script.Serialization;
using presentation.Responces;
using presentation.Models;

namespace presentation.Controllers
{
    public class ChartViewerController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Return to page chart information
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult viewChart()
        {
            ControllerResponce Rsp = new ControllerResponce();
            using (var Client = new OrganizationProjectServiceReference.ServiceClient())
            {
                try
                {
                    var Response = Client.getVerboseChartScheme();
                    if (Response.IsSucsessfull == true)
                    {
                        Rsp.Data = new JavaScriptSerializer().Serialize(Response.VerboseChart);
                        Rsp.IsSuccessfull = true;
                        Rsp.ErrorMessage = null;
                    }
                    else
                    {
                        Rsp.Data = null;
                        Rsp.IsSuccessfull = false;
                        Rsp.ErrorMessage = Response.ErrorMessage;
                    }
                    return Json(Rsp);
                }
                catch (Exception e)
                {
                    Rsp.Data = null;
                    Rsp.IsSuccessfull = false;
                    Rsp.ErrorMessage = e.Message;
                    return Json(Rsp);
                }           
            }
        }

     
        /// <summary>
       /// GET: /ChartViewer/addEmplyee
       /// </summary>
       /// <returns></returns>
        public ActionResult addEmployee()
        {
            return View();
        }



        /// <summary>
        /// Post: /ChartViewr/addEmplyee
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult addEmployee(Employee emp)
        {
            EmployeeDTObject Emp_to_send = new EmployeeDTObject();
            BasicResponce Response = new BasicResponce();
            if (ModelState.IsValid)
            {
                using (var Client = new OrganizationProjectServiceReference.ServiceClient())
                {
                    Emp_to_send = new EmployeeDTObject()
                    {
                        EmployeeID = emp.EmployeeID,
                        FirstName = emp.FirstName,
                        LastName = emp.LastName,
                        OrganizationID = emp.OrganizationID,
                        EmployeeRoleID = emp.EmployeeRoleID,
                        ReportToEmployeeID = emp.ReportToEmployeeID,
                        ReportingManagees = null
                    };

                    Response = Client.addEmployee(Emp_to_send);
                }
                    if (Response.IsSucsessfull == true)
                    {
                        ModelState.Clear();
                        return View(new ModelGroup() { ResponceMessage = "New Employee Was Added Successfully"}); 
                    }

                return View(new ModelGroup() { ResponceMessage = Response.ErrorMessage });  
            }

            return View(new ModelGroup() { ResponceMessage = "Model state is invalid" });  
        }

        /// <summary>
        /// GET: /ChartViewer/deleteEmployee
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult deleteEmployee()
        {
            
            EmployeeDeleteParams EmpDel = new EmployeeDeleteParams();
            ModelGroup mg = new ModelGroup();
            //if there's error from previous deletion show it
            string errMsg = TempData["ErrorMessage"] as string;
            if (errMsg != null) mg.ResponceMessage = errMsg;

            using (var Client = new OrganizationProjectServiceReference.ServiceClient())
            {
                //get all employees and put them to drop down list
                var Response = Client.getAllEmployees();
                if (Response.IsSucsessfull)
                {
                    EmpDel.allEmployees = 
                    from s in Response.AllEmployees
                    select new SelectListItem
                    {
                        Text = s.LastName + " " + s.FirstName,
                        Value = s.EmployeeID.ToString()
                    };
                    mg.del = EmpDel;
                }
                else 
                {
                    //if error insert it to message and show
                    if (mg.ResponceMessage != null)
                        mg.ResponceMessage += Response.ErrorMessage;
                    else
                        mg.ResponceMessage = Response.ErrorMessage;                
                }
                    return View(mg);
            }
              
        }

        /// <summary>
        /// POST: /ChartViewer/deleteEmployee
        /// </summary>
        /// <param name="del">Delete Parameters(id)</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult deleteEmployee(EmployeeDeleteParams del)
        {         
            BasicResponce response = new BasicResponce();
            if (ModelState.IsValid)
            {
                using (var client = new OrganizationProjectServiceReference.ServiceClient())
                {                
                       response = client.deleteEmployeeByID(del.EmployeeID);
                }

                if (response.IsSucsessfull == true)
                {
                    ModelState.Clear();
                    return RedirectToAction("deleteEmployee", "ChartViewer");
                }
                TempData["ErrorMessage"] = response.ErrorMessage;
                return RedirectToAction("deleteEmployee", "ChartViewer");
            }
            TempData["ErrorMessage"] = "The model is invalid";
            return RedirectToAction("deleteEmployee", "ChartViewer");
        }

        /// <summary>
        /// Edit employees manager by id
        /// </summary>
        /// <returns></returns>
        public ActionResult editEmployeeManager()
        {
            ManagerEdit EditMan = new ManagerEdit();
            ModelGroup mg = new ModelGroup();
            //if there's error from previous deletion show it
            string errMsg = TempData["ErrorMessage"] as string;
            if (errMsg != null) mg.ResponceMessage = errMsg;

            using (var Client = new OrganizationProjectServiceReference.ServiceClient())
            {
                var Response = Client.getAllEmployees();

                if (Response.IsSucsessfull)
                {
                    EditMan.allEmployees =
                    from s in Response.AllEmployees
                    select new SelectListItem
                    {
                         Text = s.LastName + " " + s.FirstName,
                         Value = s.EmployeeID.ToString()
                    };
                    mg.edit = EditMan;
                }
                else
                {
                    //if error insert it to message and show
                    if (mg.ResponceMessage != null)
                        mg.ResponceMessage += Response.ErrorMessage;
                    else
                        mg.ResponceMessage = Response.ErrorMessage;
                }

                return View(mg);  
            }  
        
        }

        /// <summary>
        /// POST: /ChartViewer/editEmployee
        /// </summary>
        /// <param name="edit"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult editEmployeeManager(ManagerEdit edit)
        {
            BasicResponce Response = new BasicResponce();

            if (ModelState.IsValid)
            {
                using (var Client = new OrganizationProjectServiceReference.ServiceClient())
                {
                    Response = Client.editManagerByID(edit.EmployeeID, edit.ManagerID);
                }

                if (Response.IsSucsessfull == true)
                {
                    ModelState.Clear();
                    return RedirectToAction("editEmployeeManager", "ChartViewer");
                }
                TempData["ErrorMessage"] = Response.ErrorMessage;
                return RedirectToAction("editEmployeeManager", "ChartViewer");
            }
            TempData["ErrorMessage"] = "The model is invalid";
            return RedirectToAction("editEmployeeManager", "ChartViewer");
        
        }

    }
}
