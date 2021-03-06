﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dice_Roller;

namespace Dice_Roller
{
    public class roll
    {
        public static void RollDice(Dice d1) // START ROLLING THE DICE -- Defining that a Dice object needs to be passed in to this function and calling it d1
        {
            Random rnd = new Random(); // creates a random number and stores it as the variable rnd
            Console.WriteLine("You Rolled:");
            List<int> arrayList = new List<int>(); // Creates a new empty array(list) of numbers
            for (int i = 0; i < d1.Number; i++) // Rolling the dice 1 at a time until the full amount have been rolled
            {
                int roll = rnd.Next(1, (d1.Sides + 1)); // returns a random value between 1 and the number of sides+1
                int totalRolled = roll; // sets the value the roll landed on
                arrayList.Add(totalRolled); // adds the value of the roll to the array
            }
            int total = arrayList.Sum(); // Sum of the array is defined here before I add text.
            foreach (int item in arrayList) // ForEach loop to write out all the elements of the array
            {
                if (item == d1.Sides)
                {
                    Console.WriteLine(item.ToString() + " Crit!"); // Add the the term Crit if a roll hits the maximum value
                }
                else
                {
                    Console.WriteLine(item.ToString()); // prints the value into the console so it can be viewed
                }
            }
            Console.WriteLine("Total: " + total); //Displays the total rolled of all dice.
        }
    }
}
