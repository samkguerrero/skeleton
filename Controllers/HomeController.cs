using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginRegistration.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace LoginRegistration.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            LoginUserUser newLoginUserUser = new LoginUserUser();
            return View(newLoginUserUser);
        }

        [Route("signup")]
        [HttpPost]
        public IActionResult SignUp(User newUser)
        {
            if(ModelState.IsValid) 
            {
                if(dbContext.Users.Any(u => u.Email == newUser.Email)) 
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    LoginUserUser newLoginUserUser = new LoginUserUser();
                    return View("Index",newLoginUserUser);
                } 
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    dbContext.Add(newUser);
                    dbContext.SaveChanges();
                    var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == newUser.Email);
                    HttpContext.Session.SetInt32("UserLoggedIn",userInDb.UserId);
                    return RedirectToAction("Success");
                }
            }
            else 
            {
                LoginUserUser newLoginUserUser = new LoginUserUser();
                return View("Index",newLoginUserUser);
            }
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(LoginUser loginAttempt)
        {
            LoginUserUser newLoginUserUser = new LoginUserUser();
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == loginAttempt.Email);
                if (userInDb == null) 
                {
                    ModelState.AddModelError("Email", "Invalid Email");
                    return View("Index",newLoginUserUser);
                }

                var hasher = new PasswordHasher<LoginUser>();

                var result = hasher.VerifyHashedPassword(loginAttempt, userInDb.Password, loginAttempt.Password);

                if(result == 0) 
                {
                    ModelState.AddModelError("Password", "Invalid Password");
                    return View("Index",newLoginUserUser);
                }
                else 
                {
                    HttpContext.Session.SetInt32("UserLoggedIn",userInDb.UserId);
                    return RedirectToAction("Success");
                }
                
            }
            else 
            {
                return View("Index", newLoginUserUser);
            }
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [Route("success")]
        [HttpGet]
        public IActionResult Success()
        {
            if(HttpContext.Session.GetInt32("UserLoggedIn") == null)
            {
                return RedirectToAction("Index");
            } 
            return RedirectToAction("Dashboard", "Thing");
        }
    }
}
