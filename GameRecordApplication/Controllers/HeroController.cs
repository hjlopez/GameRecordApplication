using GameRecordApplication.Contracts;
using GameRecordApplication.Models;
using GameRecordApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace GameRecordApplication.Controllers
{
    public class HeroController : Controller
    {
        IRepository<DotaHeroAttribute> dotaHeroAttr;

        public HeroController(IRepository<DotaHeroAttribute> dotaHeroAttr)
        {
            this.dotaHeroAttr = dotaHeroAttr;
        }
        // GET: Hero
        public ActionResult Index(int? i, string search = "", string Category = "")
        {
            HeroViewModel heroViewModel = new HeroViewModel();
            IEnumerable<DotaHero> dotaHero = null;

            if(Category == "" || Category == "dota2")
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://api.opendota.com/api/heroes");
                    //HTTP GET
                    var responseTask = client.GetAsync("heroes");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<IList<DotaHero>>();
                        readTask.Wait();

                        dotaHero = readTask.Result;
                        heroViewModel.DotaHeroes = dotaHero.Where(a => a.Localized_name.Contains(search) || search == null).ToList().ToPagedList(i ?? 1,10);
                    }
                    else //web api sent error response 
                    {
                        //log response status here..

                        dotaHero = Enumerable.Empty<DotaHero>();

                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                    }
                }
            }
            heroViewModel.DotaHeroAttributes = dotaHeroAttr.Collection();

            return View(heroViewModel);
        }

        // search
        public ActionResult Search(string search)
        {
            return View();
        }

        // attribute
        public ActionResult CreateAttr()
        {
            return View("CreateAttribute");
        }

        [HttpPost]
        public ActionResult CreateAttr(DotaHeroAttribute dotaHeroAttribute)
        {
            if (!ModelState.IsValid)
            {
                return View(dotaHeroAttribute);
            }
            else
            {

                dotaHeroAttr.Insert(dotaHeroAttribute);
                dotaHeroAttr.Commit();

                return RedirectToAction("Index", new { Category = "attr" });

            }
        }

        // GET: Hero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hero/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
