using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyReact.Core.Structure
{
    public class Queue
    {
        public int Id { get; set; }
        public List<QueueEntry> Entries { get; set; }
    }
}
