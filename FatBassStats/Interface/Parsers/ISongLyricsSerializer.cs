using com.FatBassStats.Interface.Lyrics.Models;

namespace com.FatBassStats.Interface.Parsers
{
    /// <summary>
    /// Converts Json song data to the ISongLyrics model
    /// </summary>
    public interface ISongLyricsSerializer
    {
        ISongLyrics DeSerialize(string lyrics);
    }
}