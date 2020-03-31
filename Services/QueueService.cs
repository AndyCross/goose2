using System.Collections.Generic;
using System.Threading.Tasks;
using goose2s.Models;
using Microsoft.Azure.Cosmos.Table;
using System.Linq;
using System;

namespace goose2s.Services {
    public class QueueService {
        private QueueItem[] _queue = null;
        private long _sequenceNumber = 0L;

        public QueueService()
        {
            this._queue = new QueueItem[0];
            this._sequenceNumber = DateTime.UtcNow.Ticks;
        }

        public async Task Enqueue(string flock, SpotifyItem track) {
            var entity = new QueueItem(flock, DateTime.UtcNow) 
            {
                ArtistName = string.Join(", ", track.artists.Select(a=>a.name)),
                DurationMs = track.duration_ms,
                Image = track.album.images.OrderBy(i => i.height).First().url,
                Popularity = track.popularity,
                TrackId = track.id,
                TrackName = track.name,
                Votes = 0
            };

            lock (this._queue) {
                var q =  new List<QueueItem>(_queue);
                q.Add(entity);
                this._queue = q.ToArray();
                _sequenceNumber = DateTime.UtcNow.Ticks;
            }
        }

        public async Task<(long, QueueItem[])> GetQueue(string flock, long sequenceNumber) {
            if (_sequenceNumber == sequenceNumber)
                return (long.MinValue, null);

            return (_sequenceNumber, _queue
                .Where(qi=> qi.PartitionKey == flock && string.Compare(qi.RowKey, DateTime.UtcNow.Ticks.ToString()) > 0
                            && qi.PlayConcluded == 0L)
                .ToArray());
           
        } 
        
        public async Task<(long, QueueItem)> GetFirst(string flock, long sequenceNumber) {
            if (_sequenceNumber == sequenceNumber)
                return (long.MinValue, null);

            return (_sequenceNumber, _queue
                .Where(qi=> qi.PartitionKey == flock 
                                && string.Compare(qi.RowKey, DateTime.UtcNow.Ticks.ToString()) > 0
                                && (qi.PlayConcluded == 0L || qi.PlayConcluded > DateTime.UtcNow.Ticks))
                .FirstOrDefault());
           
        } 
    }
}