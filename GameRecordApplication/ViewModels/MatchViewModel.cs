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
        public IEnumerable<Game> ListOfGames { get; set; }
        public IEnumerable<Match> ListOfMatches { get; set; }
    }
}