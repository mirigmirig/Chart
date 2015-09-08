using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace presentation.Responces
{
    public class ControllerResponce
    {
        public bool IsSuccessfull {get; set;}
        public string  ErrorMessage {get; set;}
        public string Data { get; set; }
    }
}