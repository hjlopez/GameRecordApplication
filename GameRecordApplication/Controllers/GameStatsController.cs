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

        public GameStatsController(IRepository<Game> game, IRepository<Season> season)
        {
            this.game = game;
            this.season = season;
        }

        // GET: GameStats
        public ActionResult Index(string Category = "", bool ShowMessage = false, string Message = "", bool IsErrorMessage = false)
        {
            List<Game> listGame;
            MatchViewModel vmodel = new MatchViewModel();
            List<Season> seasons;
            IEnumerable<long> gameId;
            ViewBag.SuccessMessage = "";

            if (ShowMessage)
            {
                ViewBag.SuccessMessage = Message;
            }

            vmodel.IsErrorMessage = IsErrorMessage;
            listGame = game.Collection().ToList();

            if (Category != "")
            {
                gameId = listGame.Where(a => a.GameName == Category).Select(a => a.GameId);
            }
            seasons = season.Collection().ToList();
            //vmodel.ListofSeasons = seasons.Where(a => a.GameId == gameId);

            //if (Category == null)
            //{
            //    listGame = game.Collection().ToList();
            //}
            //else
            //{
            //    listGame = game.Collection().Where(p => p.GameName == Category).ToList();
            //}


            vmodel.ListOfGames = listGame;
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
