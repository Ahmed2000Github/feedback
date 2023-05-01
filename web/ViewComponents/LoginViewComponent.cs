using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewModels;

namespace Web.ViewComponents
{
    public class LoginViewComponent : ViewComponent
    {
        private readonly SignInManager<Rater> signInManager;

        public LoginViewComponent(SignInManager<Rater> signInManager)
        {
            this.signInManager = signInManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            LoginVM data = new LoginVM()
            {
                ReturnUrl = null,
                ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            }; 
            return View(data);
        }
    }
}
