using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello markus");
            /* 1. The program ask the user name
             * 2. The user enters their name
             * 3. The program greets the user by their name*/
            Console.WriteLine("What's your name?");
            String Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello, " + Name);
        }
    }
}
