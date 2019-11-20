using GameRecordApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace GameRecordApplication.Controllers
{
    public class DotaHeroController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<DotaHero> dotaHero = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.opendota.com/api/heroes");
                //HTTP GET
                var responseTask = client.GetAsync("heroes");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<DotaHero>>();
                    readTask.Wait();

                    dotaHero = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    dotaHero = Enumerable.Empty<DotaHero>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            
            return View(dotaHero.ToList());
        }
    }
}