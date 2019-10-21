using GameRecordApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameRecordApplication.ViewModels
{
    public class GameViewModel
    {
        public Game Game { get; set; }
        public IEnumerable<GameTypes> Types { get; set; }
    }
}