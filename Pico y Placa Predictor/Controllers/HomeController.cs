﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pico_y_Placa_Predictor.Models;

namespace Pico_y_Placa_Predictor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ConfPicoyPlaca(string plate, string date, TimeSpan time)
        {
            PicoyPlacaPredictor predictor = new PicoyPlacaPredictor();
            bool disponibility = predictor.ConfPicoyPlaca(plate, date, time);

            ViewBag.disponibility = disponibility;

            return View("message");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}