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
        IRepository<GameTypes> GameTypes;


        public GameTypeController(IRepository<GameTypes> gametype)
        {
            this.GameTypes = gametype;
        }

        // GET: GameType
        public ActionResult Index()
        {
            List<GameTypes> types = GameTypes.Collection().ToList();
            return View(types);
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
        public ActionResult Edit(long Id)
        {
            GameTypes types = GameTypes.Find(Id);
            if (types == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(types);
            }
        }

        // POST: GameType/Edit/5
        [HttpPost]
        public ActionResult Edit(GameTypes gameTypes, long Id)
        {
            GameTypes typeToEdit = GameTypes.Find(Id);

            if (typeToEdit == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View(typeToEdit);
                }

                typeToEdit.Type = gameTypes.Type;

                GameTypes.Commit();

                return RedirectToAction("Index");
            }
        }

        // GET: GameType/Delete/5
        public ActionResult Delete(long Id)
        {
            GameTypes typeToDelete = GameTypes.Find(Id);

            if (typeToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(typeToDelete);
            }
        }

        // POST: GameType/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(long Id)
        {
            GameTypes typeToDelete = GameTypes.Find(Id);

            if (typeToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                GameTypes.Delete(Id);
                GameTypes.Commit();
                return RedirectToAction("Index");
            }
        }
    }
}
