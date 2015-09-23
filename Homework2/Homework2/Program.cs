using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person #1 Please enter your first name");
            Person newperson = new Person();
            Console.Write("First name = ");
            newperson.FirstName = Console.ReadLine();

            Console.WriteLine("Person #1 Please enter your last name ");
            Console.Write("Last name = ");
            newperson.LastName = Console.ReadLine();

            Console.WriteLine("Person #1 Please enter your age ");
            Console.Write("Age = ");
            newperson.Age = int.Parse(Console.ReadLine());
            Person.AverageAge += newperson.Age;

            Console.WriteLine("Person #1 Are you married ");
            if (Console.ReadLine().ToUpper() == "YES")
            {
                Console.WriteLine("Person #1 Please enter your spouces' first name");
                newperson.Spouse = new Person();
                Console.Write("Spouces' First name = ");
                newperson.Spouse.FirstName = Console.ReadLine();

                Console.WriteLine("Person #1 Please enter your spouces' age");
                Console.Write("Spouces' age = ");
                newperson.Spouse.Age = int.Parse(Console.ReadLine());
                Person.AverageAge += newperson.Spouse.Age;
            }


            Console.WriteLine();


            Console.WriteLine("Person #2 Please enter your first name");
            Person newperson1 = new Person();
            Console.Write("First name = ");
            newperson1.FirstName = Console.ReadLine();

            Console.WriteLine("Person #2 Please enter your last name ");
            Console.Write("Last name = ");
            newperson1.LastName = Console.ReadLine();

            Console.WriteLine("Person #2 Please enter your age ");
            Console.Write("Age = ");
            newperson1.Age = int.Parse(Console.ReadLine());
            Person.AverageAge += newperson1.Age;

            Console.WriteLine("Person #2 Are you married");
            if (Console.ReadLine().ToUpper() == "YES") 
            {
                Console.WriteLine("Person #2 Please enter your spouces' first name");
                newperson1.Spouse = new Person();
                Console.Write("Spouces' First name = ");
                newperson1.Spouse.FirstName = Console.ReadLine();

                Console.WriteLine("Person #2 Please enter your spouces' age");
                Console.Write("Spouces' age = ");
                newperson1.Spouse.Age = int.Parse(Console.ReadLine());
                Person.AverageAge += newperson1.Spouse.Age;
            }


            Console.WriteLine();


            Console.WriteLine("Person #3 Please enter your first name");
            Person newperson2 = new Person();
            Console.Write("First name = ");
            newperson2.FirstName = Console.ReadLine();

            Console.WriteLine("Person #3 Please enter your last name ");
            Console.Write("Last name = ");
            newperson2.LastName = Console.ReadLine();

            Console.WriteLine("Person #3 Please enter your age ");
            Console.Write("Age = ");
            newperson2.Age = int.Parse(Console.ReadLine());
            Person.AverageAge += newperson2.Age;

            Console.WriteLine("Person #3 Are you married");
            if (Console.ReadLine().ToUpper() == "YES") 
            {
                Console.WriteLine("Person #3 Please enter your spouces' first name");
                newperson2.Spouse = new Person();
                Console.Write("Spouces' First name = ");
                newperson2.Spouse.FirstName = Console.ReadLine();

                Console.WriteLine("Person #3 Please enter your spouces' age");
                Console.Write("Spouces' age = ");
                newperson2.Spouse.Age = int.Parse(Console.ReadLine());
                Person.AverageAge += newperson2.Spouse.Age;
            }


            Console.WriteLine();

            newperson.PrintNameAndAge();
            if (newperson.Spouse != null)
                newperson.Spouse.PrintNameAndAge();
            newperson1.PrintNameAndAge();
            if (newperson1.Spouse != null)
                newperson1.Spouse.PrintNameAndAge();
            newperson2.PrintNameAndAge();
            if (newperson2.Spouse != null)
                newperson2.Spouse.PrintNameAndAge();

            Person.AverageAge /= Person.counter;

            Console.WriteLine("\nAverage age = " + Person.AverageAge);

            Console.Read();




        }
    }
}
