using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace testing.Controllers
{
    public class MapsController : Controller
    {
        // GET: Maps
        public ActionResult Index()
        {
            return View();
        }

        // GET: Maps/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Maps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Maps/Create
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

        // GET: Maps/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Maps/Edit/5
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

        // GET: Maps/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Maps/Delete/5
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