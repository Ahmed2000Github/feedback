using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewsModels;

namespace Web.ViewComponents
{
    public class GetProductInfoViewComponent : ViewComponent
    {
        private readonly IUnitOfWork<Product> product;
        private readonly IUnitOfWork<Rating> rating;

        public GetProductInfoViewComponent(IUnitOfWork<Rating> rating,  IUnitOfWork<Product> product)
        {
            this.product = product;
            this.rating = rating;
        }
        public IViewComponentResult Invoke(Guid Id)
        {
            var AllRatings = rating.Entity.GetAll().Where(i => i.ProductId == Id).Where(x => x.Level != -1);
            var data = new ProductGetVM()
            {
                Product = product.Entity.GetById(Id),
                Max = AllRatings.Count()!=0 ? AllRatings.Max(x => x.Level):-1,
                Min = AllRatings.Count() != 0 ? AllRatings.Min(x => x.Level) : -1
            };
            return View(data);
        }
    }
}
