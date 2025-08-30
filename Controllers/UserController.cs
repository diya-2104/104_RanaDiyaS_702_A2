using Assignment02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment02.Controllers
{

    public class UserController : Controller
    {
        private static List<User> users = new List<User>();

        public IActionResult Index()
        {
            return View(users);
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            user.Id = users.Count + 1;
            users.Add(user);
            return PartialView("_UserList", users);
        }
    }
}
