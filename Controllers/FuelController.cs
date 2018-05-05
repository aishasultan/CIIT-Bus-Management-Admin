using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace testing.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class FuelController : Controller
    {
        // GET: Fuel
        public ActionResult Index()
        {
            return View();
        }

        // GET: Fuel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Fuel/Fuel
        public ActionResult Fuel()
        {
            return View();
        }

        // POST: Fuel/Fuel
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Fuel(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
    }
}