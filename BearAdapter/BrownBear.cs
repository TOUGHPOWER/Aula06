using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BearAdapter
{
    public class BrownBear : IBear
    {
        public bool Hibernating { get; set; }

        public void Roar()
        {
            Console.WriteLine("Raaaaaarrrrrr");
        }
        public void LookAt(object objectToLookAt)
        {
            Console.WriteLine("Bear is lokking at:"+ objectToLookAt.ToString());
        }
        public void GoTowards(object objectToWalkTowards)
        {
            Console.WriteLine("Bear is walking towards:" + objectToWalkTowards.ToString());
        }
        public bool TryEat(object objectToEat)
        {
            Random rand = new Random();

            if(rand.Next(0,2) == 0)
            {
                Console.WriteLine("Bear has eaten: " + objectToEat.ToString());
                return true;
            }
            
            Console.WriteLine("Bear has tried to eat: " + objectToEat.ToString());
            return false;

        }
    }
}