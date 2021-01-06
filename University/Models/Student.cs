using System.Collections.Generic;

namespace University.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntries = new HashSet<CourseStudent>();
    }

    public int StudentId { get; set; }
    public string StudentName { get; set; }

    public ICollection<CourseStudent> JoinEntries { get; }
  }
}  