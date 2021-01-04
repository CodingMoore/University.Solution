using System;

namespace University.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    public string Description { get; set; }
    public int ClassId { get; set; }
    public virtual Class Class { get; set; }
  }
}  