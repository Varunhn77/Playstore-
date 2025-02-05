using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstore
{
    public class Categories
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        //Constructor
        //Class name and method name should be same
        //it will triger automatically when object created.

        public Categories(int id, string name, string description)
        {
            Id = id;
            Name = name;    
            Description = description;
        }

        public Categories()
        {

        }

        public void AddCategory(int id, string name)
        {
            Console.WriteLine("Category details: " + id + "," + name);
        }

        public void AddCategory(int id, string name, string description)
        {
            Console.WriteLine("Category details: " +id + "," + name + "," +description);
        }
    }
}
