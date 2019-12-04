using System;
using System.Collections.Generic;
using System.Text;

namespace In_Class_Week_7_PART_2
{
    class ReceiptItem
    {
        public string description;
        public double amount;
        public int quantity;

        public ReceiptItem(string description, double amount, int quantity)
        {
            this.description = description;
            this.amount = amount;
            this.quantity = quantity;
        }

        public void Print()
        {
            Console.Write($"{this.quantity}x", 3); // the numbers represent a certain width, just so it prints/displays neatly 
            Console.Write($"{this.description}x", 10);
            Console.Write($"@${this.amount}", 3);
            Console.Write($"@${(this.amount * this.quantity)}", 5);
        }
    }
}