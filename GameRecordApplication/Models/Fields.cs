using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameRecordApplication.Models
{
    public class Fields : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long FieldId { get; set; }

        public string Module { get; set; }
        
        [DisplayName("Field Name")]
        public string FieldName { get;set; }
        [DisplayName("Active")]
        public bool AciveField { get; set; }
        [DisplayName("Required")]
        public bool IsRequired { get; set; }
    }
}