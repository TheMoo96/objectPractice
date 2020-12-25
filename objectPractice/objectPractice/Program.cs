using System;

namespace objectPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // This calls the object to make a new instance of it with the name newClass.
            FibonacciEngine newClass = new FibonacciEngine(4);

            // This calls the 'AddWith' functionality with the int 4 and
            // sets the new int 'found' to the returned value.
            int found = newClass.FibonacchiReturn();

            // Prints result.
            Console.WriteLine(found);
        }
    }
}
