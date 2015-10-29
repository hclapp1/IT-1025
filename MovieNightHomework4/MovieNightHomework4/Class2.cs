using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNightHomework4
{
    public class DrinkQuestions
    {
        public int Ldrink;
        int Sdrink;
        string DrinkAnswer;
        string DrinkAnswer1;
        public double DrinkTotal;

        public void DrinkQuestion()
        {

            Console.WriteLine("Would you like a drink?");
            DrinkAnswer = Console.ReadLine();

            if (DrinkAnswer.ToUpper() == "YES")
            {
                Console.WriteLine("Large or Small?");
                DrinkAnswer1 = Console.ReadLine();
            }
            else
            {
                return;
            }

            if (DrinkAnswer1.ToUpper() == "SMALL")
            {
                Console.WriteLine("How many Small drinks would you like?");
                Sdrink = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("How many Large drinks would you like?");
                Ldrink = int.Parse(Console.ReadLine());

                DrinkTotal = ((Ldrink * 5.99) + (Sdrink * 3.50));
            }
        }
    }
}
