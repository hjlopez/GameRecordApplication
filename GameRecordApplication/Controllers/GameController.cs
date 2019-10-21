using GameRecordApplication.Contracts;
using GameRecordApplication.Models;
using GameRecordApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameRecordApplication.Controllers
{
    public class GameController : Controller
    {
        IRepository<Game> context;
        IRepository<GameTypes> gType;

        public GameController(IRepository<Game> game, IRepository<GameTypes> gType)
        {
            this.context = game;
            this.gType = gType;
        }

        // GET: Game
        public ActionResult Index()
        {
            List<Game> game = context.Collection().ToList();
            return View(game);
        }

        // GET: Game/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Game/Create
        public ActionResult Create()
        {
            GameViewModel gameViewModel = new GameViewModel();
            gameViewModel.Game = new Game();
            gameViewModel.Types = gType.Collection();

            return View(gameViewModel);
        }

        // POST: Game/Create
        [HttpPost]
        public ActionResult Create(Game game)
        {
            if (!ModelState.IsValid)
            {
                return View(game);
            }
            else
            {
                
                context.Insert(game);
                context.Commit();

                return RedirectToAction("Index");
               
            }
        }

        // GET: Game/Edit/5
        public ActionResult Edit(int Id)
        {
            Game games = context.Find(Id);
            
            if (games == null)
            {
                return HttpNotFound();
            }
            else
            {
                GameViewModel gameViewModel = new GameViewModel();

                gameViewModel.Game = games;
                gameViewModel.Types = gType.Collection();
                return View(gameViewModel);
            }
        }

        // POST: Game/Edit/5
        [HttpPost]
        public ActionResult Edit(GameViewModel games, long Id)
        {
            Game gameToEdit = context.Find(Id);

            if (games == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View(games);
                }

                gameToEdit.GameName = games.Game.GameName;
                gameToEdit.GameType = games.Game.GameType;
                gameToEdit.MaxPlayers = games.Game.MaxPlayers;
                gameToEdit.HasSeason = games.Game.HasSeason;

                context.Commit();

                return RedirectToAction("Index");
            }
        }

        // GET: Game/Delete/5
        public ActionResult Delete(int Id)
        {
            Game games = context.Find(Id);
            if (games == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(games);
            }
        }

        // POST: Game/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(long Id)
        {
            Game gameToDelete = context.Find(Id);

            if (gameToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                context.Delete(Id);
                context.Commit();
                return RedirectToAction("Index");
            }
        }
    }
}
