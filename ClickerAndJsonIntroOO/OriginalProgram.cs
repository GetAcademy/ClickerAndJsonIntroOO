﻿namespace ClickerAndJsonIntroOO
{
    internal class OriginalProgram
    {
        static void Mainx(string[] args)
        {
            var points = 0;
            var upgrades = 1;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Klikker A: Du har {points} poeng. (a=klikk, A=upgrade)");

                var cmdKey = Console.ReadKey(true);
                if (cmdKey.KeyChar == 'a')
                {
                    points += upgrades;
                }
                else if (cmdKey.KeyChar == 'A')
                {
                    if (points >= 10)
                    {
                        upgrades++;
                        points -= 10;
                    }
                }
            }
        }
    }
}
