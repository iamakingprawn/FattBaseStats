using System.Xml.Serialization;
using com.FatBassStats.Interface.Models;

namespace com.FatBassStats.Models
{
    public class Artist :IArtist
    {
        public Artist()
        {

        }
        public Artist(string id, string name, string score)
        {
            Id = id;
            Name = name;
            Score = score;
        }

        [XmlAttribute("id")]
        public string Id { get; set; }
        
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("score")]
        public string Score { get; set; }
    }
}
