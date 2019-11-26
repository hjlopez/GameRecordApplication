using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameRecordApplication.Models
{
    public class Match : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long MatchId { get; set; }

        [DisplayName("Game")]
        public long GameId { get; set; }

        [DisplayName("Season")]
        public long SeasonId { get; set; }

        [DisplayName("Winning Player")]
        public string PlayerWin { get; set; }

        [DisplayName("Losing Player")]
        public string PlayerIdLose { get; set; }
        public string Hero { get; set; }
        public string Weapon { get; set; }

        [DisplayName("Team Win?")]
        public bool? TeamWin { get; set; }
        public int? Hours { get; set; }
        public int? Minutes { get; set; }
        public int? Seconds { get; set; }
    }
}