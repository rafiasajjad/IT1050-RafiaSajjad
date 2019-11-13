using System;

namespace InClassWeek4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i<11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (int j = 1; j < 11; j++)
            //{
            //    Console.WriteLine(j); 
            //}

            //for (int j = 10; j > 0; j = j - 1)
            //{
            //    Console.WriteLine(j); 
            //}

            //Console.WriteLine("Between loops....");

            //int k = 10;
            //for (; ;)
            //{
            //    Console.WriteLine(k);
            //    k = k - 1;
            //    if (k < 1)
            //        break;

            string itemDescription;
            double total = 0d;
            string doContinue;
            string display;
            do
            {
                Console.Write("Enter the item (or x to end): ");
                itemDescription = Console.ReadLine();

                Console.Write("Enter the price of the item: ");
                double itemPrice = Convert.ToDouble(Console.ReadLine());

                total = total + itemPrice;

                display +- itemDescription + "\t" + Math.Round(total, 2) + "\n";


                Console.Write("Would you like to continue (y|n) ?");
                doContinue = Console.ReadLine();
            } while (doContinue != "n");

            Console.WriteLine("Subtotal\t" + Math.Round(total,2) "\n" );
            Console.WriteLine("Tax Amount\t" + total * 0.7);
            Console.WriteLine("Total\t" + total * 1.07); 


        }

    }
}