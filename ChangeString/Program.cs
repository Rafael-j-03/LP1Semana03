using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a string
            Console.Write("Please enter a string: ");
            string firstQuestion = Console.ReadLine();

            // Ask the user to enter a character
            Console.Write("Please enter a character: ");
            string secondQuestion = Console.ReadLine();
            // Convert the input to a character
            char character = char.Parse(secondQuestion);
        }
    }
}
