using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNightHomework4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" +-------------------------------+ ");
            Console.WriteLine("|Welcome to Harry's Movie Theater!| ");
            Console.WriteLine(" +-------------------------------+ ");

            Console.WriteLine();

            string Showtime;

            TicketQuestions TQ = new TicketQuestions();
            DrinkQuestions TQ1 = new DrinkQuestions();

            Console.WriteLine("Would you like to buy tickets to the Matinee or Evening show?");
            Showtime = System.Console.ReadLine();

            TQ.TicketQuestion();
            TQ.FoodQuestion();
            TQ1.DrinkQuestion();

            if (TQ.Popcorn >= 1 && TQ1.Ldrink >= 1)
            {
                TQ.FoodTotal = (TQ.FoodTotal - 2.00);
            }
            else


            if (Showtime.ToUpper() == "MATINEE")
            {
                Console.WriteLine();
                Console.WriteLine(" +------------------------------+ ");
                Console.WriteLine("| Your subtotal is " + (TQ.TicketTotal1 + TQ.FoodTotal + TQ1.DrinkTotal) + " |");
                Console.WriteLine(" +------------------------------+ ");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(" +------------------------------+ ");
                Console.WriteLine("| Your subtotal is " + (TQ.TicketTotal2 + TQ.FoodTotal + TQ1.DrinkTotal) + " |");
                Console.WriteLine(" +------------------------------+ ");
            }

            Console.WriteLine ("press any key to continue....");
            Console.Read();
        }
    }
}