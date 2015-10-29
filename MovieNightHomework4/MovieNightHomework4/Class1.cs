using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNightHomework4
{
    public class TicketQuestions
    {

        public int Ctickets;
        public int Atickets;
        public int Stickets;
        public int HotDogs;
        public int Popcorn;
        public int Candy;
        public double TicketTotal1;
        public double TicketTotal2;
        public double FoodTotal;


        public void TicketQuestion()
        {
            Console.WriteLine("How many child tickets would you like?");
            this.Ctickets = int.Parse(Console.ReadLine());

            Console.WriteLine("How many adult tickets would you like?");
            this.Atickets = int.Parse(Console.ReadLine());

            Console.WriteLine("How many senior tickets would you like?");
            this.Stickets = int.Parse(Console.ReadLine());

            this.TicketTotal1 = ((this.Ctickets * 3.99) + (this.Atickets * 5.99) + (this.Stickets * 4.50));

            this.TicketTotal2 = ((this.Ctickets * 6.99) + (this.Atickets * 10.99) + (this.Stickets * 8.50));

        }

        public void FoodQuestion()
        {
            Console.WriteLine("How many hot dogs would you like?");
            this.HotDogs = int.Parse(Console.ReadLine());

            Console.WriteLine("How many bags of popcorn would you like?");
            this.Popcorn = int.Parse(Console.ReadLine());

            Console.WriteLine("How many boxes of candy would you like?");
            this.Candy = int.Parse(Console.ReadLine());


            this.FoodTotal = ((this.HotDogs * 3.99) + (this.Popcorn * 4.50) + (this.Candy * 1.99));
        }



    }
}
