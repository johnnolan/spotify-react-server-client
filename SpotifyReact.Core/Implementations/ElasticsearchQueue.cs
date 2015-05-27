using SpotifyReact.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyReact.Core.Structure;
using Nest;

namespace SpotifyReact.Core.Implementations
{
    public class ElasticsearchQueue : IQueue
    {
        private readonly ElasticClient Client;

        public ElasticsearchQueue()
        {
            var settings = new ConnectionSettings(
                defaultIndex: "spotifyreact-queue"
            );
            Client = new ElasticClient(settings);
        }

        public List<QueueEntry> AddSongToQueue(int queueId, Song song)
        {
            throw new NotImplementedException();
        }

        public Queue CreateNewQueue(string queueName)
        {
            var queue = new Queue
            {
                Id = Guid.NewGuid(),
                QueueName = queueName,
                Added = DateTime.Now,
                Entries = new List<QueueEntry>()
            };

            Client.IndexAsync<Queue>(queue);

            return queue;
        }

        public List<QueueEntry> GetNextSong(int queueId)
        {
            throw new NotImplementedException();
        }

        public List<QueueEntry> GetQueueEntries(Guid queueId)
        {
            throw new NotImplementedException();
        }

        public List<Queue> GetQueues()
        {
            var searchResults = Client.Search<Queue>(s => s
                .From(0)
            );

            if (searchResults.Documents.Any())
            {
                return searchResults.Documents.OrderBy(x => x.Added).ToList();
            }
            else
            {
                return new List<Queue>();
            }
        }

        public List<QueueEntry> RemoveSongFromQueue(int queueId, int songId)
        {
            throw new NotImplementedException();
        }

        public List<QueueEntry> UpvoteSongInQueue(int queueId, int songId)
        {
            throw new NotImplementedException();
        }
    }
}
