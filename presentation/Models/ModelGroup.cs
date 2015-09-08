using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace presentation.Models
{
    /// <summary>
    /// Group includes all defined model objects + response(possible error messages)
    /// </summary>
    public class ModelGroup
    {
        public Employee emp { get; set; }
        public EmployeeDeleteParams del { get; set; }
        public ManagerEdit edit { get; set; }
        public string ResponceMessage { get; set; }
    }
}