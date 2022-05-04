using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class CourseController : Controller
    {
        public efCore1Context db;
        public CourseController(efCore1Context _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var t = db.Course;
            return View(t);
        }

        public IActionResult Index2()
        {
            var t = db.Course;
            return View(t);
        }
        public IActionResult Addcourse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Addcourse(Course c)
        {
            db.Course.Add(c);
            db.SaveChanges();
            return View();
        }
        public IActionResult Delete(int id)
        {
            var Course = db.Course.Find(id);
            db.Course.Remove(Course);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
