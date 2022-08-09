using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using com.FatBassStats.Interface.Models;
using com.FatBassStats.Interface.MusicBrainz;
using com.FatBassStats.Interface.Parsers;

namespace com.FatBassStatsTests.Mocks
{
    /// <summary>
    /// Mock Service for tests
    /// </summary>
    internal class StubMusicBrainzApi : IMusicBrainzApi
    {
        private readonly XmlDocument _xmlArtistsDoc = new XmlDocument();
        private readonly XmlDocument _xmlWorksDoc = new XmlDocument();
        private readonly IXmlMusicBrainzParser<IArtist> _xmlArtistParser;
        private readonly IXmlMusicBrainzParser<IWork> _xmlWorkParser;

        public StubMusicBrainzApi(IXmlMusicBrainzParser<IArtist> xmlArtistParser, IXmlMusicBrainzParser<IWork> xmlWorkParser)
        {
            _xmlArtistsDoc.Load("Data/Artists.xml");
            _xmlWorksDoc.Load("Data/ArtistWork.xml");

            _xmlArtistParser = xmlArtistParser;
            _xmlWorkParser = xmlWorkParser;
        }
        
        public Task<IList<IArtist>> GetArtists(string artistName) => Task.Run(() => _xmlArtistParser.GetParsedData(_xmlArtistsDoc.InnerXml));

        public Task<IList<IArtist>> GetArtists(string artistName, int limit)
        {
            return Task.Run(() =>
            {
                IList<IArtist> retData = new List<IArtist>();
                var parsedData = _xmlArtistParser.GetParsedData(_xmlArtistsDoc.InnerXml);
                foreach (var artist in parsedData.Take(limit)) retData.Add(artist);
                return retData;
            });
        }

        public Task<IList<IWork>> GetWorks(string artistId) => Task.Run(() => _xmlWorkParser.GetParsedData(_xmlWorksDoc.InnerXml));

        public Task<IList<IWork>> GetWorks(string artistId, int limit)
        {
            return Task.Run(() =>
            {
                IList<IWork> retData = new List<IWork>();
                var parsedData = _xmlWorkParser.GetParsedData(_xmlWorksDoc.InnerXml);
                foreach (var work in parsedData.Take(limit)) retData.Add(work);
                return retData;
            });
        }

        public void Dispose()
        {
            //Nothing to do at the moment
        }
    }
}
