using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname;
            string minitial;
            string lname;
            string fullname;
            int age;
            bool isCitizen;
            int heightFeet;
            double heightinches;
            double totalHeightCM;



            Console.WriteLine("Please enter your first name.");
            fname = System.Console.ReadLine();

            Console.WriteLine("Please enter your middle initial.");
            minitial = System.Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            lname = System.Console.ReadLine();


            Console.WriteLine();


            minitial = " " + minitial.Trim();
            lname = ". " + lname.Trim();


            Console.WriteLine(fullname = string.Concat("Your full name is " + fname, minitial, lname));


            Console.WriteLine();


            Console.WriteLine("What is your hight? (Please enter 4, 5, or 6 Feet.)");
            heightFeet = int.Parse(System.Console.ReadLine());

            Console.WriteLine("How many inches beyond your base height are you?");
            heightinches = double.Parse(System.Console.ReadLine());


            Console.WriteLine();


            Console.WriteLine(totalHeightCM = ((heightFeet * 12) * 2.54) + (heightinches * 2.54));


            Console.WriteLine();


            Console.WriteLine("Please enter your age.");
            age = int.Parse(System.Console.ReadLine());
            
            Console.WriteLine("Are you a Citizen? (Please enter Yes or No.)");
            isCitizen = Console.ReadLine().ToUpper() == "YES";

            Console.WriteLine();

            try
            {
                if (age >= 18 && isCitizen == true)
                {
                    Console.WriteLine("You can vote!");
                }
                else
                {
                    Console.WriteLine("Sorry but you can't vote.");
                }
                Console.ReadLine();
                return;
            }
            catch { }

            Console.WriteLine("Press any key to exit... ");

        }
    }
}
