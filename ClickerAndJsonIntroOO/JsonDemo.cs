using System.Text.Json;

namespace ClickerAndJsonIntroOO
{
    internal class JsonDemo
    {
        public static void Run()
        {
            var json = File.ReadAllText("youtube.json");
            var youtubeInfo = JsonSerializer.Deserialize<YoutubeInfo>(json);
            Console.WriteLine(youtubeInfo.items.Length);
        }
    }
}
