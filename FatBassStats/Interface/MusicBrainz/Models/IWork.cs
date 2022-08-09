namespace com.FatBassStats.Interface.Models
{
    /// <summary>
    /// Interface for returned song data
    /// </summary>
    public interface IWork
    {
        /// <summary>
        /// The Id of the song
        /// </summary>
        string Id { get; }

        /// <summary>
        /// The Title of the song
        /// </summary>
        string Title { get; }
    }
}