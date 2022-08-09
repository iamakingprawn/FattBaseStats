using System;
using com.FatBassStats.Interface;

namespace com.FatBassStats
{
    /// <summary>
    /// Logger for Outputting messages to the console
    /// </summary>
    internal class ConsoleLogger : ILogger
    {
        /// <summary>
        /// Write the message to the console
        /// </summary>
        /// <param name="message">Message to display</param>
        public void Log(string message) => Console.WriteLine(message);
    }
}
