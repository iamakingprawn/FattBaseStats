using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using com.FatBassStats.Extensions;
using com.FatBassStats.Interface.Models;
using com.FatBassStats.Interface.MusicBrainz;
using com.FatBassStats.Interface.Parsers;

namespace com.FatBassStats.Services.MusicBrainz
{
    internal class MusicBrainzApi : IMusicBrainzApi
    {
        private readonly HttpClient _httpClient = new HttpClient();
        //TODO: Hardcoded baseurl
        private const string BaseUrl = "https://musicbrainz.org/ws/2";
        //TODO: Hardcoded useragent
        private const string UserAgentString = "FatBassStats/1.0.0";

        private readonly IXmlMusicBrainzParser<IArtist> _xmlArtistParser;
        private readonly IXmlMusicBrainzParser<IWork> _xmlWorkParser;
        
        public MusicBrainzApi(IXmlMusicBrainzParser<IArtist> xmlArtistParser, IXmlMusicBrainzParser<IWork> xmlWorkParser)
        {
            // Set the parsers
            _xmlArtistParser = xmlArtistParser;
            _xmlWorkParser = xmlWorkParser;

            //TODO: inject one or a wrapper
            //Setup the HttpClient
            //_httpClient.BaseAddress = new Uri(BaseUrl);
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", UserAgentString);
        }
        
        public async Task<IList<IArtist>> GetArtists(string artistName) =>
            //TODO: Magic number
            await GetArtists(artistName, -1);

        public async Task<IList<IArtist>> GetArtists(string artistName, int limit)
        {
            string artistResponseXml;

            var httpResponse = await _httpClient.GetAsync($"{BaseUrl}/artist?query={artistName.UriEscapeDataString()}&limit{limit}");

            if (httpResponse.IsSuccessStatusCode) artistResponseXml = await httpResponse.Content.ReadAsStringAsync();
            else throw new Exception("MusicBrinz artist invalid response");

            return _xmlArtistParser.GetParsedData(artistResponseXml);
        }

        public async Task<IList<IWork>> GetWorks(string artistId) =>
            //TODO: Magic number
            await GetWorks(artistId, -1);

        public async Task<IList<IWork>> GetWorks(string artistId, int limit)
        {
            var query = $"{BaseUrl}/work?query=arid:{artistId}{( limit == -1 ? "" : $"&limit={limit}")}";

            string worksResponseXml;

            var httpResponse = await _httpClient.GetAsync(query);

            if (httpResponse.IsSuccessStatusCode) worksResponseXml = await httpResponse.Content.ReadAsStringAsync();
            else throw new Exception("MusicBrinz works invalid response");

            return _xmlWorkParser.GetParsedData(worksResponseXml);
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}
