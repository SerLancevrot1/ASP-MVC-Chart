using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ASPNET_MVC_ChartsDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Newtonsoft.Json;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    { 
        [HttpGet]
		public ActionResult Index()
		{
            DataChange data = new DataChange();
			return View(data);
		}
        [HttpPost]
		public ActionResult second(DataChange data)
		{
            string SinseData = data.Sinse;
            string ForData = data.For;
            int ID = data.Id;



            ChartSetting chartSetting = new ChartSetting(SinseData, ForData, ID);
            List<DataPoint> dataPoint = chartSetting.NoteDataPoints();
            ViewBag.DataPoints1 = JsonConvert.SerializeObject(dataPoint);

            int id2 = 2;
            ChartSetting chartSetting1 = new ChartSetting(SinseData, ForData, id2);
            List<DataPoint> dataPoint1 = chartSetting1.NoteDataPoints();
            ViewBag.DataPoints2 = JsonConvert.SerializeObject(dataPoint1);

            int id3 = 3;
            ChartSetting chartSetting2 = new ChartSetting(SinseData, ForData, id3);
            List<DataPoint> dataPoint2 = chartSetting2.NoteDataPoints();
            ViewBag.DataPoints3 = JsonConvert.SerializeObject(dataPoint2);
            
            //string Sinse = "12:40 16.03.2020 ";
            //string For = "20:45 16.03.2020 ";
            //int id1 = 1;

            return View();
        }

	}
}
