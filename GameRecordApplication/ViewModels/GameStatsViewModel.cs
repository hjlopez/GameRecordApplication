using GameRecordApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameRecordApplication.ViewModels
{
    public class GameStatsViewModel
    {
        public Game Game { get; set; }
        public IEnumerable<Game> ListOfGames { get; set; }
    }
}