using Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewComponents
{
    public class SignUpViewComponent : ViewComponent
    {
        private readonly UserManager<Rater> userManeger;
        private readonly SignInManager<Rater> signInManeger;
        private readonly IHttpContextAccessor contextAccessor;

        public SignUpViewComponent(UserManager<Rater> userManeger, SignInManager<Rater> signInManeger, IHttpContextAccessor contextAccessor)
        {
            this.userManeger = userManeger;
            this.signInManeger = signInManeger;
            this.contextAccessor = contextAccessor;
        }
        public async Task<IViewComponentResult> InvokeAsync(int check)
        {   ViewBag.check = check;
            Rater rater = null;
            if (signInManeger.IsSignedIn(contextAccessor.HttpContext.User))
            {
                
                rater = await userManeger.FindByNameAsync(contextAccessor.HttpContext.User.Identity.Name);
            }
            return View(rater);
        }
    }
}
