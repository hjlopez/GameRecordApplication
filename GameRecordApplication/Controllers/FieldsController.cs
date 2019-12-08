using GameRecordApplication.Contracts;
using GameRecordApplication.Models;
using GameRecordApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace GameRecordApplication.Controllers
{
    public class FieldsController : Controller
    {
        IRepository<Fields> repository;
        IRepository<Module> Imodule;

        public FieldsController(IRepository<Fields> repository, IRepository<Module> module)
        {
            this.repository = repository;
            this.Imodule = module;
        }
        // GET: Fields
        public ActionResult Index(int? i, string ModuleVal = "")
        {
            FieldsVIewModel vm = new FieldsVIewModel();

            vm.Fields = repository.Collection().Where(a => a.Module == ModuleVal).OrderBy(a => a.CreatedAt).ToList().ToPagedList(i ?? 1, 5);
            vm.Modules = Imodule.Collection().ToList();
            
           
            return View(vm);
        }

        // GET: Fields/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Fields/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fields/Create
        [HttpPost]
        public ActionResult CreateModule(Module module)
        {
            if (!ModelState.IsValid)
            {
                return View(module);
            }
            else
            {
                Imodule.Insert(module);
                Imodule.Commit();
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult CreateField(FieldsVIewModel fields, string ModuleVal = "")
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                return View(fields);
            }
            else
            {
                fields.Field.Module = ModuleVal;
                repository.Insert(fields.Field);
                repository.Commit();
                //if(Module != "")
                //{
                //    repository.Insert(fields);
                //    repository.Commit();
                //}

                return RedirectToAction("Index", "Fields", new { ModuleVal = fields.Field.Module });
            }
        }
        // GET: Fields/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Fields/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Fields/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Fields/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
