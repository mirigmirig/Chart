using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace presentation.Models
{
    /// <summary>
    /// Delete Parameters Model(parameters for deleting employee)
    /// </summary>
    public class EmployeeDeleteParams
    {
        [Required]
        [Display(Name = "Employee ID To Delete")]
        public int EmployeeID { get; set; }
        //Data for drop down list
        public IEnumerable<SelectListItem> allEmployees { get; set; }
    }
}