using Microsoft.AspNetCore.Mvc;

namespace class01.Controllers.Base
{
    public class BaseController : Controller
    {
        public void GeneralMessage( string message, string messageType )
        {
            if (messageType.Equals("error"))
                ViewData["error"] = "ERROR";
            else if (messageType.Equals("warning"))
                ViewData["warning"] = "AVISO";
            else if (messageType.Equals("success"))
                ViewData["success"] = "SUCESSO";
            else
                ViewData["info"] = "info";

            ViewData["Message"] = message;
        }
    }
}
