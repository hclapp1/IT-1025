using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Student
    {
        public string Name;
        public int Grade;
        public Instructor Teacher;

        public Student(string studentname, Instructor teacher)
    {
            this.Name = studentname;
            this.Teacher = teacher;
            this.Grade = 0;
    }

        public void Print(string printtxt)
        {
            string output = this.Name;
            output += " ";
            output += "was assigned a grade of ";
            output += this.Grade;
            output += " given by ";
            output += this.Teacher.Name;
            output += " who teaches ";
            output += this.Teacher.CourseName;

            output += ".";
            System.Console.WriteLine(output);
        }
    }   
}

