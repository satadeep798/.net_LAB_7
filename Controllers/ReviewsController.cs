using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lab_7.Models;

namespace Lab_7.Controllers
{
    public class ReviewsController : Controller
    {
        static List<BookReview> reviewList = new List<BookReview>();

        private void LoadDropdowns()
        {
            ViewBag.Genres = new SelectList(new[] { "Fiction", "Science", "History", "Technology", "Biography" });
            ViewBag.Ratings = new SelectList(new[] { 1, 2, 3, 4, 5 });
        }

        // /Reviews
        public IActionResult Index()
        {
            return View();
        }

        // /Reviews/Create
        [HttpGet]
        public IActionResult Create()
        {
            LoadDropdowns();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookReview review)
        {
            if (ModelState.IsValid)
            {
                reviewList.Add(review);
                TempData["Message"] = "Thanks! Your review was saved.";
                return RedirectToAction("List");
            }

            LoadDropdowns();
            return View(review);
        }

        // /Reviews/List
        public IActionResult List()
        {
            return View(reviewList);
        }
    }
}
