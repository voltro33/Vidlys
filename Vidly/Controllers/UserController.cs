using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Vidly.Interfaces;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserRepository _userRepository;
        private readonly UserManager<AppUser> _userManager;
        

        public UserController(IUserRepository userRepository, UserManager<AppUser> userManager)
        {
            _userRepository = userRepository;
            _userManager = userManager;
           
        }

        [HttpGet("users")]
        public async Task<IActionResult> Index()
        {
            var users = await _userRepository.GetAllUsers();
            List<UserViewModel> result = new List<UserViewModel>();
            foreach (var user in users)
            {
                var userViewModel = new UserViewModel()
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    GenreId = user.GenreId,
                    ProfileImageUrl = user.ProfileImageUrl,
                    Birthday = user.Birthdate,
                   
                };
                result.Add(userViewModel);
            }
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(string id)
        {
            var user = await _userRepository.GetUserById(id);
            if (user == null)
            {
                return RedirectToAction("Index", "Users");
            }

            var userDetailViewModel = new UserDetailViewModel()
            {
                Id = user.Id,
                UserName = user.UserName,
                GenreId = user.GenreId,
                ProfileImageUrl = user.ProfileImageUrl,
                Birthday = user.Birthdate,
            };
            return View(userDetailViewModel);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userRepository.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            var userViewModel = new UserDetailViewModel()
            {
                Id = user.Id,
                UserName = user.UserName,
                GenreId = user.GenreId,
                ProfileImageUrl = user.ProfileImageUrl,
                Birthday = user.Birthdate,
            };

            return View(userViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserDetailViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model); // If validation fails, return to the edit view with errors
            }

            var user = await _userRepository.GetUserById(model.Id);
            if (user == null)
            {
                return NotFound(); // Return 404 if the user is not found
            }

            // Update user properties
            user.UserName = model.UserName;
            user.GenreId = model.GenreId;
            user.ProfileImageUrl = model.ProfileImageUrl;
            user.Birthdate = model.Birthday;

            // Update user in database
            _userRepository.Update(user);

            return RedirectToAction("Index"); // Redirect to the index page after successful edit
        }



    }
}
