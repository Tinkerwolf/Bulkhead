using System.Collections.Generic;

namespace Bulkhead
{
    public class SuperVar
    {
        public enum Stages
        {
            NotStarted,
            Generating,
            Downloading
        }
        public Stages Stage { get; set; }
        public string FilePattern { get; set; }
        public string Status { get; set; }
        public int Count { get; set; }
        public int Total { get; set; }
        public long Position { get; set; }
        public long FileSize { get; set; }
        public List<string> Possibilities { get; set; }

        public SuperVar()
        {
            Stage = Stages.NotStarted;
            Status = "";
            Count = 0;
            Total = 0;
            Position = 0;
            FileSize = 0;
            Possibilities = new List<string>();
        }
    }
}
