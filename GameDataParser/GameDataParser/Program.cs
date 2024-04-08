using System.Text.Json;

namespace GameDataParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger;

            try
            {
                App();
            }
            catch (Exception ex)
            {
                logger = new Logger("logger.txt");
                logger.Log(ex);
            }
        }

        private static void App()
        {
            string fileName = UserInteraction.ReceiveUserInput();
            JsonRepository jsonRepository = new JsonRepository(fileName);
            List<VideoGame> videoGames = jsonRepository.ReadFile();
            UserInteraction.PrintGames(videoGames);
        }
    }
}