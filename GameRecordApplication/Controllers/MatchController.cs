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
        IRepository<Game> game;
        IRepository<Season> Iseason;
        IRepository<User> Iuser;
        IRepository<Match> Imatch;
        IRepository<Fields> Ifield;

        public MatchController(IRepository<Game> game, IRepository<Season> season, IRepository<User> user, IRepository<Match> Imatch, IRepository<Fields> Ifield)
        {
            this.game = game;
            this.Iseason = season;
            this.Iuser = user;
            this.Imatch = Imatch;
            this.Ifield = Ifield;
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
        public ActionResult Create(string Category = null, bool weaponReq = false, string message = "")
        {
            List<Game> games = game.Collection().ToList();
            List<Season> seasons = Iseason.Collection().ToList();
            List<User> users = Iuser.Collection().ToList();
            ViewBag.Message = message;

            // add N/A 
            users.Add(new User { FirstName = "N/A", UserId = "0" });

            MatchViewModel viewModel = new MatchViewModel
            {
                ListOfGames = games,
                ListOfUsers = users.OrderBy(a => a.UserId),
                Game = games.First(a => a.GameName == Category)
            };

            viewModel.ListOfSeasons = seasons.Where(a => a.GameId == viewModel.Game.GameId).OrderBy(a => a.SeasonNumber);
            viewModel.ListOfFields = Ifield.Collection().Where(a => a.Module == "Match").ToList();

            return View(viewModel);
        }

        // POST: Match/Create
        [HttpPost]
        public ActionResult Create(MatchViewModel viewModel, Match match,string category = "")
        {
            IEnumerable<Game> gameTemp;
            ViewBag.Message = "";

            gameTemp = game.Collection();

            viewModel.Match.PlayerWin = Request.Form["WinPlayer"];
            viewModel.Match.SeasonId = Convert.ToInt64(Request.Form["Season"]);
            
            viewModel.Match.PlayerIdLose = Request.Form["LossPlayer"];
            viewModel.Game = gameTemp.First(a => a.GameName == category);

            // insert to match
            viewModel.Match.GameId = viewModel.Game.GameId;

            viewModel.IsErrorMessage = false;
            if (category == "Billiards")
            {
                if (viewModel.Match.PlayerIdLose == "0" || viewModel.Match.PlayerWin == "0")
                {
                    viewModel.IsErrorMessage = true;
                    ViewBag.Message = "Winning and Losing player is required.";

                    return RedirectToAction("Create", "Match", new { Category = category, message = ViewBag.Message });
                }
            }

            Imatch.Insert(viewModel.Match);
            Imatch.Commit();

            return RedirectToAction("Index", "GameStats", new { Category = category });
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
