using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class ParamGet
    {
        public ObjectId _id { get; set; }
        [BsonElement("ID")]
        public int ID { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("Value")]
        public double Value { get; set; }
        [BsonElement("Time")]

        public DateTime Time;
        [BsonElement("BinTime")]
        public double BinTime { get; set; } //для перевода времени в double для отображения
    }
}
