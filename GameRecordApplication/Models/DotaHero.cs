using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameRecordApplication.Models
{
    public class DotaHero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Localized_name { get; set; }
        public string Primary_attr { get; set; }
        public string Attack_type { get; set; }
        public List<string> Roles { get; set; }
        public int Legs { get; set; }
    }
}