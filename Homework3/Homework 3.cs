
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor john = new Instructor("John", "English");

            Instructor mike = new Instructor("Mike", "Math");

            Student jane = new Student("Jane", john);
            john.SetStudentGrade(jane, 95);

            Student joe = new Student("Joe", john);
            john.SetStudentGrade(joe, 85);

            Student melissa = new Student("Melissa", mike);
            mike.SetStudentGrade(melissa, 90);

            Student matt = new Student("Matt", mike);
            mike.SetStudentGrade(matt, 92);

            jane.Print("");

            Console.WriteLine();

            joe.Print("");

            Console.WriteLine();

            melissa.Print("");

            Console.WriteLine();

            matt.Print("");

            Console.ReadKey();
             
        }
    }
}
