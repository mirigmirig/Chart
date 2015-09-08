using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace presentation.Models
{
    //Employee Model
    public class Employee
    {
        [Required]
        [Display(Name = "Employee ID")]
        public int EmployeeID { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "Employee First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "Employee Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Employee Role ID")]
        public int EmployeeRoleID { get; set; }
        [Display(Name = "Report To Employee ID")]
        public int? ReportToEmployeeID { get; set; }
        [Required]
        [Display(Name = "Organization ID")]
        public int OrganizationID { get; set; }
       
       
    }
}