using Microsoft.AspNetCore.Mvc;
using University.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace University.Controllers
{
  public class ClassesController : Controller
  {
    private readonly UniversityContext _db;
    public ClassesController(UniversityContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Class> model = _db.Categories.University();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Class class)
    {
      _db.Classes.Add(class);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisClass = _db.Classes
          .Include(class => class.Students)
          .ThenInclude(join => join.Student)
          .FirstOrDefault(class => class.ClassId == id);
      return View(thisClass);
    }

    public ActionResult Edit(int id)
    {
      var thisClass = _db.Classes.FirstOrDefault(class => class.ClassId == id);
      return  View(thisclass);
    }

    [HttpPost]
    public ActionResult Edit(Class class)
    {
      _db.Entry(class).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisClass = _db.Classes.FirstOrDefault(class => class.ClassId == id);
      return View(thisClass);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisClass = _db.Classes.FirstOrDefault(class => class.ClassId == id);
      _db.Classes.Remove(thisClass);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}