using com.FatBassStats.Interface.Models;

namespace com.FatBassStats.Models
{
    public class Work : IWork
    {
        public Work(string id, string title)
        {
            Id = id;
            Title = title;
        }

        public string Id { get; }
        public string Title { get; }
    }
}