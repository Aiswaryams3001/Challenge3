using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Program
    {
        public class student
        {
            private string name;
            private int id;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public void displaydetails()
            {
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Id:" + id);
            }
        }
        
        static void Main(string[] args)
        {
            student obj = new student();
            obj.Name = "Aiswarya";
            obj.Id = 10;
            obj.displaydetails();
            Console.WriteLine("\npress any key to exit....");
            Console.ReadLine();
        }
    }
}
