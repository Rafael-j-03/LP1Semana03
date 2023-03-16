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
            if (myPerks == 0)
            {
                Console.WriteLine("No perks at all!");
            }
            if (!invalidPerk)
            {
                if (myPerks != 0)
                {
                    Console.WriteLine(myPerks);
                }
                // If the player have the Stealth and the Double jump perks
                if ((myPerks & (Perks.Stealth | Perks.DoubleJump)) == (Perks.Stealth | Perks.DoubleJump))
                {
                    Console.WriteLine("Silent jumper!");
                }
                // If the player does not have the perk "AutoHeal"
                if ((myPerks & Perks.AutoHeal) != (Perks.AutoHeal))
                {
                    Console.WriteLine("Not gonna make it!");
                }
            }
        }
    }
}
