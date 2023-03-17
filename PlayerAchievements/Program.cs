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

            // Create array for players
            int[] players = new int[n];

            // Ask every player his achievements and show it
            for (int i = 0; i < players.Length; i++)
            {
                Achievements playerAchievements = 0;
                int achievements = 0;

                for (int j = 0; j < 3; j++)
                {
                    achievements++;

                    if (achievements == 1)
                    {
                        Console.Write($"Does the player {i + 1} have the achievement DefeatOptionalBoss?" +
                        " (Yes or No)? ");
                        string DefeatOptionalBossQ = Console.ReadLine();

                        if (DefeatOptionalBossQ == "Yes")
                        {
                            playerAchievements ^= Achievements.DefeatOptionalBoss;
                        }
                    }
                    if (achievements == 2)
                    {
                        Console.Write($"Does the player {i + 1} have the achievement FindHiddenLevel?" +
                        " (Yes or No)? ");
                        string FindHiddenLevelQ = Console.ReadLine();

                        if (FindHiddenLevelQ == "Yes")
                        {
                            playerAchievements ^= Achievements.FindHiddenLevel;
                        }
                    }
                    if (achievements == 3)
                    {
                        Console.Write($"Does the player {i + 1} have the achievement FinishGame?" +
                        " (Yes or No)? ");
                        string FinishGameQ = Console.ReadLine();

                        if (FinishGameQ == "Yes")
                        {
                            playerAchievements ^= Achievements.FinishGame;
                        }
                    }
                }

                // Create empty line
                Console.WriteLine("");
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
                // Create empty line
                Console.WriteLine("");
            }
        }
    }
}
