using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C20_Console_06._14._2019
{
    class Student
    {
        public string Fullname { get; set; }
        public int Id { get; private set; }
        public List<Exam> ExamsList { get; set; }
        private static int stuId=1;
        public Student(string name)
        {
            Fullname = name;
            Id = stuId;
            stuId++;
          
        }
     
    }
}
