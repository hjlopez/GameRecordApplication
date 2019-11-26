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
    public class GameStatsController : Controller
    {
        IRepository<Game> game;
        IRepository<Season> season;
        IRepository<Match> match;

        public GameStatsController(IRepository<Game> game, IRepository<Season> season, IRepository<Match> match)
        {
            this.game = game;
            this.season = season;
            this.match = match;
        }

        // GET: GameStats
        public ActionResult Index(string Category = "", bool ShowMessage = false, string Message = "", bool IsErrorMessage = false)
        {
            List<Game> listGame;
            MatchViewModel vmodel = new MatchViewModel();
            IEnumerable<long> gameIdList;
            IEnumerable<Match> matches;
            ViewBag.SuccessMessage = "";
            long gameId = 0;

            if (ShowMessage)
            {
                ViewBag.SuccessMessage = Message;
            }

            vmodel.IsErrorMessage = IsErrorMessage;
            listGame = game.Collection().ToList();
            matches = match.Collection().ToList();
            

            if (Category != "")
            {
                gameIdList = listGame.Where(a => a.GameName == Category).Select(a => a.GameId);

                foreach (var id in gameIdList)
                {
                    gameId = id;
                }

                matches = matches.Where(a => a.GameId == gameId);
            }
            vmodel.ListOfSeasons = season.Collection();

            vmodel.ListOfGames = listGame;
            vmodel.ListOfMatches = matches;

            return View(vmodel);
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
