using AgentyJobApp.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentyJobApp.Database
{
    public class MongoDBProcess
    {
        private string conenctionString;
        public MongoDBProcess()
        {
            conenctionString = ConfigurationManager.AppSettings["connectionMongo"];
        }

        public ResponseCreate createResume(MyResume resume)
        {
            try
            {
                MongoClient dbClient = new MongoClient(conenctionString);
                var resp = new ResponseCreate();
                var database = dbClient.GetDatabase("ResumeDB");
                var collection = database.GetCollection<MyResume>("MyResume");
                collection.InsertOne(resume);
                resp.Success = true;
                resp.idResume = resume._id.ToString();
                return resp;
            }
            catch (Exception ex)
            {
                return new ResponseCreate()
                {
                    Success = false,
                    ErrorDescription = ex.Message.ToString()
                };
            }
        }

        public ResponseGet getResumeById(string _id)
        {
            try
            {
                MongoClient dbClient = new MongoClient(conenctionString);
                var resp = new ResponseGet();
                var database = dbClient.GetDatabase("ResumeDB");
                var collection = database.GetCollection<MyResume>("MyResume");

                var filter = Builders<MyResume>.Filter.Eq("_id", ObjectId.Parse(_id));
                var resume = collection.Find(filter).FirstOrDefault();
                resp.Success = true;
                resp.resume = resume;
                return resp;
            }
            catch (Exception ex)
            {
                return new ResponseGet()
                {
                    Success = false,
                    ErrorDescription = ex.Message.ToString()
                };
            }


        } 

    }
}
