using NUnit.Framework;
using com.FatBassStats.Extensions;

namespace com.FatBassStatsTests
{
    public class StringExtensionsTests
    {
        [Test]
        public void WordCountValidLyrics()
        {
            var lyrics = "When you try your best but you don't succeed \nWhen you get what you want but not what you need \nWhen you feel so tired but you can't sleep \nStuck in reverse \nAnd the tears come streaming down your face \n\nWhen you lose something you can't replace \n\nWhen you love someone but it goes to waste\n\nCould it be worse? \n\n\n\nLights will guide you home \n\nAnd ignite your bones \n\nAnd I will try to fix you \n\n\n\nHigh up above or down below \n\nWhen you're too in love to let it go \n\nBut if you never try you'll never know \n\nJust what you're worth \n\n\n\nLights will guide you home \n\nAnd ignite your bones \n\nAnd I will try to fix you \n\n\n\nTears stream down your face \n\nWhen you lose something you cannot replace \n\nTears stream down your face and I\n\n\n\nTears stream down your face \n\nI promise you I will learn from all my mistakes \n\nTears stream down your face and I\n\n\n\nLights will guide you home \n\nAnd ignite your bones \n\nAnd I will try to fix you";
            Assert.That(lyrics.WordCount(), Is.EqualTo(176));
        }

        [Test]
        public void WordCountEmptyString()
        {
            var lyrics = "";
            Assert.That(lyrics.WordCount(), Is.EqualTo(0));
        }

        [Test]
        public void WordCountNullString()
        {
            string lyrics = null;
            Assert.That(lyrics.WordCount(), Is.EqualTo(0));
        }

        [Test]
        public void UriEscapeDataString()
        {
            var d = "paolo nutini".UriEscapeDataString();
            Assert.That(d, Is.EqualTo("paolo%20nutini"));
        }
    }
}