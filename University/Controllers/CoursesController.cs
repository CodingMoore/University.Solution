using Microsoft.AspNetCore.Mvc;
using University.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace University.Controllers
{
  public class CoursesController : Controller // allows CourseController to operate as a Controller
  {
    private readonly UniversityContext _db; // Defining the Database as University
    public CoursesController(UniversityContext db) //constructor for the controller 
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Course> model = _db.Courses.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Course course)
    {
      _db.Courses.Add(course);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisCourse = _db.Courses //return course name and id 
          .Include(course => course.JoinEntries) //find students(JoinEntries) related to the course
          .ThenInclude(join => join.Student) //With all join entries add the related student 
          .FirstOrDefault(course => course.CourseId == id); // find the course that matches the ID
      return View(thisCourse);
    }

    public ActionResult Edit(int id)
    {
      var thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id); // finds the first match and assigns it to "thisCourse".
      return  View(thisCourse);
    }

    [HttpPost]
    public ActionResult Edit(Course course) //course is an object that contains all properties, not just the ID
    {
      _db.Entry(course).State = EntityState.Modified; // holding the information in a bucket
      _db.SaveChanges();// pour the bucket into the database
      return RedirectToAction("Index"); //returning to index page in courses
    }

    public ActionResult Delete(int id)
    {
      var thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
      return View(thisCourse);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
      _db.Courses.Remove(thisCourse);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}