using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using SocialWiki.WebUI.Models;
using SocialWiki.WebUI.Services;
using SocialWiki.WebUI.Controllers;
using SocialWiki.WebUI.Models;
using SocialWiki.WebUI.Repository.Contract;
using SocialWiki.WebUI.Repository;

namespace SocialWiki.WebUI.Controllers
{
    public class ComplaintController : Controller
    {
        private ComplaintRepository _city = new ComplaintRepository();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Explore()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
