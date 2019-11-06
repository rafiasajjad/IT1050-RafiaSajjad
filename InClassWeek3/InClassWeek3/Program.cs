using System;

namespace InClassWeek3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Monday 11/04/19 *******************************************

            /* 
             int grade = 12;

             if (grade > 60)
             {
                 Console.WriteLine("Passed!");
             }
             else
             {
                 Console.WriteLine("Failed!");
             }
             */

            /*
            int grade = 75;

            if (grade > 89)
            {
                Console.WriteLine("A");
            }
            else if (grade > 79)
            {
                Console.WriteLine("B");
            }
            else if (grade > 69)
            {
                Console.WriteLine("C");
            }
            else if (grade > 59)
            {
                Console.WriteLine("D");
            }
            else 
            {
                Console.WriteLine("Failed!");
            }
            */

            /*
            int temperature;
            temperature = 48;
            if (temperature < 32)
            {
                Console.WriteLine("It's Freezing!"); 
            }
            */
            /*
            int i = 10;
            while (i > 0)
            {
                Console.WriteLine(i);
                i = i - 1; 
            }
            */

            /*
            int i = 10;
            while (i > 0)
            {
                i = i - 1;
                Console.WriteLine(i);
            }
            */

            /*
            int i = 1;
            while (i < 41)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                //i = i + 1; 
                i++;
            }
            */

            // Wednesday 11/6 *************************
            /*
            int i = 100;
            while (i >= 0)
            {
                Console.WriteLine(i);
                i = i - 10;
            }

            int x = 0;
            while (x <= 100)
            {
                Console.WriteLine(x);
                x = x + 10;
            }
           */

            /*
            int maxValue;
            Console.WriteLine("Enter the Max Value: ");
            maxValue = Convert.ToInt32(Console.ReadLine());

            int incrementValue;
            Console.WriteLine("Enter the Increment/Decrement Value: ");
            incrementValue = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            while (i <= maxValue)
            {
                Console.WriteLine(i);
                i += incrementValue;
            }

            i -= incrementValue * 2;

            while (i >= 0)
            {
                Console.WriteLine(i);
                i -= incrementValue;
            }
            */

            /*
            int j = 0;
            while (j < 100000000)
            {
                Console.WriteLine(j);
                break;
                j++;
            }
            Console.WriteLine(j);
            */

            /*
            int j = 0;
            while (j < 10000)
            {
                Console.WriteLine(j);
                j++;
                continue;
                Console.WriteLine("This is the end of the loop");
            }
            */

            /*
            //int j = 0;
            //Console.WriteLine(j++);
            //Console.WriteLine(j);

            //int j = 0;
            //Console.WriteLine(++j);
            //Console.WriteLine(j);
            
            //int j = 11;
            //while (j > 1) 
            //{
            //    Console.WriteLine(--j);
            //}
            */

            /*
            int x = 11 ;
            while (--x > 0)
            {
                Console.WriteLine(x + "is");
                Console.WriteLine(x % 2 == 0 ? "even" : "odd");
                Console.WriteLine(x == 5 ? "Favorite Number!" : "");
            }
            */

            /*
            int i = 1; //rows
            int j = 1; //columns
            while (i <= 6)
            {
                while (j <= 6)
                {
                    Console.Write("{0} , {1}    " , i , j);
                    j++;
                }
                Console.WriteLine();
                j = 1;
                i++;
            }
            */

           /*
            char c = 'A';
            while (c <= 'z')
            {
                if (c == 'a')
                {
                    Console.WriteLine();
                }

                if (Char.IsLetter(c))
                {
                   Console.Write(c.ToString());
                }
                c++;
            }

           */
        }
    }
}
