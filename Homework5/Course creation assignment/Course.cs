using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_creation_assignment
{
    public class Course
    {
        public string Name;
        private int CRNnum;
        private string crn;
        private string answer;

        public void CourseQuestions()
        {
            Console.WriteLine("Please enter the name of the course you are creating.");
            Name = Console.ReadLine();

            Console.WriteLine("Please enter the 8 digit CRN number for the " + Name + " course.");
            crn = Console.ReadLine();

            while (crn.Length != 8)
            {
                Console.WriteLine("Error. The number you entered is not valid, please try again");
                crn = Console.ReadLine();
            }
            CRNnum = int.Parse(crn);
        }

        public void Print()
        {
            Console.WriteLine("Please verify if the following is correct. Enter yes or no");
            Console.WriteLine("Course Name : " + Name);
            Console.WriteLine("Course CRN Number : " + CRNnum);
            answer = Console.ReadLine();

            if (answer.ToUpper() == "YES")
            {
                return;
            }
            else
            {
                while (answer.ToUpper() == "NO")
                {
                    CourseQuestions();
                    Print();
                }
            }
        }
    }
}
