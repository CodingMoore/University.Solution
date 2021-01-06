using System.Collections.Generic; 

namespace University.Models
{
    public class Course
    {
        public Course()
        {
            this.JoinEntries = new HashSet<CourseStudent>(); //creating an empty hash set of course students. HashSet is an unordered collection of unique elements. "Studends" would be more accurately named "JoinEntries" since it is a HashSet of CourseStudents.
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public virtual ICollection<CourseStudent> JoinEntries { get; set; } //IColletion is basically a list. The ICollection<T> interface is the base interface for classes in the System.Collections.Generic namespace.
    }
}