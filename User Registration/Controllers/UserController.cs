using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Reflection;
using User_Registration.Entities;
using User_Registration.Models;
using User_Registration.Services;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace User_Registration.Controllers
{
    public class UserController : Controller
    {

        private readonly IHostingEnvironment Environment;
        public UserController(IHostingEnvironment _environment)
        {
            Environment = _environment;
        }
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
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            string path = Path.Combine(this.Environment.WebRootPath, "Uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }


            string fileName = Path.GetFileName(userAdd.File.FileName);
            using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
            {
                userAdd.File.CopyTo(stream);
            }

            userAdd.User.ImagePath = fileName;

            UserService.Users.Add(userAdd.User);

            return RedirectToAction("Index");

        }
    }
}
