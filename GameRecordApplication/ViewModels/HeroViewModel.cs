﻿using GameRecordApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;
using PagedList;

namespace GameRecordApplication.ViewModels
{
    public class HeroViewModel
    {
        public DotaHero DotaHero { get; set; }
        public DotaHeroAttribute DotaHeroAttribute { get; set; }
        public IPagedList<DotaHero> DotaHeroes { get; set; }
        public IEnumerable<DotaHeroAttribute> DotaHeroAttributes { get; set; }
    }
}