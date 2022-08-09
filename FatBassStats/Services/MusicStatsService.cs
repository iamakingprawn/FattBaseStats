using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.FatBassStats.Extensions;
using com.FatBassStats.Interface;
using com.FatBassStats.Interface.Lyrics;
using com.FatBassStats.Interface.Models;
using com.FatBassStats.Interface.MusicBrainz;

namespace com.FatBassStats.Services
{
    /// <summary>
    /// Service for getting all data form the two APIs in order to calculate the mean 
    /// </summary>
    public class MusicStatsService : IDisposable
    {
        private readonly IMusicBrainzApi _mBrainzApi;
        private readonly ILyricsApi _lyricsApi;
        private readonly ILogger _logger = null;

        /// <summary>
        /// Basic constructor with no logging
        /// </summary>
        /// <param name="mBrainzApi">The MusicBrainzApi service to user</param>
        /// <param name="lyricsApi">The LyricsApi service to user</param>
        public MusicStatsService(IMusicBrainzApi mBrainzApi, ILyricsApi lyricsApi)
        {
            _mBrainzApi = mBrainzApi;
            _lyricsApi = lyricsApi;
        }

        /// <summary>
        /// Constructor with ability to log 
        /// </summary>
        /// <param name="mBrainzApi">The MusicBrainzApi service to user</param>
        /// <param name="lyricsApi">The LyricsApi service to user</param>
        /// <param name="logger">The logger to user</param>
        public MusicStatsService(IMusicBrainzApi mBrainzApi, ILyricsApi lyricsApi, ILogger logger) : this(mBrainzApi, lyricsApi) => _logger = logger;


        /// <summary>
        /// Query the API for a limited list of artists using the supplied artistName and limit
        /// </summary>
        /// <param name="artistName">The name of the artist to lookup</param>
        /// <returns>List IArtist containing the found artists for the query</returns>
        public IArtist GetArtist(string artistName) => GetArtists(artistName, 1).Result.FirstOrDefault();

        /// <summary>
        /// Query the API for a limited list of artists using the supplied artistName and limit
        /// </summary>
        /// <param name="artistName">The name of the artist to lookup</param>
        /// <returns>List IArtist containing the found artists for the query</returns>
        public Task<IList<IArtist>> GetArtists(string artistName) => _mBrainzApi.GetArtists(artistName);

        /// <summary>
        /// Query the API for a limited list of artists using the supplied artistName and limit
        /// </summary>
        /// <param name="artistName">The name of the artist to lookup</param>
        /// <param name="limit">Return data limit</param>
        /// <returns>List IArtist containing the found artists for the query</returns>
        public Task<IList<IArtist>> GetArtists(string artistName, int limit) => _mBrainzApi.GetArtists(artistName, limit);

        /// <summary>
        /// Query the API for a list of works by the artist using the supplied artistId
        /// </summary>
        /// <param name="artistId">The Id of the artist to lookup songs for</param>
        /// <returns>List IWork containing the found songs for the artist</returns>
        public Task<IList<IWork>> GetWorks(string artistId) => _mBrainzApi.GetWorks(artistId);

        /// <summary>
        /// Query the API for a limited list of works by the artist using the supplied artistId and limit
        /// </summary>
        /// <param name="artistId">The Id of the artist to lookup songs for</param>
        /// <param name="limit">Return data limit</param>
        /// <returns>List IWork containing the found songs for the artist</returns>
        public Task<IList<IWork>> GetWorks(string artistId, int limit) => _mBrainzApi.GetWorks(artistId, limit);

        /// <summary>
        /// Takes the artist name and returns the mean number of words in all their songs
        /// </summary>
        /// <param name="artistName"></param>
        /// <returns></returns>
        public Task<int> GetMeanWordsInSongs(string artistName)
        {
            var artist = GetArtist(artistName);
            var works = GetWorks(artist.Id).Result.ToList();
            
            if (!works.Any()) throw new Exception("Unable to find any songs for the artist.");

            var lyricsCounts = new List<int>();

            foreach (var work in works)
            {
                // This Api is often slow or does not return data as expected so just log out any bad data so the users can see
                try
                {
                    var lyrics = _lyricsApi.GetLyrics(artist.Name, work.Title);
                    var wordCount = lyrics.Result.Lyrics.WordCount();
                    lyricsCounts.Add(wordCount);
                    _logger?.Log($"Title: {work.Title} - {wordCount} words.");
                }
                catch
                {
                    _logger?.Log($"Title: {work.Title} - Not found so will not be included in the final calculation.");
                }
            }
            
            // Not fussed by decimals so round and return as int
            return Task.FromResult(Convert.ToInt32(Math.Floor(lyricsCounts.Average())));
        }

        public void Dispose()
        {
            _mBrainzApi?.Dispose();
            _lyricsApi?.Dispose();
        }
    }
}
