using System;
using com.FatBassStats.Interface.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace com.FatBassStats.Interface.MusicBrainz
{
    /// <summary>
    /// MusicBrainz Service for interactions with API Endpoint
    /// 
    /// NOTE: Only defined call that is needed an not all available calls
    /// </summary>
    public interface IMusicBrainzApi : IDisposable
    {
        /// <summary>
        /// Query the API for a list of artists using the supplied artistName
        /// </summary>
        /// <param name="artistName">The name of the artist to lookup</param>
        /// <returns>List IArtist containing the found artists for the query</returns>
        Task<IList<IArtist>> GetArtists(string artistName);

        /// <summary>
        /// Query the API for a limited list of artists using the supplied artistName and limit
        /// </summary>
        /// <param name="artistName">The name of the artist to lookup</param>
        /// <param name="limit">Return data limit</param>
        /// <returns>List IArtist containing the found artists for the query</returns>
        Task<IList<IArtist>> GetArtists(string artistName, int limit);

        /// <summary>
        /// Query the API for the list of works byt the artistId
        /// </summary>
        /// <param name="artistId">The Id of the artist to lookup works for</param>
        /// <returns>List IWork containing the found songs for the artist</returns>
        Task<IList<IWork>> GetWorks(string artistId);

        /// <summary>
        /// Query the API for a limited list of works by the artist using the supplied artistId and limit
        /// </summary>
        /// <param name="artistId">The Id of the artist to lookup works for</param>
        /// <param name="limit">Return data limit</param>
        /// <returns>List IWork containing the found songs for the artist</returns>
        Task<IList<IWork>> GetWorks(string artistId, int limit);
    }
}
