using Core.Entities;
using Infrastructure;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewsModels;

namespace Web.Controllers
{
    public class CategorieController : Controller
    {
        public IActionResult Mobiles()
        {
            ViewBag.IsCategory = true;
            ViewBag.Category = "Mobiles";
            return View("Products");
        }
        public IActionResult Computers()
        {
            ViewBag.IsCategory = true;
            ViewBag.Category = "Computers";
            return View("Products");
        }
        public IActionResult Others()
        {
            ViewBag.IsCategory = true;
            ViewBag.Category = "Others";
            return View("Products");
        }
        public IActionResult Products(string name)
        {
            ViewBag.IsCategory = true;
            ViewBag.Category = name;
            return View();
        }
        public IActionResult GetLatest()
        {
            ViewBag.Category = "Recent";
            return View("Products");
        } 
        public IActionResult GetHot()
        {
            ViewBag.Category = "Hot";
            return View("Products");
        }
    }
}