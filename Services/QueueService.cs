using System.Collections.Generic;
using System.Threading.Tasks;
using goose2s.Models;
using Microsoft.Azure.Cosmos.Table;
using System.Linq;
using System;

namespace goose2s.Services {
    public class QueueService {
        private readonly TableProvider tableProvider;
        private CloudTable _table;

        public QueueService(TableProvider tableProvider)
        {
            this.tableProvider = tableProvider;
        }

        public async Task Enqueue(string flock, SpotifyItem track) {
            if (_table == null) {
                _table = await tableProvider.CreateTableAsync("queue");
            }

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

            await tableProvider.InsertOrMergeEntityAsync<QueueItem>(_table, entity);

        }

        public async Task<QueueItem[]> GetQueue(string flock) {
            if (_table == null) {
                _table = await tableProvider.CreateTableAsync("queue");
            }

            var query =  new TableQuery<QueueItem>()
                    .Where(
                        TableQuery.CombineFilters(
                            TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, flock),
                            TableOperators.And,
                            TableQuery.GenerateFilterCondition("RowKey", QueryComparisons.GreaterThan, DateTime.UtcNow.Ticks.ToString())
                        )).OrderBy("Votes");

           return _table.ExecuteQuery(query).ToArray();
        } 
    }
}