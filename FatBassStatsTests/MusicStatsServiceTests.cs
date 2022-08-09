using System.Diagnostics;
using System.Threading.Tasks;
using com.FatBassStats.Converters.XmlParsers;
using com.FatBassStats.Services;
using com.FatBassStatsTests.Mocks;
using NUnit.Framework;

namespace com.FatBassStatsTests
{
    /// <summary>
    /// Tests for the MusicBrainzService
    /// </summary>
    internal class MusicStatsServiceTests
    {
        private MusicStatsService _musicStatsService;

        [SetUp]
        public void Setup()
        {
            // Supply the Stubs so we can test the Music
            _musicStatsService = new MusicStatsService(new StubMusicBrainzApi(new XmlParserArtist(), new XmlParserWorks()), new StubLyricsApi());
        }

        [Test]
        public async Task GetArtists()
        {
            var artists = await _musicStatsService.GetArtists("paolo nutini");
            Assert.That(artists.Count, Is.EqualTo(25));
        }

        [Test]
        public async Task GetArtistsWithLimit()
        {
            var artists = await _musicStatsService.GetArtists("paolo nutini", 2);
            Assert.That(artists.Count, Is.EqualTo(2));
        }

        [Test]
        public async Task GetWorks()
        {
            var works = await _musicStatsService.GetWorks("24ea074c-59cc-41c5-a5de-f68c2952965f");
            foreach (var work in works)
            {
                Debug.WriteLine(work.Title);
            }
            Assert.That(works.Count, Is.EqualTo(13));
        }

        [Test]
        public async Task GetWorksWithLimit()
        {
            var works = await _musicStatsService.GetWorks("24ea074c-59cc-41c5-a5de-f68c2952965f", 3);
            Assert.That(works.Count, Is.EqualTo(3));
        }

        [Test]
        public async Task GetMeanWordsInSongs()
        {
            var meanWords = await _musicStatsService.GetMeanWordsInSongs("paolo nutini");
            Assert.That(meanWords, Is.EqualTo(230));
        }
    }
}
