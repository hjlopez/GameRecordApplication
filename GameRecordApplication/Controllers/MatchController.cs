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
    public class MatchController : Controller
    {
        IRepository<Game> context;
        IRepository<Season> Iseason;
        IRepository<User> Iuser;

        public MatchController(IRepository<Game> game, IRepository<Season> season, IRepository<User> user)
        {
            this.context = game;
            this.Iseason = season;
            this.Iuser = user;
        }

        // GET: Match
        public ActionResult Index()
        {
            return View();
        }

        // GET: Match/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

       
        // GET: Match/Create
        public ActionResult Create(string Category = null, bool weaponReq = false)
        {
            List<Game> games = context.Collection().ToList();
            List<Season> seasons = Iseason.Collection().ToList();
            List<User> users = Iuser.Collection().ToList();

            // add N/A 
            users.Add(new User { FirstName = "N/A", UserId = "0" });

            MatchViewModel viewModel = new MatchViewModel
            {
                ListOfGames = games,
                ListOfUsers = users.OrderBy(a => a.UserId),
                Game = games.First(a => a.GameName == Category)
            };

            viewModel.ListOfSeasons = seasons.Where(a => a.GameId == viewModel.Game.GameId).OrderBy(a => a.SeasonNumber);
            

            return View(viewModel);
        }

        // POST: Match/Create
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

        // GET: Match/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Match/Edit/5
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

        // GET: Match/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Match/Delete/5
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
