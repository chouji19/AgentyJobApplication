using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgentyJobApp.Models
{
    public class ResponseGet
    {
        public MyResume resume { get; set; }
        public bool Success { get; set; }
        public string ErrorDescription { get; set; }
    }
}