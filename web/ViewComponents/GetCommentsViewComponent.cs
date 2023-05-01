using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewsModels;

namespace Web.ViewComponents
{
    public class GetCommentsViewComponent : ViewComponent
    {
        private readonly IUnitOfWork<Rater> rater;
        private readonly IUnitOfWork<Rating> rating;

        public GetCommentsViewComponent(IUnitOfWork<Rating> rating, IUnitOfWork<Rater> rater)
        {
            this.rater = rater;
            this.rating = rating;
        }
        public IViewComponentResult Invoke(Guid Id)
        {
            var AllRatings = rating.Entity.GetAll().Where(i => i.ProductId == Id);
            List<RatingsVM> RatingWithRaters = new List<RatingsVM>();
            foreach (var item in AllRatings.Where(x => x.Level != -1))
            {
                RatingWithRaters.Add(new RatingsVM()
                {
                    Rating = item,
                    Rater = rater.Entity.GetById(item.RaterId)
                });
            }
            return View(RatingWithRaters);
        }
    }
}
