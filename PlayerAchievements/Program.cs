using System;

namespace PlayerAchievements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user the number of players and turn it into a int
            Console.Write("Enter the number of players: ");
            string numberOfPlayersQ = Console.ReadLine();
            int n = Convert.ToInt32(numberOfPlayersQ);
        }
    }
}
