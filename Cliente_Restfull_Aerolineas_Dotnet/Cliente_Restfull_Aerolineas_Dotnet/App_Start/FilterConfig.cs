using System.Web;
using System.Web.Mvc;

namespace Cliente_Restfull_Aerolineas_Dotnet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
