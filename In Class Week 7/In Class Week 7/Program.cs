using System;
using System.Collections.Generic; 

namespace In_Class_Week_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // ****************************** Monday 12/2/19 *************************************

            // to use List // just like an array where we can loop through itmes 
            // arrays need to be described of how many we need beforehand
            // list is not fixed size

            /*
            List<string> items;
            items = new List<string>();

            items.Add("Bread");
            items.Add("Peanut Butter");
            items.Add("Bananas");

            Console.WriteLine(items[0]);

            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
            */

            // **************************** Receipt ************************************

            Receipt receipt1 = new Receipt();
            receipt1.AddItem("Classic Italian Sub", 2.49, 1);
            receipt1.AddItem("Chicken Shawarma", 5.99, 2); 
            receipt1.PrintReceipt();
        }
    }
}
