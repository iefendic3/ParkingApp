using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Projekat___Parking.Controllers
{
    public class VlasnikController : Controller
    {
        // GET: VlasnikController

        [Authorize(Roles = "Vlasnik")]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Vlasnik")]
        public IActionResult OtvoriParking()
        {
            return View();
        }

        // GET: VlasnikController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VlasnikController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VlasnikController/Create
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

        // GET: VlasnikController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VlasnikController/Edit/5
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

        // GET: VlasnikController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VlasnikController/Delete/5
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
