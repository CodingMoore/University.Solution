using System.Collections.Generic;

namespace Template.Models
{
    public class Parent
    {
        public Parent()
        {
            this.Childs = new HashSet<Child>();
        }

        public int ParentId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Child> Childs { get; set; }
    }
}