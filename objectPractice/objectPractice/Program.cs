using System;

namespace objectPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // This calls the object to make a new instance of it with the name newClass.
            fibanacciEngine newClass = new fibanacciEngine();

            // This sets the newClass instance's 'Base' property to 3.
            newClass.Base = 3;

            // This calls the 'AddWith' functionality with the int 4 and
            // sets the new int 'found' to the returned value.
            int found = newClass.AddWith(4);

            // Prints result.
            Console.WriteLine(found);


            // This will now be repeated to show that it works for two instances.
            fibanacciEngine secondClass = new fibanacciEngine();

            secondClass.Base = 1;

            int second = secondClass.AddWith(2);

            Console.WriteLine(second);
        }
    }
}
