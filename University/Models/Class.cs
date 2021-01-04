using System.Collections.Generic;

namespace University.Models
{
    public class Class
    {
        public Class()
        {
            this.Students = new HashSet<ClassStudent>();
        }

        public int ClassId { get; set; }
        public string NameOfClass { get; set; }
        public virtual ICollection<ClassStudent> Students { get; set; }
    }
}