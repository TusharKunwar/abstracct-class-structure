using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
        // Abstract class
        public abstract class Human
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

            // Abstract method
            public abstract void DisplayBehaviour();
        }

        // Concrete class inheriting from abstract class
        public class SuperHuman : Human
        {
            public string Power;

            // Constructor
            public SuperHuman(int noofFinger, string power) : base(noofFinger)
            {
                Power = power;
            }

            // Implementing abstract method
            public override void DisplayBehaviour()
            {
                Console.WriteLine("He is " + FoodType);
                Console.WriteLine("And has a superpower: " + Power);
            }

            public void ShowPower()
            {
                Console.WriteLine("Superpower: " + Power);
            }
        }
    }
