namespace com.FatBassStats.Interface
{
    /// <summary>
    /// Basic Interface for logging
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Log the supplied message
        /// </summary>
        /// <param name="message">Message value to log</param>
        void Log(string message);
    }
}
