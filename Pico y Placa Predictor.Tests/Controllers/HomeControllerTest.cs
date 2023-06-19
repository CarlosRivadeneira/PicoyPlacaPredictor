using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pico_y_Placa_Predictor.Models;
using System;

namespace Pico_y_Placa_Predictor.Tests
{
    [TestClass]
    public class PicoyPlacaPredictorTest
    {
        [TestMethod]
        public void CanNotDrive()
        {
            PicoyPlacaPredictor predictor = new PicoyPlacaPredictor();
            string plate = "PBC-1230";
            string date = "2023-06-16";
            TimeSpan time = new TimeSpan(8, 30, 0);

            bool result = predictor.ConfPicoyPlaca(plate, date, time);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanDrive()
        {
            PicoyPlacaPredictor predictor = new PicoyPlacaPredictor();
            string plate = "GAB-5678";
            string date = "2023-06-17";
            TimeSpan time = new TimeSpan(16, 30, 0);

            bool result = predictor.ConfPicoyPlaca(plate, date, time);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void InvalidPlateFalse()
        {
            PicoyPlacaPredictor predictor = new PicoyPlacaPredictor();
            string plate = "C-5678";
            string date = "2023-06-17";
            TimeSpan time = new TimeSpan(16, 30, 0);

            bool result = predictor.ConfPicoyPlaca(plate, date, time);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void InvalidPlateTrue()
        {
            PicoyPlacaPredictor predictor = new PicoyPlacaPredictor();
            string plate = "C-5678";
            string date = "2023-06-17";
            TimeSpan time = new TimeSpan(16, 30, 0);

            bool result = predictor.ConfPicoyPlaca(plate, date, time);

            Assert.IsTrue(result);
        }

        public void WeekendsDate()
        {
            PicoyPlacaPredictor predictor = new PicoyPlacaPredictor();
            string plate = "C-5678";
            string date = "2023-06-18";
            TimeSpan time = new TimeSpan(8, 30, 0);

            bool result = predictor.ConfPicoyPlaca(plate, date, time);

            Assert.IsTrue(result);
        }
    }
}
