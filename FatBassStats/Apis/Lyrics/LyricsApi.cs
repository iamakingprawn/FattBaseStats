using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using com.FatBassStats.Interface.Lyrics;
using com.FatBassStats.Interface.Lyrics.Models;
using com.FatBassStats.Interface.Parsers;

namespace com.FatBassStats.Apis.Lyrics
{
    internal class LyricsApi : ILyricsApi, IDisposable
    {
        private readonly ISongLyricsSerializer _lyricsSerializer;

        private readonly HttpClient _httpClient = new HttpClient();
        //TODO: Hardcoded baseurl
        private const string BaseUrl = "https://api.lyrics.ovh/v1";
        //TODO: Hardcoded useragent
        private const string UserAgentString = "FatBassStats/1.0.0";
        
        public LyricsApi(ISongLyricsSerializer lyricsSerializer)
        {
            _lyricsSerializer = lyricsSerializer;

            //TODO: Inject one or a wrapper
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", UserAgentString);
        }

        public async Task<ISongLyrics> GetLyrics(string artistName, string songName)
        {
            string returnedLyrics;

            var httpResponse =
                await _httpClient.GetAsync($"{BaseUrl}/{Uri.EscapeDataString(artistName)}/{Uri.EscapeDataString(songName)}");

            if (httpResponse.IsSuccessStatusCode) returnedLyrics = await httpResponse.Content.ReadAsStringAsync();
            else throw new Exception("Lyrics Api Invalid response");

            return _lyricsSerializer.DeSerialize(returnedLyrics);
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}
