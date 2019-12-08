using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameRecordApplication.Models
{
    public class Module : BaseEntity
    {
        [Required]
        [DisplayName("Module")]
        public string ModuleName { get; set; }
    }
}