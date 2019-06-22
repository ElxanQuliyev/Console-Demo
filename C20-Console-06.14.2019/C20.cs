using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C20_Console_06._14._2019
{
    class C20
    {
        public List<Student> Students { get; set; }
        public C20()
        {
            Students = new List<Student>();
        }
        public void AddStudent()
        {
            Console.WriteLine("-----****------");
            Console.WriteLine("Please,write Student Name");
            string stuName = Console.ReadLine();
            if (stuName.Length > 0)
            {
                Student st = new Student(stuName);
                Students.Add(st);
            }
        }

    }
}
