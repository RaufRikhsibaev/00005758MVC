using System.Web;
using System.Web.Mvc;

namespace DSCC_CW_MVC_5758
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
