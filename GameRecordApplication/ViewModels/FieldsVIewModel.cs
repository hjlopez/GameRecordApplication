using GameRecordApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;
using PagedList;

namespace GameRecordApplication.ViewModels
{
    public class FieldsVIewModel
    {
        public Fields Field { get; set; }
        public Module Module { get; set; }
        public IPagedList<Fields> Fields { get; set; }
        public IEnumerable<Module> Modules { get; set; }
    }
}