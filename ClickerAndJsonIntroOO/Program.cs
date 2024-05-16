namespace ClickerAndJsonIntroOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var clickers = new Clicker[]
            {
                new Clicker('a'),
                new Clicker('b'),
                new Clicker('c'),
                new Clicker('d'),
            };
            while (true)
            {
                Console.Clear();
                foreach (var clicker in clickers)
                {
                    clicker.Show();
                }

                var cmdKey = Console.ReadKey(true);
                foreach (var clicker in clickers)
                {
                    clicker.HandleLetter(cmdKey.KeyChar);
                }
            }
        }

    }
}