using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_creation_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;

            Course ClassItems = new Course();

            ClassItems.CourseQuestions();

            Console.WriteLine("How many students will be enrolled in this " + ClassItems.Name + " Course?");
            count = int.Parse(Console.ReadLine());

            Student[] students = new Student[count];

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
                students[i].StudentInfo();
            }

            ClassItems.Print();

            foreach (Student currentStudent in students)
            {
                currentStudent.Print();
            }

            Console.ReadKey();
        }
    }
}
