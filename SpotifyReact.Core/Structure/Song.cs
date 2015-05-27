using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyReact.Core.Structure
{
    public class Song
    {
        public int SpotifyId { get; set; }
        public String Name { get; set; }
        public String AlbumName { get; set; }
        public String ImageUrl { get; set; }
    }
}
