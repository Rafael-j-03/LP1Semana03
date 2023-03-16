using System;

namespace PlayerPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks myPerks = 0;

            // Check every character on the first argument gave
            foreach (char c in args[0])
            {
                // Add a perk depending on the user's input
                if (c == 'w')
                {
                    myPerks ^= Perks.WaterBreathing;
                }
                if (c == 'a')
                {
                    myPerks ^= Perks.AutoHeal;
                }
                if (c == 's')
                {
                    myPerks ^= Perks.Stealth;
                }
                if (c == 'd')
                {
                    myPerks ^= Perks.DoubleJump;
                }
            }

            Console.WriteLine(myPerks);
        }
    }
}
