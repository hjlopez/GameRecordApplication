using GameRecordApplication.Contracts;
using GameRecordApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameRecordApplication.Controllers
{
    public class SeasonController : Controller
    {
        IRepository<Season> repository;

        public SeasonController(IRepository<Season> season)
        {
            this.repository = season;
        }

        // GET: Season
        public ActionResult Index()
        {
            return View();
        }

        // GET: Season/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Season/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Season/Create
        [HttpPost]
        public ActionResult Create(Season season, string Category = null)
        {
            if (!ModelState.IsValid)
            {
                //return View("Index");
                return RedirectToAction("Index", "GameStats", new { Category = "Billiards" , ShowMessage = true, Message = "Error on Adding", IsErrorMessage = true });
            }
            else
            {
                repository.Insert(season);
                repository.Commit();

                return RedirectToAction("Index", "GameStats", new { Category = "Billiards", ShowMessage = true, Message = "New Season Added", IsErrorMessage = false });
            }
        }

        // GET: Season/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Season/Edit/5
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

        // GET: Season/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Season/Delete/5
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
