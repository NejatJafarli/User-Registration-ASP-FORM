using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Reflection;
using User_Registration.Entities;
using User_Registration.Models;
using User_Registration.Services;

namespace User_Registration.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View(UserService.Users);
        }

        [HttpGet]
        public IActionResult Add()
        {

            return View(new UserAddViewModel());
        }
        [HttpPost]
        public IActionResult Add(UserAddViewModel userAdd)
        {
            
        }
    }
}
