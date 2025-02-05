﻿using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewComponents
{
    public class AddProductViewComponent : ViewComponent
    {
        private readonly IUnitOfWork<Categorie> category;

        public AddProductViewComponent(IUnitOfWork<Categorie> category)
        {
            this.category = category;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.Categories = category.Entity.GetAll().ToList();
            return View(ViewBag.ProductInfo);
        }
    }
}
