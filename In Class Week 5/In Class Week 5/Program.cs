using System;

namespace In_Class_Week_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // ************** MONDAY 11/18/2019 ***********************************

            // ****COMPLETING LAST WEEK LECTURE****

            /*
            int magnitude;
            Console.Write("Enter Magniude: ");
            magnitude = Convert.ToInt32(Console.ReadLine());

            //if (magnitude == 4)
            //{
            //    Console.WriteLine("Small Earthquake");
            //}

            //if (magnitude == 5)
            //{
            //    Console.WriteLine("Moderate Earthquake");
            //}

            //if (magnitude == 6)
            //{
            //    Console.WriteLine("Moderate Earthquake");
            //}

            //if (magnitude == 7)
            //{
            //    Console.WriteLine("Major Earthquake");
            //}

            //if (magnitude == 8)
            //{
            //    Console.WriteLine("Great Earthquake");
            //}

            //if (magnitude == 9)
            //{
            //    Console.WriteLine("Great Earthquake");
            //}

            //if (magnitude == 10)
            //{
            //    Console.WriteLine("Super Earthquake");
            //}
            
            // Another way to do it using Switch 
            switch (magnitude)
            {
                case 4:
                    Console.WriteLine("Small Earthquake");
                    break;
                case 5:
                    Console.WriteLine("Moderate Earthquake");
                    break;
                case 6:
                    Console.WriteLine("Moderate Earthquake");
                    break;
                case 7:
                    Console.WriteLine("Major Earthquake");
                    break;
                case 8:
                    Console.WriteLine("Great Earthquake");
                    break;
                case 9:
                    Console.WriteLine("Great Earthquake");
                    break;
                case 10:
                    Console.WriteLine("Super Earthquake");
                    break;
                */

            /*
            int temperature = 38;
            int amountSnow = 5;

            if ( temperature < 40 && amountSnow > 1) // || has to be either OR cant be both (+) , && runs when both hae to be true (*)
            {
                Console.WriteLine("Build a snowman!");
            }
            */

            // ********* THIS WEEK'S LESSON ***********************************

            // ********Non-static method call*************


            //SimpleMath mathObject = new SimpleMath();

            //int sum = mathObject.Add(100, 100);
            //Console.WriteLine(sum);

            //Console.WriteLine(mathObject.Subtract(sum, 50));

            //Console.WriteLine(SimpleMath.Divide(100, 20));

            // 11/20/19 ************* Wednesday ******************

            Course course1 = new Course("IT 1050");
            //course1.courseNumber = "IT 1050";
            course1.title = "Programming Logic";
            course1.maxEnrollment = 23;
            course1.Display();
            
            for(int i = 0; i < 28; i++)
            {
                course1.addStudent();
            }
            course1.Display();

        }

    }

    //class SimpleMath // class, SimpleMath is a type we defined 
    //{
    //    // public, non-static, returns an int, accepts two parameters 

    //    public int Add(int a, int b) // method, method name is Add, two parameters, public is the 
    //    {
    //        int sum;
    //        sum = a + b;
    //        return sum;
    //    }

    //    // public, non-static, returns an int, accepts two parameters 

    //    public int Subtract(int a, int b)
    //    {
    //        return a - b;
    //    }

    //    // public, static, returns an int, accepts two parameters 
    //    public static int Divide(int a, int b)
    //    {
    //        return a / b;
    //    }

    // **** 11/20/19 Wednesday *********
    class Course
    {
        public string courseNumber;
        public string title;
        public int maxEnrollment;
        private int currentEnrollment;
        private string room;

        // constructor method (we don't/never have a return type)
        // Remember contructor methods: (1) no return type (2) same name as class
        public Course(string courseNumber)
        {
            this.courseNumber = courseNumber;
        }

        // add 1 to currentEnrollment
        public void addStudent()
        { 
            if (currentEnrollment < this.maxEnrollment)
            {
               currentEnrollment++;
            }
            else
            {
                Console.WriteLine("Can't add, over the Max Enrollment");
            }
        }

        public int RemainingSeats()
        {
            return maxEnrollment - currentEnrollment;
        }

        // all normal methods ave return type except constructor methods
        public void Display()
        {
            Console.WriteLine($"\nCourse: {courseNumber}\nTitle: {title}\nCurrent Enrollment: {currentEnrollment}\nMax Enrollment: {maxEnrollment}\n");
            Console.WriteLine($"Remaining Seats: {RemainingSeats()}\n");
        }

        public void RoomNumber(string room)
        {
            if (this.courseNumber.Substring(0,2) == "IT" )
            {
                if (room == "D204" || room == "D205")
                {
                    this.room = room;
                }
                else
                {
                    Console.WriteLine("RoomNumber() failed: IT classes can only be in room D204 & D205");
                }
            }
            else
            {
                this.room = room; 
            } // Haven't displayed this yet. Prof. will upload to BB 

            // ** Three ways to return ** 
            //empty return statement with a semi colon (no value)
            //no return Method (end with a semi colon)
            //return followed by a value but it has to match the value defined 

        }
    }
}
