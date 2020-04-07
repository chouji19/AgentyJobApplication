using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Connection
{
    public class MyResume
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public List<string> Skills { get; set; }
        public string Experience { get; set; }
    }
}
