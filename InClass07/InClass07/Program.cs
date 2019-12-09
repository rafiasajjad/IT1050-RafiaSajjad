using System;

namespace InClass07_James_Leasure
{
    class Program
    {
        static void Main(string[] args)
        {
            Receipt receipt1 = new Receipt();

            Console.WriteLine("New Receipt");

            while (true)
            {
                Console.Write("Enter Description (e to end): ");
                string description = Console.ReadLine();
                if (description == "e")
                {
                    break;
                }
                Console.Write("Enter Amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                receipt1.AddItem(description, amount, quantity);
                Console.WriteLine();
            }
            //receipt1.AddItem("Classic Italian Sub", 2.49, 1);
            //receipt1.AddItem("Side of Fruit", 1.25, 2);
            Console.WriteLine();
            receipt1.PrintReceipt();
        }
    }
}
