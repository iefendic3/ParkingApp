using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Projekat___Parking.Controllers
{
    public class RadnikController : Controller
    {
        // GET: RadnikController
        [Authorize(Roles = "Radnik")]
        public IActionResult Index()
        {
            return View();
        }

        // GET: RadnikController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RadnikController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RadnikController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RadnikController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RadnikController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RadnikController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RadnikController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
