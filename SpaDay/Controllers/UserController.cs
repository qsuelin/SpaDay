using System;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController: Controller
    {
        public UserController()
        {
        }

        [HttpGet]
        [Route("/user/add")]
        public IActionResult Add()
        {
            ViewBag.error = false;
            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                ViewBag.error = false;
                ViewBag.userName = newUser.Username;
                ViewBag.email = newUser.Email;
                ViewBag.createdTime = newUser.CreatedTime;
                //Console.WriteLine(newUser.CreatedTime);
                return View("Index");
            }
            ViewBag.error = true;
            ViewBag.userName = newUser.Username;
            ViewBag.email = newUser.Email;
            return View("Add");
        }


    }
}
