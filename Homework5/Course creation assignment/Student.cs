using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_creation_assignment
{
    public class Student
    {
        private string Name;
        private int SNum;
        private string snum;
        private string answer;

        public void StudentInfo()
        {
            Console.WriteLine("Please enter the students first and last name.");
            Name = Console.ReadLine();

            Console.WriteLine("Please enter the students 5 digit S Number.");
            snum = Console.ReadLine();
            
            while (snum.Length != 5)
            {
                Console.WriteLine("Error. The number you entered in invalid, please try again.");
                snum = Console.ReadLine();
            }
            SNum = int.Parse(snum);
        }

        public void Print()
        {
            Console.WriteLine("Please verify if the following is correct. Enter yes or no");
            Console.WriteLine("Student name : " + Name);
            Console.WriteLine("Student S Number : " + SNum);
            answer = Console.ReadLine();

            if (answer.ToUpper() == "YES")
            {
                return;
            }
            else
            {
                while (answer.ToUpper() == "NO")
                {
                    StudentInfo();
                    Print();
                }
            }
        }
    }
}
