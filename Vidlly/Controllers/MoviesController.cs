using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidlly.Models;
using Vidlly.ViewModels;

namespace Vidlly.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek"
            };

            var customers = new List<Customer>()
            {
                new Customer {Name = "Customer 1" },
                new Customer {Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult NewMovies()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new NewMovieViewModel
            {
                Genres = genres
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id" + id);
        }

        public ActionResult Index()
        {
            //int? pageIndex, string sortBy  -- were parameters for Index Action
            //if (!pageIndex.HasValue)
            //    pageIndex = 1;
            //if (string.IsNullOrWhiteSpace(sortBy))
            //    sortBy = "Name";

            //return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

            var movies = _context.Movies.Include(a => a.Genre).ToList();
            return View(movies);

        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult MovieNames()
        {
            var movies = new List<Movie>()
            {
                new Movie {Name = "300" },
                new Movie {Name = "3 Idiots" }
            };

            return View(movies);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

    }
}