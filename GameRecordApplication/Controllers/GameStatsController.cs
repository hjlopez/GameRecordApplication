﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameRecordApplication.Controllers
{
    public class GameStatsController : Controller
    {
        // GET: GameStats
        public ActionResult Index()
        {
            return View();
        }

        // GET: GameStats/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GameStats/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GameStats/Create
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

        // GET: GameStats/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GameStats/Edit/5
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

        // GET: GameStats/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GameStats/Delete/5
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