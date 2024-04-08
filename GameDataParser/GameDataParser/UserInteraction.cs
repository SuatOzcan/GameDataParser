using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser
{
    internal static class UserInteraction
    {
        static Logger logger = new Logger("logger.txt");
        public static string ReceiveUserInput()
        {
            bool isFileRead = false;
            do
            {
                try
                {
                    Console.WriteLine("Please enter the file name you want to read:");
                    string fileName = Console.ReadLine();
                    if (fileName != null && fileName !="")
                    {
                        isFileRead = true;
                        return fileName;
                    }
                    else
                    {
                        Console.WriteLine("Argument cannot be blank.");
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("The file name cannot be null.");
                    logger.Log(ex);
                }
            } while (!isFileRead);
            return null;
        }

        public static void PrintGames(List<VideoGame> videoGames)
        {
            if (videoGames.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Loaded games are:");
                foreach (VideoGame videoGame in videoGames)
                {
                    Console.WriteLine(videoGame);
                }
            }
            else
            {
                Console.WriteLine("No games are present in the input file.");
            }
        }
    }
}
