using System.Collections.Generic;

namespace com.FatBassStats.Interface.Parsers
{
    public interface IXmlMusicBrainzParser<T>
    {
        public IList<T> GetParsedData(string xmlData);
    }
}