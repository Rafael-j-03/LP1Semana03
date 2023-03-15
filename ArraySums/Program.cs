using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter the horizontal dimension for the array
            Console.Write("Please enter the horizontal dimension of the array: ");
            string horizontalQuestion = Console.ReadLine();
            // Convert the input to a int
            int horizontalValue = int.Parse(horizontalQuestion);

            // Ask the user to enter the vertical dimension for the array
            Console.Write("Please enter the vertical dimension of the array: ");
            string verticalQuestion = Console.ReadLine();
            // Convert the input to a int
            int verticalValue = int.Parse(verticalQuestion);

            // Create the bidimensional array
            float[,] array = new float[horizontalValue, verticalValue];
        }
    }
}
