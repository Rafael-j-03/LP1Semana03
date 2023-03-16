using System;

namespace PlayerPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks myPerks = 0;
            bool invalidPerk = false;

            // Check every character on the first argument gave
            foreach (char c in args[0])
            {
                // Add a perk depending on the user's input
                if (c == 'w')
                {
                    myPerks ^= Perks.WaterBreathing;
                }
                else if (c == 'a')
                {
                    myPerks ^= Perks.AutoHeal;
                }
                else if (c == 's')
                {
                    myPerks ^= Perks.Stealth;
                }
                else if (c == 'd')
                {
                    myPerks ^= Perks.DoubleJump;
                }

                // If the perk is invalid
                else
                {
                    invalidPerk = true;
                }
            }

            // Check the player's perks
            if (invalidPerk)
            {
                Console.WriteLine("Unknown perk!");
            }
            else
            {
                Console.WriteLine(myPerks);
            }
        }
    }
}
