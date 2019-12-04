using System;
using System.Collections.Generic;
using System.Text;

namespace In_Class_Week_7
{
    class Receipt
    {
        public string storeName;
        public string address;
        public string phone;
        public string transactionId;
        public List<string> itemDescrption;
        public List<double> itemAmount;
        public List<int> itemQuantity;
        public string footer;

        public Receipt() //constructor method (no return type, same name as class)
        {
            storeName = "Marc's Southland";
            address = "6849 SL Dr. \nParma, OH 44130";
            phone = "440-888-8872";

            itemDescrption = new List<string>();
            itemAmount = new List<double>();
            itemQuantity = new List<int>();
            footer = "Have a nice day!";
            transactionId = Guid.NewGuid().ToString("N");
        }
         
        public void AddItem(string desc, double amt, int quantity)
        {
            this.itemDescrption.Add(desc);
            this.itemAmount.Add(amt);
            this.itemQuantity.Add(quantity);
        }

        public int ItemCount()
        {
            return this.itemDescrption.Count;
        }

        public void PrintReceipt()
        {
            Console.WriteLine(this.storeName);
            Console.WriteLine(this.address);
            Console.WriteLine(this.phone);
            Console.WriteLine();
            Console.WriteLine($"Trans. Id:\n{this.transactionId}");
            Console.WriteLine();

            // TODO: Print items and totals 
            for (int i = 0; i < this.ItemCount(); i++)
            {
                Console.Write("{0}x", this.itemQuantity[i]);
                Console.Write("{0}", this.itemDescrption[i]);
                Console.Write(" @{0}", this.itemAmount[i]);
                Console.Write("  {0}", (this.itemAmount[i] * this.itemQuantity[i]));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine(this.footer);
        }

        

    }
}
