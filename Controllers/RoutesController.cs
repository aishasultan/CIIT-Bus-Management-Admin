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
    //[Authorize]
    [Route("[controller]/[action]")]
    public class RoutesController : Controller
    {
        // GET: Routes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult test()
        {
            return View();
        }

        // GET: Routes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Routes/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Routes/Routes
        public ActionResult Routes()
        {
            return View();
        }

        // POST: Routes/Routes/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Routes(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: Routes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: Routes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Routes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Routes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Routes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}