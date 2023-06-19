using System;
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

            ViewBag.plate = plate;
            ViewBag.Date = date;
            ViewBag.Time = time.ToString(@"hh\:mm");

            // Crea una instancia de la clase PicoyPlacaPredictor
            var predictor = new PicoyPlacaPredictor();

            // Llama al método ConfPicoyPlaca para verificar la disponibilidad
            bool canDrive = predictor.ConfPicoyPlaca(plate, date, time);

            // Pasa el resultado a la vista Result
            ViewBag.CanDrive = canDrive;

            return View("Result");
        }
    }
}
