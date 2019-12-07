using System;

namespace Lab_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Display();
            BookTest book2 = new BookTest("Visual C#: How to Program", "Harvey Deitel, Paul Deitel", "2019");
            book2.Display2();
        }
    }
    
    class Book
    {
        public string title = "Visual C#: How to Program" ;
        public string author = "Harvey Deitel, Paul Deitel";
        public string year = "2019";

        public void Display()
        {
            Console.WriteLine($"Course: {title}\nAuthor: {author}\nYear: {year}");
            Console.WriteLine(); 
        }
    }
    
    class BookTest
    {
        public string title;
        public string author;
        public string year;
        public BookTest(string title, string author, string year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }

        public void Display2()
        {
            Console.WriteLine($"{this.title}");  
            Console.WriteLine($"{this.author}");
            Console.WriteLine($"{this.year}");
        }
    }
}
