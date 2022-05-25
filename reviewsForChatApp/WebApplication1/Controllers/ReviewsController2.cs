using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ReviewsController2 : Controller
    {
        // GET: ReviewsController2
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReviewsController2/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReviewsController2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReviewsController2/Create
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

        // GET: ReviewsController2/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReviewsController2/Edit/5
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

        // GET: ReviewsController2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReviewsController2/Delete/5
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
