using SpotifyReact.Core.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyReact.Core.Interfaces
{
    public interface IQueue
    {
        /// <summary>
        /// Gets the next song to play and marks it played
        /// </summary>
        /// <param name="queueId"></param>
        /// <returns></returns>
        List<QueueEntry> GetNextSong(int queueId);

        /// <summary>
        /// Add Song to Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="song"></param>
        /// <returns></returns>
        List<QueueEntry> AddSongToQueue(int queueId, Song song);

        /// <summary>
        /// Remove Song from Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="songId"></param>
        /// <returns></returns>
        List<QueueEntry> RemoveSongFromQueue(int queueId, int songId);

        /// <summary>
        /// Upvote a Song in a queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="songId"></param>
        /// <returns></returns>
        List<QueueEntry> UpvoteSongInQueue(int queueId, int songId);

        /// <summary>
        /// Create a Song queue
        /// </summary>
        /// <param name="queueName"></param>
        /// <returns></returns>
        Queue CreateNewQueue(string queueName);

        /// <summary>
        /// Get available Queues
        /// </summary>
        /// <returns></returns>
        List<Queue> GetQueues();

        /// <summary>
        /// Get all queue entries
        /// </summary>
        /// <param name="queueId"></param>
        /// <returns></returns>
        List<QueueEntry> GetQueueEntries(Guid queueId);




    }
}
