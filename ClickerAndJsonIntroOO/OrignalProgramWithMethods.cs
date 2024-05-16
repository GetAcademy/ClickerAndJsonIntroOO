using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerAndJsonIntroOO
{
    internal class OrignalProgramWithMethods
    {
        static int _points = 0;
        static int _upgrades = 1;

        static void Mainx(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Klikker A: Du har {_points} poeng. (a=klikk, A=upgrade)");

                var cmdKey = Console.ReadKey(true);
                if (cmdKey.KeyChar == 'a')
                {
                    Click();
                }
                else if (cmdKey.KeyChar == 'A')
                {
                    BuyUpgrade();
                }
            }
        }

        static void Click()
        {
            _points += _upgrades;
        }

        static void BuyUpgrade()
        {
            if (_points >= 10)
            {
                _upgrades++;
                _points -= 10;
            }
        }
    }
}
