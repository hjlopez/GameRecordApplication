using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameRecordApplication.Models
{
    public class DotaHeroAttribute : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AttributeId { get; set; }

        public string Attribute { get; set; }
        public string Description { get; set; }
    }
}