using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyReact.Core.Structure
{
    public class Queue
    {
        public Guid Id { get; set; }
        public List<QueueEntry> Entries { get; set; }
        public string QueueName { get; set; }
        public DateTime Added { get; set; }
    }
}
