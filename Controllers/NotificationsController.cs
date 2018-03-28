using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace testing.Controllers
{
    public class NotificationsController : Controller
    {
        // GET: Notifications
        public ActionResult Index()
        {
            return View();
        }

        // GET: Notifications/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Notifications/Notification
        public ActionResult Notification()
        {
            return View();
        }

        // POST: Notifications/Notification
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Notification(IFormCollection collection)
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

        // GET: Notifications/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Notifications/Edit/5
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

        // GET: Notifications/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Notifications/Delete/5
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