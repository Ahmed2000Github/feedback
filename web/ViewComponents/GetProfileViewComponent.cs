using Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewsModels;

namespace Web.ViewComponents
{
    public class GetProfileViewComponent : ViewComponent
    {
        private readonly UserManager<Rater> userManeger;
        private readonly SignInManager<Rater> signInManeger;
        private readonly IHttpContextAccessor contextAccessor;
        private readonly IUnitOfWork<Rating> rating;

        public GetProfileViewComponent(UserManager<Rater> userManeger, SignInManager<Rater> signInManeger, IHttpContextAccessor contextAccessor
            , IUnitOfWork<Rating> rating)
        {
            this.userManeger = userManeger;
            this.signInManeger = signInManeger;
            this.contextAccessor = contextAccessor;
            this.rating = rating;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (signInManeger.IsSignedIn(contextAccessor.HttpContext.User))
            {
                Rater rater = await userManeger.FindByNameAsync(contextAccessor.HttpContext.User.Identity.Name);
                if (rater != null)
                {
                    Guid Id = rater.Id;
                    int count = rating.Entity.GetAll().Where(x => x.RaterId == Id).Count();
                    GetProfileVM data = new GetProfileVM()
                    {
                        rater = rater,
                        CommentsCount = count
                    };
                    return View(data);
                }
            }
            return View("Index","Home");


        }
    }
}
