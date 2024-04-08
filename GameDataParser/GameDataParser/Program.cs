using System.Text.Json;

namespace GameDataParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the file name you want to read:");
            string fileName = Console.ReadLine();

            string fileContents = File.ReadAllText(fileName);

            List<VideoGame> videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContents);

            if(videoGames.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Loaded games are:");
                foreach(VideoGame videoGame in videoGames)
                {
                    Console.WriteLine(videoGame);
                }
            }
            else
            {
                Console.WriteLine("No games are presnet in the input file.");
            }
        }
    }
}