using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewsModels;

namespace Web.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult NoConnection()
        {
            ErrorVM Error = new ErrorVM()
            {
                Title = "No Connection Detected",
                Description = "Some error happened in your connection please check it and try again"
            };
            this.GetViewBag();
            return View("Errors",Error);
        }
       private void GetViewBag()
        {
            ViewBag.ReturnBack = Request.Headers["Referer"].ToString();
        }
    }
}
