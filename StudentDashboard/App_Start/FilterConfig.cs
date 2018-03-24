using System.Web;
using System.Web.Mvc;
using WebApplication1.Filters;

namespace StudentDashboard
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomHandlerErrorAttribute());
           // filters.Add(new CustomResultFilter());
        }
    }
}
