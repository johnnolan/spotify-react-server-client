using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyReact.Core.Structure
{
    public class QueueEntry
    {
        public int Id { get; set; }
        public int Votes { get; set; }
        public Song Song { get; set; }
        public DateTime Added { get; set; }
        public bool Played { get; set; }
        public DateTime PlayedTime { get; set; }
    }
}
