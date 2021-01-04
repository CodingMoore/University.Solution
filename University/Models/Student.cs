using System.Collections.Generic;

namespace University.Models
{
  public class Student
  {
    public Student()
    {
      this.Classes = new HashSet<ClassStudent>();
    }

    public int StudentId { get; set; }
    public string StudentName { get; set; }

    public ICollection<ClassStudent> Classes { get; }
  }
}  