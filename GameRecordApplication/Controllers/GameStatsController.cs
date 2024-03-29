﻿using GameRecordApplication.Contracts;
using GameRecordApplication.Models;
using GameRecordApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace GameRecordApplication.Controllers
{
    public class GameStatsController : Controller
    {
        IRepository<Game> game;
        IRepository<Season> season;
        IRepository<Match> match;
        IRepository<User> user;
        IRepository<Fields> Ifield;

        public GameStatsController(IRepository<Game> game, IRepository<Season> season, IRepository<Match> match, IRepository<User> user, IRepository<Fields> field)
        {
            this.game = game;
            this.season = season;
            this.match = match;
            this.user = user;
            this.Ifield = field;
        }

        // GET: GameStats
        public ActionResult Index(int? i, string Category = "", bool ShowMessage = false, string Message = "", bool IsErrorMessage = false)
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
            vmodel.ListOfUsers = user.Collection().ToList();

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
            vmodel.ListOfMatches = matches.ToList().ToPagedList(i ?? 1, 6);


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
