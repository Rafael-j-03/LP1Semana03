using System;

namespace PlayerAchievements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Achievements playerAchievements = 0;
            
            // Ask the user the number of players and turn it into a int
            Console.Write("Enter the number of players: ");
            string numberOfPlayersQ = Console.ReadLine();
            int n = Convert.ToInt32(numberOfPlayersQ);
                        
            // Create array for achievements
            int [] achievements = new int [n];

            // Ask the user the number of achievements for each player
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the number of achievements for player {i + 1}: ");
                string givenAchievements = Console.ReadLine();
                int nGivenAchievements = Convert.ToInt32(givenAchievements);
            }
        }
    }
}
