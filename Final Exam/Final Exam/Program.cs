using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            bool elevator1IsOverMaxCapacity;

            Elevator elevator1;

            elevator1 = new Elevator(2, 400);

            Passenger person1 = new Passenger("A1", 180);

            elevator1.AddOccupants(person1, 0);

            Passenger person2 = new Passenger("A2", 200);

            elevator1.AddOccupants(person2, 1);

          

            elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();


            bool elevator2IsOverMaxCapacity;

            Elevator elevator2;

            elevator2 = new Elevator(3, 600);

            Passenger person3 = new Passenger("A1", 200);

            elevator2.AddOccupants(person3, 0);

            Passenger person4 = new Passenger("A2", 200);

            elevator2.AddOccupants(person4, 1);

            Passenger person5 = new Passenger("A3", 201);

            elevator2.AddOccupants(person5, 2);

            

            elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();
            
        }
    }
}
