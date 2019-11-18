using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace GameRecordApplication.Models
{
    public class DotaHero
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DisplayName("Hero Name")]
        public string Localized_name { get; set; }
        [DisplayName("Primary Attribute")]
        public string Primary_attr { get; set; }
        [DisplayName("Attack Type")]
        public string Attack_type { get; set; }

        public List<string> Roles { get; set; }
        public int Legs { get; set; }
    }
}