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
    public class ThingController : Controller
    {
        private MyContext dbContext;
        public ThingController(MyContext context)
        {
            dbContext = context;
        }

        [Route("dashboard")]
        [HttpGet]
        public IActionResult Dashboard()
        {
            if(HttpContext.Session.GetInt32("UserLoggedIn") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Dashboard myDashboard = new Dashboard();
            List<Thing> AllThings = dbContext.Things
                .Include(thing => thing.Users)
                .ToList();
            myDashboard.Things = AllThings;

            User userLoggedIn = dbContext.Users
                .FirstOrDefault(user => user.UserId == (int)(HttpContext.Session.GetInt32("UserLoggedIn")));
            myDashboard.UserLoggedIn = userLoggedIn;

            List<User> allUsers = dbContext.Users.ToList();
            myDashboard.AllUsers = allUsers;

            // if (userLoggedIn.Things == null) {
            //     System.Console.WriteLine("YES");
            // } else {
            //     System.Console.WriteLine("not null");
            // }
            
            return View(myDashboard);
        }

        [Route("thingsandadd")]
        [HttpGet]
        public IActionResult ThingsAndAdd()
        {
            if(HttpContext.Session.GetInt32("UserLoggedIn") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            DashboardThingsAndAdd myDashboard = new DashboardThingsAndAdd();
            List<Thing> AllThings = dbContext.Things
                .Include(thing => thing.Users)
                .ToList();
            myDashboard.Things = AllThings;

            User userLoggedIn = dbContext.Users
                .FirstOrDefault(user => user.UserId == (int)(HttpContext.Session.GetInt32("UserLoggedIn")));
            myDashboard.UserLoggedIn = userLoggedIn;
            return View(myDashboard);
        }

        [Route("dashboard/new")]
        [HttpGet]
        public IActionResult NewThing()
        {
            if(HttpContext.Session.GetInt32("UserLoggedIn") == null)
            {
                return RedirectToAction("Index", "Home");
            } 
            return View();
            
        }

        [Route("dashboard/new")]
        [HttpPost]
        public IActionResult NewThing(Thing newThing)
        {
            // System.Console.WriteLine("newThing");
            // System.Console.WriteLine(newThing.Name);
            // System.Console.WriteLine(newThing.Date);
            // System.Console.WriteLine(newThing.Time);
            // System.Console.WriteLine(newThing.Duration);
            // System.Console.WriteLine(newThing.DurationType);
            // System.Console.WriteLine(newThing.Description);
            // return View("NewThing");
            if(ModelState.IsValid) 
            {
                newThing.Creator = (int)(HttpContext.Session.GetInt32("UserLoggedIn"));
                dbContext.Add(newThing);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("NewThing");
            }
        }

        [Route("dashboard/{thingid}")]
        [HttpGet]
        public IActionResult ViewThing(int thingid)
        {
            if(HttpContext.Session.GetInt32("UserLoggedIn") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.LoggedInUser = (int)(HttpContext.Session.GetInt32("UserLoggedIn"));
            Thing thingToView = dbContext.Things
                .Include(thing => thing.Users)
                .ThenInclude(association => association.User)
                .FirstOrDefault(thing => thing.ThingId == thingid);
            User userWhoCreatedFname = dbContext.Users
                .FirstOrDefault(user => user.UserId == thingToView.Creator);
            ViewBag.CreatorsName = userWhoCreatedFname.Fname;
            return View(thingToView);
        }

        [Route("dashboard/{thingid}/edit")]
        [HttpGet]
        public IActionResult EditThing(int thingid)
        {
            if(HttpContext.Session.GetInt32("UserLoggedIn") == null)
            {
                return RedirectToAction("Index", "Home");
            } 
            Thing thingToEdit = dbContext.Things
                .Include(thing => thing.Users)
                .ThenInclude(association => association.User)
                .FirstOrDefault(thing => thing.ThingId == thingid);
            return View(thingToEdit);
        }

        [Route("dashboard/{thingid}/edit")]
        [HttpPost]
        public IActionResult EditThing(Thing editedThing)
        {
            if(ModelState.IsValid) 
            {
                Thing thingToEdit = dbContext.Things
                    .FirstOrDefault(thing => thing.ThingId == editedThing.ThingId);
                thingToEdit.Name = editedThing.Name;
                thingToEdit.Date = editedThing.Date;
                dbContext.SaveChanges();
                return RedirectToAction("ViewThing", new { thingid = editedThing.ThingId });
            }
            else
            {
                return View("EditThing");
            }
        }

        [Route("deletething/{thingid}")]
        [HttpGet]
        public IActionResult DeleteWedding(int thingid)
        {
            if(HttpContext.Session.GetInt32("UserLoggedIn") == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Thing GotThing = dbContext.Things.SingleOrDefault(thing => thing.ThingId == thingid);
            dbContext.Things.Remove(GotThing);
            dbContext.SaveChanges();

            Dashboard myDashboard = new Dashboard();
            List<Thing> AllThings = dbContext.Things
                .Include(wedding => wedding.Users)
                .ToList();
            myDashboard.Things = AllThings;

            User userLoggedIn = dbContext.Users
                .FirstOrDefault(user => user.UserId == (int)(HttpContext.Session.GetInt32("UserLoggedIn")));
            myDashboard.UserLoggedIn = userLoggedIn;
            return RedirectToAction("Dashboard", myDashboard);
        }

        [Route("combineuserthing/{thingid}")]
        [HttpGet]
        public IActionResult CombineUserThing(int thingid)
        {
            
            if(HttpContext.Session.GetInt32("UserLoggedIn") == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Association newAssociation = new Association();
            newAssociation.UserId = (int)(HttpContext.Session.GetInt32("UserLoggedIn"));
            newAssociation.ThingId = thingid;
            dbContext.Add(newAssociation);
            dbContext.SaveChanges();

            Dashboard myDashboard = new Dashboard();
            List<Thing> AllThings = dbContext.Things
                .Include(wedding => wedding.Users)
                .ToList();
            myDashboard.Things = AllThings;

            User userLoggedIn = dbContext.Users
                .FirstOrDefault(user => user.UserId == (int)(HttpContext.Session.GetInt32("UserLoggedIn")));
            myDashboard.UserLoggedIn = userLoggedIn;
            return RedirectToAction("Dashboard", myDashboard);
        }

        [Route("uncombineuserthing/{thingid}")]
        [HttpGet]
        public IActionResult UncombineUserThing(int thingid)
        {
            if(HttpContext.Session.GetInt32("UserLoggedIn") == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Association GotAssociation = dbContext.Associations.SingleOrDefault(
                association => association.ThingId == thingid && association.UserId == (int)(HttpContext.Session.GetInt32("UserLoggedIn"))
            );
            dbContext.Remove(GotAssociation);
            dbContext.SaveChanges();

            Dashboard myDashboard = new Dashboard();
            List<Thing> AllThings = dbContext.Things
                .Include(wedding => wedding.Users)
                .ToList();
            myDashboard.Things = AllThings;

            User userLoggedIn = dbContext.Users
                .FirstOrDefault(user => user.UserId == (int)(HttpContext.Session.GetInt32("UserLoggedIn")));
            myDashboard.UserLoggedIn = userLoggedIn;
            return RedirectToAction("Dashboard", myDashboard);
        }

    }
}
