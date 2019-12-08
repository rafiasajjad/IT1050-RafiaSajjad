using System;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 2
            /*
             The three tyes of control structures are as follows:
             1) Sequential Structure: This structure is built into C#. The computer executes C# statements 
             one after the other in the order in which they are written - in sequence. 
             2) Selection Statements: C# has three types of selection statements. The if statement (single -
             selection) performs an action if a condition is true or skips the action if the condition is false.
             The if-else statement (double-selection) performs an action if a condition is true or performs 
             a different action if the condition is false. The switch statement (multiple-selection) performs one 
             of many different actions, depending on the value of an expression. 
             3) Iteration/Repetition/Looping Statements: C# provides four iteration statements that enable programs
             to perform statements repeatedly as long as the loop-continuation condition remains true. They are: 
             while, do...while, for, and foreach.
            */

            // Part 3
            /*
            int i = 15;
            bool keepLooping = true;
            while (keepLooping)
            {
               if (i <= 14)
               {
                    keepLooping = false;
                    i++;
               }
                Console.WriteLine(i);
            }
            */

            // Part 4
            int j = 2;
            while ( j <= 128)
            {
                Console.WriteLine($"[{j}]");
                j = j * 2;

                if (j == 128)
                {
                    break;
                }
            }

            Console.WriteLine();

            // Part 5
            for ( int k = 49 ; k >= 1; k-- )
            {
               Console.Write(k);
                if ( k == 1 )
                {
                    break;
                }
                Console.Write(",");            
            }

            Console.WriteLine();
            Console.WriteLine();

            // Part 6
            int l = 1;
            while( l <= 21 )
            {
                Console.Write(l);
                Console.Write(" ");
                l = l + 2; 
            }

            Console.WriteLine();
            Console.WriteLine();

            // Part 7
            int m = 8;

            int n = 10; // initialize 

            do
            {

                Console.Write("*");

                n++; // update! 

            } while (n < m); // test condition 

            /* The output for the above code is " * ". 
             When using a while statement, the condition is checked at the beginning
             of the loop, before executing the loop's body. In this case, if we use the
             same condition ( i < n ), the condition is false so the body never executes.
             Here, we are using the do...while statement so the condition is checked
             after executing the loop's body. Therefore, the body is executed atleast
             once and we get " * " as a result. 
            */

            Console.WriteLine();
            Console.WriteLine();

            // Part 8
            /*
             You can combine multiple Boolean values by using the operator && for AND, 
             || for OR, and ! for NOT. 
            */
            bool icyRain = false;
            bool tornadoWarning = false; 
            if ( (icyRain == false) &&  (tornadoWarning == false))
            {
                Console.WriteLine("Let's go outside!");
            }

            Console.WriteLine();

            // Part 9 EXTRA CREDIT
            int layer = 5;
            int space;
            int number;

            for (int x = 5; x >= 1; x--)
            {

                for (space = 1; space <= (layer - x); space++)
                {
                    Console.Write(" ");
                }

                for (number = 1; number <= x; number++)
                {
                    Console.Write($"{number}");
                }

                for (number = (x-1); number >=1; number--)
                {
                    Console.Write($"{number}");
                }

                Console.WriteLine();
            }
        }
    }
}