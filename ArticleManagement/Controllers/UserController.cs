using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AM.DM.User;
using ArticleManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArticleManagement.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public IActionResult Register(UserModel pUserModel)
        {
            return View("Register");
        }
    }
}