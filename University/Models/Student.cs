using System;

namespace Template.Models
{
  public class Child
  {
    public int ChildId { get; set; }
    public string Description { get; set; }
    public int ParentId { get; set; }
    public virtual Parent Parent { get; set; }
  }
}  