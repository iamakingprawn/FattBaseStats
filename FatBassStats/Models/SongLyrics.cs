using com.FatBassStats.Interface.Lyrics.Models;

namespace com.FatBassStats.Models
{
    /// <summary>
    /// Model for returned lyrics data from the LyricsApi
    /// </summary>
    public class SongLyrics : ISongLyrics
    {
        public string Lyrics { get; set; }

        // Needed for Json Deserialize
        public SongLyrics(){}
    }
}
