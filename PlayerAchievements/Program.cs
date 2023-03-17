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

            // Create array for achievements
            int[] achievements = new int[n];

            // Ask the user the number of achievements for each player
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the number of achievements for player {i + 1}: ");
                string givenAchievements = Console.ReadLine();
                int nGivenAchievements = Convert.ToInt32(givenAchievements);
                achievements[i] = nGivenAchievements;
            }

            // Give every player his achievements and show it
            for (int i = 0; i < achievements.Length; i++)
            {
                Achievements playerAchievements = 0;
                int nPerks = 0;

                for (int j = 0; j < achievements[i]; j++)
                {
                    nPerks++;

                    if (nPerks == 1)
                    {
                        playerAchievements ^= Achievements.DefeatOptionalBoss;
                    }
                    if (nPerks == 2)
                    {
                        playerAchievements ^= Achievements.FindHiddenLevel;
                    }
                    if (nPerks == 3)
                    {
                        playerAchievements ^= Achievements.FinishGame;
                    }
                }

                // Check if the player have any achievements
                if (playerAchievements != 0)
                {
                    Console.WriteLine($"Player {i + 1} have:");
                    Console.WriteLine(playerAchievements);

                    // If the player have all the achievements
                    if ((playerAchievements &
                    (Achievements.DefeatOptionalBoss |
                    Achievements.FindHiddenLevel |
                    Achievements.FinishGame))
                    ==
                    (Achievements.DefeatOptionalBoss |
                    Achievements.FindHiddenLevel |
                    Achievements.FinishGame))
                    {
                        Console.WriteLine("Completionist!");
                    }
                }
                else
                {
                    Console.WriteLine($"Player {i + 1} have no achievements!");
                }
            }
        }
    }
}
