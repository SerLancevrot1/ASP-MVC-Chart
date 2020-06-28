using ASPNET_MVC_ChartsDemo.Models;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4
{
    public class ChartSetting
    {
		public string Sinse { get; set; }
		public string For { get; set; }
		public int Id { get; set; }

		public ChartSetting(string sinseData, string forData , int id)
		{
			Sinse = sinseData;
			For = forData;
			Id = id;
		}

		public List<DataPoint> NoteDataPoints()
		{
			IMongoCollection<ParamGet> Parametrs = MongoConnect.connect();
			FilterDefinition<ParamGet> filter = Builders<ParamGet>.Filter.Gt("Time", Sinse) &
			   Builders<ParamGet>.Filter.Lt("Time", For) & Builders<ParamGet>.Filter.Eq("ID", Id);
			List<ParamGet> listP = Parametrs.Find(filter).ToList(); //результат по фильтру
			List<DataPoint> dataPoints1 = new List<DataPoint>(); // массив точек
			double time;
			foreach (var i in listP)
			{
				DateTime DATA = new DateTime(i.Time.Year, i.Time.Month, i.Time.Day, i.Time.Hour, i.Time.Minute, i.Time.Second);
				time = ((DateTimeOffset)DATA).ToUnixTimeSeconds() * 1000;
				dataPoints1.Add(new DataPoint(time, i.Value)); //время + значение , добавляем точки												   //ViewBag.DataPoints = i.BinTime ;
			}
			return dataPoints1;
		}
	}
}

