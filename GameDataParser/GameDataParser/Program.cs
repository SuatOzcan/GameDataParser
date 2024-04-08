using System.Text.Json;

namespace GameDataParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            { 
                string fileName = UserInteraction.ReceiveUserInput();
                JsonRepository jsonRepository = new JsonRepository(fileName);
                List<VideoGame> videoGames = jsonRepository.ReadFile();
                UserInteraction.PrintGames(videoGames);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}