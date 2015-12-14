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
using SocialWiki.WebUI.ViewModels.Solver;
using MongoDB.Bson;

namespace sw.Controllers
{
    public class SolverController : Controller
    {
        private SolverRepository _solver = new SolverRepository();
        public ActionResult Create()
        {
            var solverMode = new SolverModel();
            CityRepository _city = new CityRepository();
            solverMode.Cities = _city.FindAll();
            return View(solverMode);
        }


        public ActionResult Index()
        {

            return View(
                _solver.FindAll());
        }

        public ActionResult Delete(string id)
        {
            var solver = this._solver.Find(id);
            this._solver.Remove(id, solver);

            return RedirectToAction("Index",
                 _solver.FindAll());
        }



        [HttpPost]
        public ActionResult Create(SolverModel solverModel)
        {
            
            this._solver.Add(solverModel.solver);
            return RedirectToAction("Index", _solver.FindAll());
        }

        public ActionResult List()
        {

            return View(
                _solver.FindAll());
        }

        public ActionResult Edit(string id)
        {
            var solverMode = new SolverModel();
            var _city = new CityRepository();
            solverMode.solver = _solver.Find(id);
            solverMode.Cities = _city.FindAll();
            return View(solverMode);
        }

        [HttpPost]
        public ActionResult Edit(string id, SolverModel solverModel)
        {
            this._solver.Update(id, solverModel.solver);

            return RedirectToAction("Index",
                 _solver.FindAll());
        }


    }
}