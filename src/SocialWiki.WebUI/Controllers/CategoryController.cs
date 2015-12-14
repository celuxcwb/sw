using Microsoft.AspNet.Mvc;
using SocialWiki.WebUI.Models;
using SocialWiki.WebUI.Repository;

namespace sw.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryRepository _category = new CategoryRepository();
        public ActionResult Create()
        {
            return View();
        }


        public ActionResult Index()
        {

            return View(
                _category.FindAll());
        }

        public ActionResult Delete(string id)
        {
            var category = this._category.Find(id);
            this._category.Remove(id, category);
            
            return RedirectToAction("Index",
                 _category.FindAll());       
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            this._category.Add(category);
            return RedirectToAction("Index", _category.FindAll());
        }

        public ActionResult List()
        {

            return View(
                _category.FindAll());
        }

        public ActionResult Edit(string id)
        {
            return View(_category.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(string id, Category category)
        {
            this._category.Update(id, category);

            return RedirectToAction("Index",
                 _category.FindAll());
        }


    }
}