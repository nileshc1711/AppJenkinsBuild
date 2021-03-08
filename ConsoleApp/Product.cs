using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string  Description { get; private set; }

        public Product(int id, string name, string description)
        {
            // this is test.
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
    }
}
