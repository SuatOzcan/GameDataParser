using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GameDataParser
{
    internal class JsonRepository
    {
        public string FileName { get; set; }
        Logger logger = new Logger("logger.txt");
        
        public JsonRepository(string fileName)
        {
            FileName = fileName;
        }
        public List<VideoGame> ReadFile()
        {
            string userInput;
            string fileContents;
            List<VideoGame> videoGames;

            try
            {
                fileContents = File.ReadAllText(FileName);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File does not exist.");
                Logger logger = new Logger("logger.txt");
                logger.Log(ex);
                userInput = UserInteraction.ReceiveUserInput();
                JsonRepository jsonRepository = new JsonRepository(userInput);
                videoGames = jsonRepository.ReadFile();
                return videoGames;
            }
            catch (IOException ex)
            {
                Console.WriteLine("File name must be valid.");
                logger.Log(ex);
                userInput = UserInteraction.ReceiveUserInput();
                JsonRepository jsonRepository = new JsonRepository(userInput);
                videoGames = jsonRepository.ReadFile();
                return videoGames;
            }
            try { 
            videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
            }
            catch(JsonException ex)
            {
                ConsoleColor originalForegroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine($"{ex.Message} The Json file is in invalid format. The file is : {FileName}.");
                Console.WriteLine($"The Json file is in invalid format. The file is : {FileName}.");
                logger.Log(ex);
                Console.ForegroundColor = originalForegroundColor;
                userInput = UserInteraction.ReceiveUserInput();
                JsonRepository jsonRepository = new JsonRepository(userInput);
                videoGames = jsonRepository.ReadFile();
                return videoGames;
            }
            if (videoGames.Count > 0) 
            { 
                return videoGames;
            }
            return null;
        }
    }
}
