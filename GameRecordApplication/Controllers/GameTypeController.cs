using GameRecordApplication.Contracts;
using GameRecordApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameRecordApplication.Controllers
{
    public class GameTypeController : Controller
    {
        IRepository<GameTypes> GameTypes = new IRepository<GameTypes>;

        public GameTypeController()
        {
            
        }

        public GameTypeController(IRepository<GameTypes> gametype)
        {
            this.GameTypes = gametype;
        }

        // GET: GameType
        public ActionResult Index()
        {
            return View();
        }

        // GET: GameType/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GameType/Create
        public ActionResult Create()
        {
            GameTypes gameTypes = new GameTypes();
            return View(gameTypes);
        }

        // POST: GameType/Create
        [HttpPost]
        public ActionResult Create(GameTypes gameTypes)
        {
            if (!ModelState.IsValid)
            {
                return View(gameTypes);
            }
            else
            {
                GameTypes.Insert(gameTypes);
                GameTypes.Commit();

                return RedirectToAction("Index");
            }
        }

        // GET: GameType/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GameType/Edit/5
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

        // GET: GameType/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GameType/Delete/5
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
