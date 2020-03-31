using System;
using System.Threading;
using System.Threading.Tasks;
using goose2s.Models;

namespace goose2s.Services {
    public class NowPlayingService {
        private readonly PlaybackService player;
        private readonly QueueService queue;
        private long sequenceNumber;
        private QueueItem nowPlaying = null;

        public Action<QueueItem> TrackChanged { get; set; }

        public NowPlayingService(QueueService queue)
        {
            this.queue = queue;
        }

        
    }
}