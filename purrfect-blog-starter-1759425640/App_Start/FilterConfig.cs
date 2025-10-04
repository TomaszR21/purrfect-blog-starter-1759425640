using System.Web;
using System.Web.Mvc;

namespace purrfect_blog_starter_1759425640
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
