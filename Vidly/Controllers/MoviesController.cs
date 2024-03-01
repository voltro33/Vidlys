using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Vidly.Interfaces;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserRepository _userRepository;

        public MoviesController(ApplicationDbContext context, IUserRepository userRepository)
        {
            _context = context;
            _userRepository = userRepository;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public async Task<IActionResult> Index()
        {
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userRepository.GetUserById(currentUserId);

            if (user == null)
            {
                return View("~/Views/Shared/_SignInRequired.cshtml");
            }

            if (user.GenreId == 0)
            {
                // Redirect to an error page indicating that the user has no genre ID assigned
                return RedirectToAction("GenreIdNotAssignedError");
            }

            var employeeMovies = _context.Movies
                .Where(m => m.GenreId == user.GenreId)
                .Include(m => m.Genre)
                .ToList();

            return View(employeeMovies);
        }

        public ViewResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return NotFound();

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }


        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return NotFound();

            return View(movie);

        }


        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                movie.DateRemoved = movie.DateAdded.AddMinutes(movie.MinuteLeft * movie.NumberInStock);
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.MinuteLeft = movie.MinuteLeft;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }


        //Error Page for no Genre Id
        public IActionResult GenreIdNotAssignedError()
        {
            // You can pass additional data to the view if needed
            return View();
        }

    }
}