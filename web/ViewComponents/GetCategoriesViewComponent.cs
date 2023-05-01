using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewComponents
{
    public class GetCategoriesViewComponent : ViewComponent
    {
        private readonly IUnitOfWork<Categorie> category;

        public GetCategoriesViewComponent(IUnitOfWork<Categorie> category)
        {
            this.category = category;
        }
        public IViewComponentResult Invoke()
        {
            IList<Categorie> data = category.Entity.GetAll().ToList();
            return View(data);
        }
    }
}
