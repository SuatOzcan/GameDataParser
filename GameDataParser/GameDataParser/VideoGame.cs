using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GameDataParser
{
    internal class VideoGame
    {
            public string Title { get; init; }
            public int ReleaseYear { get; init; }
            public double Rating { get; init; }

        public override string ToString()
        {
            return $"{Title} is released in {ReleaseYear} and has a rating of {Rating}";
        }
    }
}
