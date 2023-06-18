using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pico_y_Placa_Predictor.Models
{
    public class PicoyPlacaPredictor
    {
        public bool ConfPicoyPlaca(string plate, DateTime date, TimeSpan time)
        {
            int ultDig = int.Parse(plate.Substring(plate.Length - 1));

            DayOfWeek dayOfWeek = date.DayOfWeek;
            bool confPicoyPlacaDay = false;

            switch (dayOfWeek) 
            {
                case DayOfWeek.Monday:
                    if (ultDig == 1 || ultDig == 2)
                    {
                        confPicoyPlacaDay = true;
                    }
                    break;
                case DayOfWeek.Tuesday:
                    if (ultDig == 3 ||  ultDig == 4)
                    {
                        confPicoyPlacaDay = true;
                    }
                    break;
                case DayOfWeek.Wednesday:
                    if (ultDig == 5 || ultDig == 6)
                    {
                        confPicoyPlacaDay = true;
                    }
                    break;
                case DayOfWeek.Thursday:
                    if (ultDig == 7 || ultDig == 8)
                    {
                        confPicoyPlacaDay = true;
                    }
                    break;
                case DayOfWeek.Friday:
                    if (ultDig == 9 || ultDig == 0)
                    {
                        confPicoyPlacaDay = true;
                    }
                    break;
            }

            TimeSpan startTimeAM = new TimeSpan(7, 0, 0);
            TimeSpan endTimeAM = new TimeSpan(9, 30, 0);
            TimeSpan startTimePM = new TimeSpan(16, 0, 0);
            TimeSpan endTimePM = new TimeSpan(19, 30, 0);

            bool confPicoyPlacaTime = (time >= startTimeAM && time <= endTimeAM) ||
                                    (time >= startTimePM && time <= endTimePM);

            return confPicoyPlacaDay && confPicoyPlacaTime;
        }
    }
}