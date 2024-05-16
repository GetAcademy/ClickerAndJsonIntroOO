namespace ClickerAndJsonIntroOO
{
    internal class Clicker
    {
        int _points = 0;
        int _upgrades = 1;

        public void Click()
        {
            _points += _upgrades;
        }

        public void BuyUpgrade()
        {
            if (_points >= 10)
            {
                _upgrades++;
                _points -= 10;
            }
        }

        public void Show()
        {
            Console.WriteLine($"Klikker A: Du har {_points} poeng. (a=klikk, A=upgrade)");
        }
    }
}
