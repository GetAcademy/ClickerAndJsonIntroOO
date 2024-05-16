using System.Text.Json;

namespace ClickerAndJsonIntroOO
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonDemo.Run();
            return;
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
                if (cmdKey.Key == ConsoleKey.L)
                {
                    clickers = Load();
                }
                else if (cmdKey.Key == ConsoleKey.S)
                {
                    Save(clickers);
                }
                foreach (var clicker in clickers)
                {
                    clicker.HandleLetter(cmdKey.KeyChar);
                }
            }
        }

        private static Clicker[] Load()
        {
            var json = File.ReadAllText("game.json");
            var confusingOptions = new JsonSerializerOptions { IncludeFields = true };
            return JsonSerializer.Deserialize<Clicker[]>(json, confusingOptions );
        }

        private static void Save(Clicker[] clickers)
        {
            var confusingOptions = new JsonSerializerOptions { IncludeFields = true,  };
            var json = JsonSerializer.Serialize(clickers, confusingOptions);
            File.WriteAllText("game.json", json);
        }
    }
}