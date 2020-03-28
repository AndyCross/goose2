using System;
using Microsoft.Azure.Cosmos.Table;

namespace goose2s.Models {
    public class QueueItem : TableEntity {
        public QueueItem()
        {
            
        }
        public QueueItem(string flock, DateTime enqueuedTime)
        {
            PartitionKey = flock;
            // Tracks have a lifetime of 1 hr, if they're not played they're not playable
            RowKey = enqueuedTime.AddHours(1d).Ticks.ToString();
        }
        
        public int Votes { get; set; }
        public string TrackId { get; set; }
        public string Image { get; set; }
        public string TrackName { get; set; }
        public string ArtistName { get; set; }
        public int Popularity { get; set; }
        public long PlayCommenced { get; set; }
        public long PlayConcluded { get; set; }
        public int DurationMs { get; set; }
    }
}