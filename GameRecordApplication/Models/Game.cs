using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameRecordApplication.Models
{
    public class Game : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long GameId { get; set; }

        [DisplayName("Game")]
        public string GameName { get; set; }

        [DisplayName("Type")]
        public string GameType { get; set; }

        [DisplayName("Maximum Players")]
        public int MaxPlayers { get; set; }

        [DisplayName("Has Season?")]
        public bool HasSeason { get; set; }

        [DisplayName("Team Game?")]
        public bool IsTeamGame { get; set; }
    }
}