using GameRecordApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static GameRecordApplication.ViewModels.MonsterHunterWeaponViewModel;
using PagedList.Mvc;
using PagedList;

namespace GameRecordApplication.ViewModels
{
    public class MatchViewModel
    {
        public Game Game { get; set; }
        public User User { get; set; }
        public Match Match { get; set; }
        public Season Season { get; set; }
        public DotaHero DotaHero { get; set; }
        public Weapon Weapon   { get; set; }
        public Fields Field { get; set; }
        public IEnumerable<Game> ListOfGames { get; set; }
        public IPagedList<Match> ListOfMatches { get; set; }
        public IEnumerable<Season> ListOfSeasons { get; set; }
        public IEnumerable<User> ListOfUsers { get; set; }
        public IEnumerable<Weapon> ListOfWeapons { get; set; }
        public IEnumerable<Fields> ListOfFields { get; set; }

        public bool IsErrorMessage { get; set; }
    }
}