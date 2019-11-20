using GameRecordApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using static GameRecordApplication.ViewModels.MonsterHunterWeaponViewModel;
using PagedList.Mvc;
using PagedList;

namespace GameRecordApplication.Controllers
{
    public class WeaponController : Controller
    {
        // GET: Weapon
        public ActionResult Index(int? i)
        {
            //MonsterHunterWeaponViewModel viewmodel = new MonsterHunterWeaponViewModel();
            IEnumerable<Weapon> monsterHunters = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://mhw-db.com/weapons");
                //HTTP GET
                var responseTask = client.GetAsync("weapons");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Weapon>>();
                    readTask.Wait();

                    monsterHunters = readTask.Result;
                    monsterHunters = monsterHunters.ToList().ToPagedList(i ?? 1, 15);
                }
                else //web api sent error response 
                {
                    //log response status here..

                    //dotaHero = Enumerable.Empty<DotaHero>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(monsterHunters);
        }

        // GET: Weapon/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Weapon/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Weapon/Create
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

        // GET: Weapon/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Weapon/Edit/5
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

        // GET: Weapon/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Weapon/Delete/5
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
