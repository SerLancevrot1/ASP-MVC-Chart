using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4
{
    public static class MongoConnect
    {
        public static IMongoCollection<ParamGet> connect()
        {
            IMongoCollection<ParamGet> Parametrs;
            string connectionString = "mongodb://localhost";
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase("diplom");
            Parametrs = database.GetCollection<ParamGet>("1"); 
            return Parametrs;
        }
    }
}
