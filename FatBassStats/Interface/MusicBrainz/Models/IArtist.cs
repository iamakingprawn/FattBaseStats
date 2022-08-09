namespace com.FatBassStats.Interface.Models
{
    /// <summary>
    /// Artist Interface for search results
    /// </summary>
    public interface IArtist
    {
        /// <summary>
        /// Artist Id
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Artist Name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Score to help identify required artist
        /// </summary>
        public string Score { get; }
    }
}
