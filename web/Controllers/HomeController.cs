using Core.Entities;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Util;
using Web.ViewModels;
using Web.ViewsModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Send(EmailVM email)
        {
            if (InfoHandler.IsConnect())
            {
                MimeMessage message = new MimeMessage();

                MailboxAddress from = new MailboxAddress("Admin",
                "ahmedelrhaouti2000@gmail.com");
                message.From.Add(from);

                MailboxAddress to = new MailboxAddress(email.From,
                "ahmedelrhaouti2000@gmail.com");
                message.To.Add(to);

                message.Subject = "This is email subject";
                BodyBuilder bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody =email.Body;
                message.Body = bodyBuilder.ToMessageBody();
                SmtpClient client = new SmtpClient();
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate("ahmedelrhaouti2000@gmail.com", "wxcvbnqsd123");
                client.Send(message);
                client.Disconnect(true);
                client.Dispose();
                return Redirect(HttpContext.Request.Headers["Referer"]);
            }
            return RedirectToAction("NoConnection", "Error");
        }
     

    }
}
