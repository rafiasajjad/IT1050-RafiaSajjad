using System;

namespace Reciept_Example_Week_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberItems;
            Console.Write("Enter total number of items in cart: "); 
            numberItems = Convert.ToInt32(Console.ReadLine()); 

            string[] items = new string[numberItems];

            double[] amounts = new double[numberItems];

            for (int i = 0; i < numberItems; i++)
            {
                Console.Write("Enter item description: ");
                items[i] = Console.ReadLine();

                Console.Write("Enter item cost: ");
                amounts[i] = Convert.ToDouble(Console.ReadLine());
            }

            double total = 0d;
            Console.WriteLine("**********************");
            Console.WriteLine("Item     \tAmount");
            Console.WriteLine("**********************");

            for (int i = 0; i < amounts.Length; i++)
            {
                total += amounts[i];
                Console.WriteLine($"{items[i]}       \t{amounts[i]}");
            }

            Console.WriteLine("**********************");

            Console.WriteLine("Total    \t" + total);
            Console.WriteLine("Tax Amount    \t" + (total * .07) );
            Console.WriteLine("Total w/ tax \t" + (total * 1.07) );
            Console.WriteLine("**********************");
            /*
            user input number of items in the reciept 
            create an string array for the description of those items and an array for the amount of each item (double/decimal)
            for loop for no. of items
                  input amt and item desc 
            foreach item
                  add amt to running total 
                  output each item 
            output reciept total
            */
        }
    }
}
