using System.Web;
using System.Web.Mvc;

namespace StoreForPolo_MVC_Angular2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
