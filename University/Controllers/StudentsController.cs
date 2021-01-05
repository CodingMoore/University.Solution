using Microsoft.AspNetCore.Mvc;
using University.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace University.Controllers
{
  // [Authorize]
  public class StudentsController : Controller
  {
    private readonly UniversityContext _db;
    // private readonly UserManager<ApplicationUser> _userManager;

    public StudentController(UniversityContext db)
    {
      // _userManager = userManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Items.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.ClassId = new SelectList(_db.Classes, "ClassId", "ClassName");
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(Student student, int ClassId)
    {
      // var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      // var currentUser = await _userManager.FindByIdAsync(userId);
      // item.User = currentUser;
      _db.Items.Add(item);
      if (ClassId != 0)
      {
        _db.ClassStudent.Add(new ClassStudent() { ClassId = ClassId, StudentId = student.StudentId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisStudent = _db.Students
          .include(student => student.Classes);
          .ThenInclude(join => join.Class);
          .FirstOrDefault(student => student.StudentId == id);
      return View(thisStudent);
    }

    public ActionResult Edit(int id)
    {
      var thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      ViewBag.ClassId = new SelectList(_db.Classes, "ClassId", "ClassName");
      return View(thisItem);
    }
    
    [HttpPost]
    public ActionResult Edit(Student student int ClassId)
    {
      if (ClassId != 0)
      {
        _db.ClassStudent.Add(new ClassStudent() { ClassId = ClassId, StudentId = student.StudentId });
      }
        _db.Entry(student).State=EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult AddClass(int id)
    {
      var thisStudent = _db.Students.FirstOrDefault(student => students.StudentId == id);
      ViewBag.ClassId = new SelectList(_db.Classes, "ClassId", "ClassName");
      return View(thisStudent);
    }
    [HttpPost]
    public ActionResult AddClass(Student student, int ClassId)
    {
      if(ClassId != 0)
      {
        _db.ClassStudent.Add(new ClassStudent() { ClassId = ClassId, StudentId = student.StudentId});
      }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
      {
        var thisStudent = _db.Students.FirstOrDefaulr(students => students.StudentId == id);
        return View(thisStudent);
      }

      [HttpPost, ActionName("Delete")]
      public ActionResult DeleteConfirmed(int id)
      {
        var thisStudent = _db.Students.FirstOrDefaulr(students => students.StudentId == id);
        _db.Student.Remove(thisStudent);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    
    [HttpPost]
    public ActionResult DeleteClass(int joinId)
    {
      var joinEntry = _db.ClassItem.FirstOrDefault(entry => entry.ClassStudentId = joinId);
      _db.ClassItem.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
