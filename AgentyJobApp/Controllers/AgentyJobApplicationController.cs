using AgentyJobApp.Database;
using AgentyJobApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgentyJobApp.Controllers
{
    public class AgentyJobApplicationController : ApiController
    {

        // GET: api/AgentyJobApplication/5
        public ResponseGet Get(string id)
        {
            MongoDBProcess process = new MongoDBProcess();
            return process.getResumeById(id);
        }

        // POST: api/AgentyJobApplication
        public ResponseCreate Post([FromBody]MyResume value)
        {
            MongoDBProcess process = new MongoDBProcess();
            var result = process.createResume(value);
            return result;
        }

    }
}
