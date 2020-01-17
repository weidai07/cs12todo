using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
    {
        public Category()
        {
            this.TestName = new HashSet<Item>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Item> TestName { get; set; }
    }
}