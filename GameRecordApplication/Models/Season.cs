using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameRecordApplication.Models
{
    public class Season : BaseEntity
    {
        public long SeasonNumber { get; set; }
        public long GameId { get; set; }
        public bool Active { get; set; }
    }
}