namespace ClickerAndJsonIntroOO
{
    internal class Clicker
    {
        public int _points;
        public int _upgrades;
        public char _letter;

        public Clicker()
        {
        }

        public Clicker(char letter)
        {
            _points = 0;
            _upgrades = 1;
            _letter = letter;
        }

        public void HandleLetter(char letter)
        {
            if (letter == _letter)
            {
                Click();
            }
            else if (letter == char.ToUpper(_letter))
            {
                BuyUpgrade();
            }
        }

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
            var upperLetter = char.ToUpper(_letter);
            var text = $"Klikker {upperLetter}: Du har {_points} poeng. ({_letter}=klikk, {upperLetter}=upgrade)";
            Console.WriteLine(text);
        }
    }
}
