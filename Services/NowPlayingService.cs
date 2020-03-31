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

        public async Task<QueueItem> Tick() {
            if (nowPlaying == null || nowPlaying.PlayConcluded > 0L)
            {
                return await SetupNextTrack(queue);
            }
            else if (nowPlaying.PlayCommenced != 0L && (nowPlaying.PlayConcluded == 0L && (nowPlaying.PlayCommenced + (nowPlaying.DurationMs*10000L) < DateTime.UtcNow.Ticks)))
            {
                nowPlaying.PlayConcluded = DateTime.UtcNow.Ticks;
                return await SetupNextTrack(queue);    
            }
            return nowPlaying;
        }
        private async Task<QueueItem> SetupNextTrack(QueueService queue)
        {
            var currentQueue = await queue.GetFirst("static", -1);
            if (currentQueue.Item1 != long.MinValue)
            {
                sequenceNumber = currentQueue.Item1;
                if (currentQueue.Item2 != null && nowPlaying != currentQueue.Item2) {
                    nowPlaying = currentQueue.Item2;
                    nowPlaying.PlayCommenced = DateTime.UtcNow.Ticks;
                    if (TrackChanged != null) {
                        TrackChanged(nowPlaying);
                    }
                }
            }
            return nowPlaying;
        }
    }
}