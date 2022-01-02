using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIO.Series.Web.Controllers
{
    public class SerieControllerAutomatico : Controller
    {
        // GET: SerieControllerAutomatico
        public ActionResult Index()
        {
            return View();
        }

        // GET: SerieControllerAutomatico/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SerieControllerAutomatico/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SerieControllerAutomatico/Create
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

        // GET: SerieControllerAutomatico/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SerieControllerAutomatico/Edit/5
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

        // GET: SerieControllerAutomatico/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SerieControllerAutomatico/Delete/5
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
