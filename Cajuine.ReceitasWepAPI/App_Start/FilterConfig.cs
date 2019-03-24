using System.Web;
using System.Web.Mvc;

namespace Cajuine.ReceitasWepAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
