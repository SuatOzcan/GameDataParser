using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GameDataParser
{
    internal class JsonRepository
    {
        public string FileName { get; set; }
        public JsonRepository(string fileName)
        {
            FileName = fileName;
        }
        public List<VideoGame> ReadFile()
        {
            string fileContents = File.ReadAllText(FileName);
            List<VideoGame> videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
            if (videoGames.Count > 0) 
            { 
            return videoGames;
            }
            return null;
        }
    }
}
