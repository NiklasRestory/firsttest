using System;

namespace IAmPlacingThisInGit
{
    class Program
    {
        static int randomNumber = 8;

        static void Main(string[] args)
        {
            Console.WriteLine("Random Number: " + RandomNumber());
            Console.WriteLine("This is a chaaaange.");
        }

        static int RandomNumber()
        {
            return randomNumber;
        }
    }
}
