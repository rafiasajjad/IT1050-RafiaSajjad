using System;

namespace Lab_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 2 
            /*
             A one-dimensional array p contains four elements. The array access expressions to access each 
             of the elements in p are __p[0]__, ___p[1]___,____p[2]___ and __p[3]____. 
            */

            // Part 3
            string[] months = new string[12];
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August"; 
            months[8] = "September"; 
            months[9] = "October"; 
            months[10] = "November";
            months[11] = "December";

            for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine( i + " : " + months[i] );
            }

            // Part 4
            string[] seasons = new string[4];
            seasons[0] = "Summer";
            seasons[1] = "Fall";
            seasons[2] = "Winter";
            seasons[3] = "Spring";

            foreach (string s in seasons)
            {
                Console.WriteLine(s); 
            }

            // Part 5
            int[] randomNumber = new int[1000];
            Random random = new Random();

            for (int i = 0; i < randomNumber.Length; i++)
            {
                randomNumber[i] = random.Next(0, 100);
            }

            foreach (int i in randomNumber)
            {
                Console.WriteLine(i);
            }

            // Part 6
           
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int j = 0;

            while (j < names.Length)

            {

                Console.WriteLine(names[j]);
                j++; 

            }
            

            // Part 7 
            
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int j = 0;

            while (j < names.Length)

            {

                Console.WriteLine("{0,2}. {1}", j, names[j]);
                j++;

            }
            

            // Part 8 

            /*
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            foreach (string n in names)
            {
                Console.WriteLine(n); 
            }
            */

        }
    }
}
