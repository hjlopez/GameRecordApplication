using System;
using System.Collections.Generic;
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
        public string GameName { get; set; }
        public string GameType { get; set; }
        public int MaxPlayers { get; set; }
        public bool HasSeason { get; set; }
    }
}