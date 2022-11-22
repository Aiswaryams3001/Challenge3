using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class Student
    {
        private int Student_Id;
        private string Student_name;
        public void Student_Read()
        {
            Console.WriteLine("Enter Student Id ");
            Student_Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name ");
            Student_name = Convert.ToString(Console.ReadLine());
        }
        public void Student_display()
        {
            Console.WriteLine("Student Id " + Student_Id);
            Console.WriteLine("Student Name " + Student_name);
        }

    }
    class internals : Student
    {
        protected int Marks_internal;
        public void internals_Read()
        {
            Student_Read();
            Student_display();
            Console.WriteLine("Enter Marks of Internal ");
            Marks_internal = Convert.ToInt32(Console.ReadLine());
        }
        public void internals_display()
        {
            Console.WriteLine("Marks of Internal " + Marks_internal);
        }

    }
    class externals : internals
    {
        private int Marks_external;
        private int Marks_Total;
        public void externals_Read()
        {
            internals_Read();
            Console.WriteLine("Enter Marks of External ");
            Marks_external = Convert.ToInt32(Console.ReadLine());
        }
        public void externals_Calculate()
        {
            Marks_Total = Marks_internal + Marks_external;
        }
        public void externals_display()
        {
            internals_display();
            Console.WriteLine("Marks of External " + Marks_external);
            Console.WriteLine("Total Marks " + Marks_Total);
        }
    }
    internal class Assignment8
    {
        static void Main(string[] args)
        {
            externals ext = new externals();
            ext.externals_Read();
            ext.externals_Calculate();
            ext.externals_display();
            Console.ReadLine();
        }
    }
}
