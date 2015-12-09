using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    class Elevator
    {
        private double MaxWeight;
        private int MaxOccupants;
        Passenger[] Occupants;
        
        

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];

            MaxWeight = maxWeight;

            MaxOccupants = maxOccupants;
        }
                
    public void AddOccupants(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }



        public double GetCurrentWeight()
        {
            double tWeight = 0;

            foreach (Passenger ppl in Occupants)
            {
                tWeight += ppl.GetWeight();
            }

            return tWeight;
        }
        
        public bool IsOverMaxCapacity()
        {
            if (GetCurrentWeight() >= MaxWeight)
            {
                return true;
            }
            else
            {
                return false;
            }   
        }
    }
}
