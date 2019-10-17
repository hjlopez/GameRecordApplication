using GameRecordApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameRecordApplication.ViewModels
{
    public class GameTypeViewModel
    {
        public IEnumerable<GameTypes> GameTypes { get; set; }
    }
}