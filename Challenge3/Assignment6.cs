using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Challenge3
{
    class student
    {
        int id;
        string name;
        int[] mark = new int[3];
        int total;
        public void read()
        {
            Console.WriteLine("Enter id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter marks of 3 subjects");
            for (int i = 0; i < 3; i++)
            {
                mark[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void calculate()
        {
            total = mark[0] + mark[1] + mark[2];
        }
        public void display()
        {
            Console.WriteLine("Id={0}\nName={1}\nTotal={2}", id, name, total);
        }
    }
    internal class Assignment6
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number of students");
            n = Convert.ToInt32(Console.ReadLine());
            student[] obj = new student[n];
            for (int i = 0; i < n; i++)
            {
                obj[i] = new student();
                obj[i].read();
                obj[i].calculate();
                obj[i].display();
            }
            Console.ReadLine();
        }

    }
}
