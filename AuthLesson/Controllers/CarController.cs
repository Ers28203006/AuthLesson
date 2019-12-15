using AuthLesson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthLesson.Controllers
{
    public class CarController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: Car
        public ActionResult Index()
        {
            var users = db.Users.ToList();
            ViewBag.Users = users;
            return View(db.Cars);
        }

        // GET: Car/Create
        public ActionResult Create()
        {
            SelectList users = new SelectList(db.Users, "Email");
            ViewBag.Users = users;
            return View();
        }

        // POST: Car/Create
        [HttpPost]
        public ActionResult Create(Car car, string email)
        {
            ApplicationUser user = new ApplicationUser();
            user = db.Users.Where(u => u.Email == email).FirstOrDefault();
            car.ApplicationUser = user;
            db.Cars.Add(car);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
