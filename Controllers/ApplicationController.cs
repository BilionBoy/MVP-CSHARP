using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MeuMVP.Controllers
{
    public class ApplicationController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.RouteData.Values["controller"]?.ToString()?.ToLower();

            if (controller == "home")
            {
                ViewData["Layout"] = "~/Views/Shared/_HomeLayout.cshtml"; // Landing Page
            }
            else
            {
                ViewData["Layout"] = "~/Views/Shared/_Layout.cshtml"; // Admin padrão
            }

            base.OnActionExecuting(context);
        }
    }
}
