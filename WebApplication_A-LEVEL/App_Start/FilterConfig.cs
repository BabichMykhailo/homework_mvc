using System.Web;
using System.Web.Mvc;

namespace WebApplication_A_LEVEL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
