using System.Web;
using System.Web.Mvc;

namespace Nomineer_een_leverancier
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
