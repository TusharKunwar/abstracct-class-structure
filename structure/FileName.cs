using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
        // Struct definition
        public struct Human
        {
            public int NoOfFingers;
            public string FoodType; 

            // Constructor
            public Human(int noOfFingers, string foodType)
            {
                NoOfFingers = noOfFingers;
                FoodType = foodType;
            }

            // Method to print number of fingers
            public void PrintNoOfFingers()
            {
                Console.WriteLine("No. of fingers: " + NoOfFingers);
            }

            // Method to display behaviour
            public void DisplayBehaviour()
            {
                Console.WriteLine("He is " + FoodType);
            }
        }

        public class SuperHuman
        {
            public string Power;

            // Constructor
            public SuperHuman(string power)
            {
                Power = power;
            }

            public void ShowPower()
            {
                Console.WriteLine("Superpower: " + Power);
            }
        }
    }
