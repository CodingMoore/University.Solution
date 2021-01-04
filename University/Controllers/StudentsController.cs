using Microsoft.AspNetCore.Mvc;
using Template.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Template.Controllers
{
  public class ChildsController : Controller
  {
    private readonly TemplateContext _db;

    public ChildsController(TemplateContext db)
    {
      _db = db;
    }

    
  }
}