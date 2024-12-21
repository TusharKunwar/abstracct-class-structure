using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_3;

namespace lab_3
{
    public class Human
    {
        public int no_of_finger;
        public string FoodType;

        //constructor
        public Human(int noofFinger)
        {
            no_of_finger = noofFinger;
        }

        public void print_no_of_finger()
        {
            Console.WriteLine("No. of finger:" + no_of_finger);
        }

        public void DisplayBehaviour()
        {
            Console.WriteLine("He is " + FoodType);
        }
    }
}