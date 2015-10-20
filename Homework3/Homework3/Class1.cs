using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Instructor
    {
        public string Name;
        public string CourseName;

        public Instructor(string Name, string CourseName)
        {
            this.Name = Name;
            this.CourseName = CourseName;
        }

        public void SetStudentGrade(Student student, int Grade)
        {
            
            student.Grade = Grade;
        }

   
    }
}
