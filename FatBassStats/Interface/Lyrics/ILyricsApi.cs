using System;
using System.Threading.Tasks;
using com.FatBassStats.Interface.Lyrics.Models;

namespace com.FatBassStats.Interface.Lyrics
{
    public interface ILyricsApi : IDisposable
    {

        /// <summary>
        /// Get the Lyrics for the supplied song name
        /// </summary>
        /// <param name="artistName">The name of the artist of the song</param>
        /// <param name="songName">The song name</param>
        /// <returns>The lyrics of the song</returns>
        Task<ISongLyrics> GetLyrics(string artistName, string songName);
    }
}