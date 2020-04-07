using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Connection
{
    public class MongoDB
    {

        public void connectDataBase()
        {
            MongoClient dbClient = new MongoClient("mongodb+srv://admin:eYDQ2yt7H3hD9B8C@cluster0-ctarh.mongodb.net/test?authSource=admin&replicaSet=Cluster0-shard-0&readPreference=primary&appname=MongoDB%20Compass%20Community&ssl=true");

            var database = dbClient.GetDatabase("ResumeDB");
            var collection = database.GetCollection<MyResume>("MyResume");
            MyResume resume = new MyResume() { 
                Email="camilobu1.9@gmail.com",
                Experience= "7 years",
                Location = "Brisbane",
                Phone= "1923801238",
                Skills = new List<string>(new string[] { "element1", "element2", "element3" })
        };
            collection.InsertOne(resume);
        }

    }
}
