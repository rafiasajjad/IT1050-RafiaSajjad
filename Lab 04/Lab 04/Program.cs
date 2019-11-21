using System;

namespace Lab_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 2 
            /*
               The four basic elements of the counter-controlled repetition are as follows:
               (1) Control Variable: This is the loop counter that is used to control the flow of the repetition.
               (2) Initial Value: It is the initial value of the control variable which enables it to start the loop.
               (3) Increment/Decrement Value: It is the value by which the control variable is modified for each iteration of the loop.
               (4) Loop-Continuation Condition: A condition which determines if the loop should continue. This condition sets a 
                   limit for the loop as otherwise it will create an infiniite loop. 
            */

            // Part 3
            /*
                    WHILE                   |               FOR
           Repeatedly execute statements    |       Repeatedly execute statements               
           as long as loop-continuation     |       as long as loop-continuation            
           condition remains true           |       condition  remains true     
                                            |
           Execute their bodies zero        |       Execute their bodies zero            
           or more times                    |       or more times
                                            |
           Control variable is normally     |       Specifies the counter-controlled 
           initialized before the loop and  |       repetition details in its header
           incremented in the loop's body   |                      
                                            |
           Typically, used for              |       Typically, used for counter-controlled
           sentinel-controlled repetition   |       repetition
           (can be used for either          |       (can be used for either repetition type)
           repetition type)                 | 
                                            |
            */

            // Part 4
            /*
               It would be more appropriate to use a do-while statement when validating user input. 
               If we want to make a program where the program will run as long as the user inputs a positive
               value, we will use the do-while statement. The body of the do-while statement will contain the ReadLine 
               statement to enter user input; the loop-continuation condition would determine whether 
               the value entered is less than 0. If so, the loop will repeat and it will prompt the user 
               again for input. This wil continue until the user enters a value greater than or equal to zero. 
               One they do, the criteria is met, the loop-continuation condition becomes false and loop terminates. 
               This leads to the program to continue past the loop. 

               A do-while statement tests the loop-continuation condition after executing the loop’s
               body therefore, the body always executes at least once. A while statement tests the 
               loop-continuation condition before executing the loop’s body. This is because the program 
               would need to include the statements required to execute at least once before the loop and 
               in the body of the loop. A do-while statement avoids this duplication of code. 
            */

            // Part 5
            
             for ( int i = 1; i <= 100 ; i++)
             {
                 Console.Write(i);
                 if ((i%2) == 0)
                 {
                     Console.WriteLine("\t Even");
                 }
                 else
                 {
                     Console.WriteLine("\t Odd");
                 }

             }
             

            // Part 6 
            
            int temperature;
            Console.Write("Please enter a temperature: ");
            temperature = Convert.ToInt32(Console.ReadLine());

            if ( temperature < 10 )
            {
                Console.WriteLine("Polar Bear");
            }
            else if(temperature < 20)
            {
                Console.WriteLine("Penguin");
            }
            else if (temperature < 40)
            {
                Console.WriteLine("Moose");
            }
            else if (temperature < 50)
            {
                Console.WriteLine("Reindeer");
            }
            else if (temperature < 60)
            {
                Console.WriteLine("Deer");
            }
            else if (temperature < 70)
            {
                Console.WriteLine("Turtle");
            }
            else if (temperature < 80)
            {
                Console.WriteLine("Lion");
            }
            else if (temperature < 90)
            {
                Console.WriteLine("Fish");
            }
            else
            {
                Console.WriteLine("Bug");
            }
            

            // Part 7

            // ** Infinite Loop, fixed by adding j++ **

            int j = 10;
            while (j < 21)
            {
                Console.WriteLine(j);
                j++;
            }
            
            // Part 8 

            // ** Syntax Error, for loop did not have {} ** 

            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("********");
            }
            

        }
    }
}
