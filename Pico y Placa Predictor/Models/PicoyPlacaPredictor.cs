using System;

namespace Pico_y_Placa_Predictor.Models
{
    public class PicoyPlacaPredictor
    {
        // Función que maneja la confirmación de la disponibilidad de que circule el vehículo
        public bool ConfPicoyPlaca(string plate, DateTime date, TimeSpan time)
        {
            // Obtiene el último dígito de la placa
            int ultDig = int.Parse(plate.Substring(plate.Length - 1));

            // Obtiene el nombre del día de la semana
            DayOfWeek dayOfWeek = date.DayOfWeek;
            
            // Variable que almacena la disponibilidad de circulación del vehículo según el día
            bool confPicoyPlacaDay = false;

            // Condiciones que verifican el día de la semana y el último dígito de la placa con DayOfWeek
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

            // Lapsos de tiempo en los que se aplica Pico y Placa
            TimeSpan startTimeAM = new TimeSpan(7, 0, 0);
            TimeSpan endTimeAM = new TimeSpan(9, 30, 0);
            TimeSpan startTimePM = new TimeSpan(16, 0, 0);
            TimeSpan endTimePM = new TimeSpan(19, 30, 0);

            // Variable que almacena la disponibilidad de circulación del vehículo según la hora
            bool confPicoyPlacaTime = false;
            
            // Condición que verifica que el time seleccionado se encuentre dentro de los lapsos de tiempo
            if ((time >= startTimeAM && time <= endTimeAM) || (time >= startTimePM && time <= endTimePM))
            {
                confPicoyPlacaTime = true;
            }

            // Retorna el resultado de la condición del día y hora (True o False)
            return confPicoyPlacaDay && confPicoyPlacaTime;
        }
    }
}