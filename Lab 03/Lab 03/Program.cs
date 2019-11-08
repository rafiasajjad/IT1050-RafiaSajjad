using System;

namespace Lab_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 2
            /*
            The if single - selection statement and the while repetition statement both perform an action
            (or set of actions) based on whether a condition is true or false.However,if the condition is true, 
            the if single - selection statement performs the action(s) once, whereas the while repetition 
            statement repeatedly performs the action(s) until the condition becomes false.
            */

            // Part 3 
            int speedLimit = 35;
            int speed = 42;
            if ( speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW");
            }

            // Part 4

            bool isTrue = 100 <= 100;
            if (isTrue)
            {
                Console.WriteLine("It is True!");
            }
            else
            {
                Console.WriteLine("It is False!");
            }

            //bool isTrue = 100 <= 0;
            //if (isTrue)
            //{
            //    Console.WriteLine("It is True!");
            //}
            //else
            //{
            //    Console.WriteLine("It is False!");
            //}

            // Part 5 
            double fahrenheit;
            Console.Write("Enter temperature in Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius;
            celsius = (fahrenheit - 32d) * 5d / 9d;

            Console.WriteLine("Temperature in Celsius is: {0}" , celsius);

            if (fahrenheit <= 40)
            {
                Console.WriteLine("It is cold");
            }
            if (fahrenheit >= 90)
            {
                Console.WriteLine("It is hot");
            }

            // Part 6
            int x = 1;
            while (x <= 10 )
            {
                Console.WriteLine(x);
                x++;
            }

            // Part 7
            int y = 60;
            while (y >= 20)
            {
                Console.WriteLine(y);
                y -= 5;
            }

            // Part 8
            int z = 10;
            while (z <= 20)
            {
                Console.WriteLine(z);
                z += 2;
            }
        }

    }
}
