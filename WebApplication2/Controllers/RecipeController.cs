using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class RecipeController : Controller
    {
        List<Recipe> arr = new List<Recipe>();
        public RecipeController()
        {

            arr.Add(new Recipe() { Id = 1, Name = "Abc", Ingredients = "asjdhasjkhdjkh", Method = "sjkdklasjklhdjkhasjk" });
            arr.Add(new Recipe() { Id = 1, Name = "Abc", Ingredients = "asjdhasjkhdjkh", Method = "sjkdklasjklhdjkhasjk" });
            arr.Add(new Recipe() { Id = 1, Name = "Abc", Ingredients = "asjdhasjkhdjkh", Method = "sjkdklasjklhdjkhasjk" });
           
        }


        public ActionResult Index()
        {
            return View(arr);
        }

       
        public ActionResult create()
        {
            return View();
        }

         [HttpPost]

        public ActionResult create(Recipe rec)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var ed = arr.Find(d=> d.Id == id);
            return View(ed);

        }
        public ActionResult Details(int id)
        {

            var ed = arr.Find(d => d.Id == id);
            return View(ed);

        }

        public ActionResult Delete(int id)
        {

            var ed = arr.Find(d => d.Id == id);
            return View(ed);

        }
	}
}