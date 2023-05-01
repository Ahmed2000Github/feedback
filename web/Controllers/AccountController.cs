using Core;
using Core.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Util;
using Web.ViewModels;
using Web.ViewsModels;

namespace Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IHostingEnvironment hosting;
        private readonly UserManager<Rater> userManager;
        private readonly SignInManager<Rater> signInManeger;

        public IUnitOfWork<Rater> _Rater { get; }
        [Obsolete]
        public AccountController(IHostingEnvironment hosting, IUnitOfWork<Rater> rater,
            UserManager<Rater> userManager, SignInManager<Rater> signInManeger)
        {
            this.hosting = hosting;
            _Rater = rater;
            this.userManager = userManager;
            this.signInManeger = signInManeger;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(RaterVM rater)
        {

            string img = "default.png";
            Guid Gid = Guid.NewGuid();
            if (ModelState.IsValid)
            {
                if (rater.File != null)
                {
                    img = Gid.ToString() + rater.File.FileName.ToString().Substring(rater.File.FileName.Length - 4);
                    string uploads = Path.Combine(hosting.WebRootPath, @"Images\Users");
                    string fullpath = Path.Combine(uploads, img);
                    rater.File.CopyTo(new FileStream(fullpath, FileMode.Create));
                }
                Rater _rater = new Rater()
                {
                    Id = Gid,
                    FirstName = rater.FirstName,
                    LastName = rater.LastName,
                    BirthDay = rater.BirthDay, 
                    Gender = rater.Gender,
                    AvatarUrl = img,
                    Age = InfoHandler.GetAge(rater.BirthDay),
                    UserName = rater.UserName,
                    Email = rater.Email
                };
                var result = await userManager.CreateAsync(_rater, rater.Password);
                if (result.Succeeded)
                {
                    await signInManeger.SignInAsync(_rater, false);
                    return RedirectToAction("Index", "Home");
                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        public async Task<IActionResult> LoginAsync(LoginVM login)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManeger.PasswordSignInAsync(login.UserName, login.Password, login.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View("Create");
        }
      
        [AllowAnonymous]
        [HttpPost]
        public IActionResult ExternalLogin(string provider , string returnUrl)
        {
            var redirectUrl = Url.Action("ExternalLoginCallBack","Account",new { ReturnUrl = returnUrl });
            var properties = signInManeger.ConfigureExternalAuthenticationProperties(provider,redirectUrl);
            return new ChallengeResult(provider,properties);
        }
        [AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallBackAsync(string returnUrl= null, string remoteError = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (remoteError != null)
            {
                ModelState.AddModelError(string.Empty, $"Error loading external provider: {remoteError}");
                return View("Index", "Home");
            }
            var info = await signInManeger.GetExternalLoginInfoAsync();
            if (info == null)
            {
                ModelState.AddModelError(string.Empty, "Error loading external login informtions");
                return View("Index", "Home");
            }
            var result = await signInManeger.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey,
               isPersistent: false, bypassTwoFactor: true);
            if (result.Succeeded)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);
                if (email != null)
                {
                    var user = await userManager.FindByEmailAsync(email);
                    if (user == null)
                    {
                        string imgName = "default.png";
                        Guid Gid = Guid.NewGuid();
                        if (info.Principal.HasClaim(c => c.Type == "Account:picture"))
                        {
                        string  img =  info.Principal.FindFirst("Account:picture").Value;
                            imgName = Gid.ToString() +".jpg";
                            string uploads = Path.Combine(hosting.WebRootPath, @"Images\Users");
                            string fullpath = Path.Combine(uploads, imgName);
                            using (WebClient client = new WebClient())
                            {
                                client.DownloadFile(img, fullpath);
                            }
                        }
                        string Name = info.Principal.FindFirstValue(ClaimTypes.Name);
                        string[] FullName = Name.Split(new char[] { ' ' }, 2);
                        user = new Rater()
                        {
                            Id = Gid,
                            FirstName = FullName[0],
                            LastName = FullName[1],
                            AvatarUrl= imgName,
                            UserName = Name.Replace(" ",""),
                            Email = info.Principal.FindFirstValue(ClaimTypes.Email)
                        };
                     
                        await userManager.CreateAsync(user);

                       
                    }
                   var result2 = await userManager.AddLoginAsync(user,info);
                    if (result2.Succeeded)
                    {
                        await signInManeger.SignInAsync(user,false);
                    return LocalRedirect(returnUrl);
                    }
                   
                }
            }
            return View("Index", "Home");
        }
        public async Task<IActionResult> LogoutAsync()
        {
            await signInManeger.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
        public IActionResult GetProfile()
        {
            return View();
        }
    }
}
