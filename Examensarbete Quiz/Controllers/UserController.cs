using Examensarbete_Quiz.Data;
using Examensarbete_Quiz.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Examensarbete_Quiz.Controllers
{
    public class UserController : Controller
    {
        ApplicationDbContext _applicationDbContext;
        private IUserRepository _userRepository;

        public UserController(IUserRepository userRepository, ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<User> users;

            users = _userRepository.GetAllUser;

            return View(users);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Remove(int id)
        {
            User user = _userRepository.GetUserByID(id);
            _userRepository.RemoveUser(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult AddOrEditUser(int id)
        {
            if (id == 0)
            {
                return View(new User());
            }
            else
            {
                return View(_userRepository.GetUserByID(id));
            }
        }

        [HttpPost]
        public IActionResult AddOrEditUser([Bind("UserID, UserFirstName, UserLastName, UserAge, UserGender")] User user)
        {
            if (ModelState.IsValid)
            {
                if (user.UserID == 0)
                {
                    _userRepository.CreateNewUser(user);
                }
                else
                {
                    _userRepository.EditUser(user);
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(user);
        }
    }
}
