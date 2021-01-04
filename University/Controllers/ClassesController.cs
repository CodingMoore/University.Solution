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


  }
}