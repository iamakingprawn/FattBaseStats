using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using com.FatBassStats.Interface.Models;
using com.FatBassStats.Interface.Parsers;
using com.FatBassStats.Models;

namespace com.FatBassStats.Converters.XmlParsers
{
    public class XmlParserArtist : IXmlMusicBrainzParser<IArtist>
    {
        /// <summary>
        /// Converts the supplied XML into Artists
        /// </summary>
        /// <param name="xmlData">The XML containing the artist data</param>
        /// <returns></returns>
        public IList<IArtist> GetParsedData(string xmlData)
        {
            var xmlDocArtists = XDocument.Parse(xmlData);
            var xnArtist = XName.Get("artist", @"http://musicbrainz.org/ns/mmd-2.0#");
            var xnArtistName = XName.Get("name", @"http://musicbrainz.org/ns/mmd-2.0#");
            var xnArtistScore = XName.Get("score", @"http://musicbrainz.org/ns/ext#-2.0");

            var xmlElements = xmlDocArtists.Descendants(xnArtist);

            return (from artist in xmlElements
                    let id = artist.Attribute("id")?.Value
                    let name = artist.Element(xnArtistName)?.Value
                    let score = artist.Attribute(xnArtistScore)?.Value
                    select new Artist(id, name, score)).Cast<IArtist>().ToList();
        }
    }
}
