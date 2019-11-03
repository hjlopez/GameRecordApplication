using GameRecordApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameRecordApplication.ViewModels
{
    public class MatchViewModel
    {
        public Game Game { get; set; }
        public User User { get; set; }
        public Match Match { get; set; }
        public Season Season { get; set; }
        public IEnumerable<Game> ListOfGames { get; set; }
        public IEnumerable<Match> ListOfMatches { get; set; }
        public IEnumerable<Season> ListOfSeasons { get; set; }

        public bool IsErrorMessage { get; set; }
    }
}