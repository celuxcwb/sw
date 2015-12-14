using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;
using SocialWiki.WebUI.Models;
using SocialWiki.WebUI.Services;
using SocialWiki.WebUI.Controllers;
using SocialWiki.WebUI.Models;
using SocialWiki.WebUI.Repository.Contract;
using SocialWiki.WebUI.Repository;

namespace sw.Controllers
{
    public class CityController : Controller
    {
        private CityRepository _city = new CityRepository();
        public ActionResult Create()
        {
            return View();
        }


        public ActionResult Index()
        {

            return View(
                _city.FindAll());
        }

        public ActionResult Delete(string id)
        {
            var city = this._city.Find(id);
            this._city.Remove(id, city);

            return RedirectToAction("Index",
                 _city.FindAll());
        }

        [HttpPost]
        public ActionResult Create(City city)
        {
            this._city.Add(city);
            return RedirectToAction("Index", _city.FindAll());
        }

        public ActionResult List()
        {

            return View(
                _city.FindAll());
        }

        public ActionResult Edit(string id)
        {
            return View(_city.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(string id, City city)
        {
            this._city.Update(id, city);

            return RedirectToAction("Index",
                 _city.FindAll());
        }


    }
}