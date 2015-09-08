using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace presentation.Models
{
    /// <summary>
    /// Model of parameters for editing manager
    /// </summary>
    public class ManagerEdit
    {
        [Required]
        [Display(Name = "Employee ID ")]
        public int EmployeeID { get; set; }
        [Required]
        [Display(Name = "Manager ID")]
        public int ManagerID { get; set; }
        //data for dropdown list
        public IEnumerable<SelectListItem> allEmployees { get; set; }
    }
}