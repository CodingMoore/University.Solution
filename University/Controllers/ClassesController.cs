using Microsoft.AspNetCore.Mvc;
using Template.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Template.Controllers
{
  public class ParentsController : Controller
  {
    private readonly TemplateContext _db;
    public ParentsController(TemplateContext db)
    {
      _db = db;
    }


  }
}