using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class
{
        public class Human
        {
            public int no_of_finger;
            public string FoodType;

            // Constructor
            public Human(int noofFinger)
            {
                no_of_finger = noofFinger;
            }

            public void print_no_of_finger()
            {
                Console.WriteLine("No. of finger: " + no_of_finger);
            }

            public virtual void DisplayBehaviour()
            {
                Console.WriteLine("He is " + FoodType);
            }
        }

        public sealed class SuperHuman : Human
        {
            public string Power;

            // Constructor
            public SuperHuman(int noofFinger, string power) : base(noofFinger)
            {
                Power = power;
            }

            public void ShowPower()
            {
                Console.WriteLine("Superpower: " + Power);
            }

            // Overriding DisplayBehaviour
            public override void DisplayBehaviour()
            {
                base.DisplayBehaviour();
                Console.WriteLine("And has a superpower: " + Power);
            }
        }
    }

