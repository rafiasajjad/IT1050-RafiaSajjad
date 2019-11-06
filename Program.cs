using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 2
            int FirstNumber;
            int SecondNumber;
            int Product;

            Console.Write( "Enter First Integer: " );
            FirstNumber = Convert.ToInt32( Console.ReadLine() );

            Console.Write( "Enter Second Integer: " );
            SecondNumber = Convert.ToInt32( Console.ReadLine() );

            Product = FirstNumber * SecondNumber;

            Console.WriteLine( "Product is {0}" , Product );

            // Part 3 
            Console.WriteLine( "{0}\n{1}" , "Hello World!" , "From Rafia");

            //Part 4
            Console.WriteLine("{0}\t{1}", "Hello World!", "From Rafia");

            //Part 5
            /*
             (a) The Main method is where the C# console application begins 
                 execution. It is known as the entry point.

             (b) An integer type variable holds integer values (whole numbers suchas -12, 4)
                 where the range of values is from -2,147,483,648 to +2,147,483,647.

                 The type double / floating point variables specify real numbers 
                 (number that may contain decimal points such as 4.3, -34.79). Types float and double 
                 store approximations of real numbers. 

             (c) An example of a method from chapter 4 is Deposit. It enables the client code
                 to deposit money into an Account which would increase its balance. 
                 A method is able to perform a task and return a value when it completes its task.
                 Here, the method Deposit does not return any information because of the return type void. 
                 
                 public void Deposit(decimal depositAmount)
                 {
                     if (depositAmount > 0.0m)
                     {
                         Balance = Balance + depositAmount; 
                     }
                 }
             (d) To read the value of an instance variable, 
                 we create method called a get accessor. 
                 To assign avalue to an instance variable, 
                 we use a method called a set accessor. 
                 
             (e) A class is a template for objects. A class defines object properties including a valid 
                 range of values, and a default value. A class also describes object behavior. 

                 An object is a member or an "instance" of a class. An object has a state in 
                 which all of its properties have values that you either explicitly define or 
                 that are defined by default settings.

                 A class defines a type of object, but it is not an object itself. 
                 An object is a concrete entity based on a class, and is sometimes referred to as
                 an instance of a class. Objects can be created by using the new keyword followed by the 
                 name of the class that the object will be based on. 

                 We can create as many instances of a class but each one has a different reference. 
                 test obj1 = new test();  
                 test obj2 = new test();  
                 test obj3 = new test();  
                 test obj4 = new test();  
                 Where test is the class, obj1-obj3 are refernces and new test() are the four objects created. 

            */
        }
    }
}
