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
    public class WeddingController : Controller
    {
        private MyContext dbContext;
        public WeddingController(MyContext context)
        {
            dbContext = context;
        }

        [Route("dashboard")]
        [HttpGet]
        public IActionResult Dashboard()
        {
            Dashboard myDashboard = new Dashboard();
            List<Wedding> AllWeddings = dbContext.Weddings
                .Include(wedding => wedding.Users)
                .ToList();
            myDashboard.Weddings = AllWeddings;

            User userLoggedIn = dbContext.Users
                .FirstOrDefault(user => user.UserId == (int)(HttpContext.Session.GetInt32("UserLoggedIn")));
            myDashboard.UserLoggedIn = userLoggedIn;
            return View(myDashboard);
        }

        [Route("dashboard/new")]
        [HttpGet]
        public IActionResult NewWedding()
        {
            return View();
        }

        [Route("dashboard/new")]
        [HttpPost]
        public IActionResult NewWedding(Wedding newWedding)
        {
            // System.Console.WriteLine("incoming new wedding");
            // System.Console.WriteLine(newWedding.WedderOne);
            // System.Console.WriteLine(newWedding.WedderTwo);
            // System.Console.WriteLine(newWedding.Date);
            // System.Console.WriteLine(newWedding.WeddingAddress);
            newWedding.Creator = (int)(HttpContext.Session.GetInt32("UserLoggedIn"));
            dbContext.Add(newWedding);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [Route("dashboard/{weddingid}")]
        [HttpGet]
        public IActionResult ViewWedding(int weddingid)
        {
            Wedding weddingToView = dbContext.Weddings
                .Include(wedding => wedding.Users)
                .ThenInclude(guest => guest.User)
                .FirstOrDefault(wedding => wedding.WeddingId == weddingid);
            return View(weddingToView);
        }

        [Route("deletewedding/{weddingid}")]
        [HttpGet]
        public IActionResult DeleteWedding(int weddingid)
        {
            Wedding GotWedding = dbContext.Weddings.SingleOrDefault(wedding => wedding.WeddingId == weddingid);
            dbContext.Weddings.Remove(GotWedding);
            dbContext.SaveChanges();

            Dashboard myDashboard = new Dashboard();
            List<Wedding> AllWeddings = dbContext.Weddings
                .Include(wedding => wedding.Users)
                .ToList();
            myDashboard.Weddings = AllWeddings;

            User userLoggedIn = dbContext.Users
                .FirstOrDefault(user => user.UserId == (int)(HttpContext.Session.GetInt32("UserLoggedIn")));
            myDashboard.UserLoggedIn = userLoggedIn;
            return RedirectToAction("Dashboard", myDashboard);
        }

        [Route("rsvp/{weddingid}")]
        [HttpGet]
        public IActionResult RSVPWedding(int weddingid)
        {
            Guest newGuest = new Guest();
            newGuest.UserId = (int)(HttpContext.Session.GetInt32("UserLoggedIn"));
            newGuest.WeddingId = weddingid;
            dbContext.Add(newGuest);
            dbContext.SaveChanges();

            Dashboard myDashboard = new Dashboard();
            List<Wedding> AllWeddings = dbContext.Weddings
                .Include(wedding => wedding.Users)
                .ToList();
            myDashboard.Weddings = AllWeddings;

            User userLoggedIn = dbContext.Users
                .FirstOrDefault(user => user.UserId == (int)(HttpContext.Session.GetInt32("UserLoggedIn")));
            myDashboard.UserLoggedIn = userLoggedIn;
            return RedirectToAction("Dashboard", myDashboard);
        }

        [Route("unrsvp/{weddingid}")]
        [HttpGet]
        public IActionResult UNRSVPWedding(int weddingid)
        {
            // Wedding GotWedding = dbContext.Weddings.SingleOrDefault(wedding => wedding.WeddingId == weddingid);
            // dbContext.Weddings.Remove(GotWedding);
            // dbContext.SaveChanges();
            Guest GotGuest = dbContext.Guests.SingleOrDefault(
                guest => guest.WeddingId == weddingid && guest.UserId == (int)(HttpContext.Session.GetInt32("UserLoggedIn"))
            );
            dbContext.Remove(GotGuest);
            dbContext.SaveChanges();

            Dashboard myDashboard = new Dashboard();
            List<Wedding> AllWeddings = dbContext.Weddings
                .Include(wedding => wedding.Users)
                .ToList();
            myDashboard.Weddings = AllWeddings;

            User userLoggedIn = dbContext.Users
                .FirstOrDefault(user => user.UserId == (int)(HttpContext.Session.GetInt32("UserLoggedIn")));
            myDashboard.UserLoggedIn = userLoggedIn;
            return RedirectToAction("Dashboard", myDashboard);
        }

    }
}
