namespace ClickerAndJsonIntroOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var clicker = new Clicker();
            while (true)
            {
                Console.Clear();
                clicker.Show();

                var cmdKey = Console.ReadKey(true);
                if (cmdKey.KeyChar == 'a')
                {
                    clicker.Click();
                }
                else if (cmdKey.KeyChar == 'A')
                {
                    clicker.BuyUpgrade();
                }
            }
        }

    }
}