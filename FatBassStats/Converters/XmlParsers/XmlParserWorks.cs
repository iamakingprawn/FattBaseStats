using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using com.FatBassStats.Interface.Models;
using com.FatBassStats.Interface.Parsers;
using com.FatBassStats.Models;

namespace com.FatBassStats.Converters.XmlParsers
{
    public class XmlParserWorks : IXmlMusicBrainzParser<IWork>
    {
        /// <summary>
        /// The value of the Type attribute that identifies a song from the work XML
        /// </summary>
        private const string TypeAttributeValue = "song";

        /// <summary>
        /// Converts the supplied XML into Artists
        /// </summary>
        /// <param name="xmlData">The XML containing the recordings data</param>
        /// <returns>List of IWork</returns>
        public IList<IWork> GetParsedData(string xmlData)
        {
            var xmlDocSongs = XDocument.Parse(xmlData);
            var xnWork = XName.Get("work", @"http://musicbrainz.org/ns/mmd-2.0#");
            var xnWorkTitle = XName.Get("title", @"http://musicbrainz.org/ns/mmd-2.0#");

            var xmlElements = xmlDocSongs.Descendants(xnWork);

            return (from work in xmlElements
                    where TypeAttributeValue.Equals(work.Attribute("type")?.Value, StringComparison.CurrentCultureIgnoreCase)
                    let id = work.Attribute("id")?.Value
                    let title = work.Element(xnWorkTitle)?.Value
                    select new Work(id, title)).Cast<IWork>().ToList();

        }
    }
}
