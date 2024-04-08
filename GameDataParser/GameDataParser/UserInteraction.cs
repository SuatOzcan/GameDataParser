using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser
{
    internal static class UserInteraction
    {

        public static string ReceiveUserInput()
        {
            Console.WriteLine("Please enter the file name you want to read:");
            string fileName = Console.ReadLine();
            return fileName;
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
