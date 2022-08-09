using System.Text.Json;
using com.FatBassStats.Interface.Lyrics.Models;
using com.FatBassStats.Interface.Parsers;
using com.FatBassStats.Models;

namespace com.FatBassStats.Converters.JsonSerializers
{
    /// <summary>
    /// Lyrics data serializer
    /// </summary>
    public class SongLyricsSerializer : ISongLyricsSerializer
    {
        public ISongLyrics DeSerialize(string lyrics) => JsonSerializer.Deserialize<SongLyrics>(lyrics,
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
    }
}