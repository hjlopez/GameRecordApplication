using GameRecordApplication.Contracts;
using GameRecordApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace GameRecordApplication.Controllers
{
    public class UserController : Controller
    {
        IRepository<User> users;

        public UserController(IRepository<User> users)
        {
            this.users = users;
        }

        // GET: User
        public ActionResult Index()
        {
            List<User> userList = users.Collection().ToList();
            return View(userList);
            //List<User> userList = (from user in Context.
            //                      select new
            //                      {
            //                          UserId = user.Id,
            //                          Username = user.UserName,
            //                          Email = user.Email,
            //                          RoleNames = (from userRole in user.Roles
            //                                       join role in context.Roles on userRole.RoleId
            //                                       equals role.Id
            //                                       select role.Name).ToList()
            //                      }).ToList().Select(p => new User()

            //                      {
            //                          UserId = p.UserId,
            //                          Username = p.Username,
            //                          Email = p.Email,
            //                          UserRole = string.Join(",", p.RoleNames)
            //                      });

        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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
