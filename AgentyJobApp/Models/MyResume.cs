using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentyJobApp.Models
{
    public class MyResume
    {
        public ObjectId _id { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string location { get; set; }
        public List<string> skills { get; set; }
        public string experience { get; set; }
    }
}
