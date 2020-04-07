using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgentyJobApp.Models
{
    public class ResponseCreate
    {
        public bool Success { get; set; }
        public string ErrorDescription { get; set; }
        public string idResume { get; set; }
    }
}