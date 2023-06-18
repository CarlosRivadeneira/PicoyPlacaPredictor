using System.Web;
using System.Web.Mvc;

namespace Pico_y_Placa_Predictor
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
