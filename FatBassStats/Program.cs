using System;
using System.Text;
using com.FatBassStats.Apis.Lyrics;
using com.FatBassStats.Converters.JsonSerializers;
using com.FatBassStats.Converters.XmlParsers;
using com.FatBassStats.Services;
using com.FatBassStats.Services.MusicBrainz;


namespace com.FatBassStats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("Invalid argument(s).  For help: /?");
                    return;
                }

                //TODO: Expand the Argument set to make use of multiple matches using ns2:score to show the best matches.
                switch (args[0])
                {
                    case "/?":
                        Console.WriteLine(" ");
                        Console.WriteLine("Returns the mean words in a artists songs.");
                        Console.WriteLine(" ");
                        Console.WriteLine("Commands accepted:");
                        Console.WriteLine(" ");
                        Console.WriteLine("/artistname      /artistname paolo nutini");
                        //TODO: These need to be plumbed in when needed
                        //Console.WriteLine("/showall         Shows all found artists so that you can pick and supply the returned id");
                        //Console.WriteLine("/artistid        /artistid The artists id from MusicBrainz if known, or from the users of /showall");
                        return;
                    case "/artistname":
                        var artistname = GetCommandValue(args, "artistname");
                        if (artistname == null) throw new ArgumentNullException("artistname not supplied.");

                        int meanWords;
                        using (var api = new MusicStatsService(new MusicBrainzApi(new XmlParserArtist(), new XmlParserWorks()), new LyricsApi(new SongLyricsSerializer()), new ConsoleLogger()))
                            meanWords = api.GetMeanWordsInSongs(artistname).Result;
                        Console.WriteLine($"---------------------------------------------");
                        Console.WriteLine($"Mean words in {artistname} songs: {meanWords}");
                        Console.WriteLine($"---------------------------------------------");
                        return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"error: {e.Message}");
            }

            Console.WriteLine("Press any key to end.");
            Console.Read();
        }

        /// <summary>
        /// Gets the command value if it exists
        /// </summary>
        /// <param name="args">The supplied arguments</param>
        /// <param name="commandName">The name of the command</param>
        /// <returns></returns>
        private static string GetCommandValue(string[] args, string commandName)
        {
            if (args.Length == 0) return null;
            if (string.IsNullOrEmpty(commandName)) return null;

            for (var i = 0; i < args.Length; i++)
            {
                if (!commandName.Equals(args[i].Replace("/", ""), StringComparison.OrdinalIgnoreCase)) continue;
                
                if (args.Length < i + 1) throw new ArgumentException($"Invalid command value for {commandName}");

                // Loop and get the command value.  It will loop until if finds the next command "/" or the array ends
                var commandValue = new StringBuilder();
                for (var j = i+1; j < args.Length; j++)
                {
                    if (args[j].StartsWith("/")) break;
                    commandValue.Append($"{args[j]} ");
                }

                return commandValue.ToString().TrimEnd();
            }

            return null;
        }
        
    }
}
