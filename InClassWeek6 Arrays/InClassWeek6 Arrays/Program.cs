using System;

namespace InClassWeek6_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // *********************************************** Monday 11/25/19 ************************************************************

            //string person1 = "Lopa";
            //string person2 = "Shengyu";
            //string person3 = "Trevor";
            //string person4 = "Christi";
            //string person5 = "Ryan";

            string[] people = new string[5]; // length is 5 ; people is just refering to anywhere in memory 
            people[0] = "Maria";
            people[1] = "Naddie";
            people[2] = "Rafia";
            people[3] = "Christi";
            people[4] = "Ryan";

            string[] major = { "Cyber Security" ,
                               "Computer Science" ,
                               "Networking" ,
                               "Software Developer" ,
                               "Programming and Development" };

            string[] number = new string[5];
            number[0] = "2";
            number[1] = "4";
            number[2] = "5";
            number[3] = "28";
            number[4] = "55";

            Console.WriteLine($"Hello, {people[2]} !");

            for (int i = 0; i < people.Length; i++) // Here, length is 5 so the condition says less than 5 
            {
                Console.WriteLine(people[i] + ":" + major[i] + ":" + number[i]); 
                // writing i will print all elements in array from 0 till 4 (total 5)
            }

            foreach (string person in people) // people is name of array 
            {
                Console.WriteLine(person);
            }

            //********************* NO CLASS WEDNESDAY 11/25/19 ****************************************************
        } 
    }
}
