using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Person 
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public static Double AverageAge;
        public static int counter;

        public Person()
        {
            counter++;
        }

        public string GetFullName()
        {
            string fullName = "";
            FirstName = FirstName.Trim() + " ";
            fullName = string.Concat(this.FirstName, this.LastName);
            return fullName;
        }

        public void PrintNameAndAge()
        {
            Console.WriteLine("\nYour full name is " + this.GetFullName());
            Console.WriteLine("and you are " + this.Age + " years old.");
        }
    }
}
