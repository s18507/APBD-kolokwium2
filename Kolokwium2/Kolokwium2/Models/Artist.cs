using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Models
{
    public class Artist
    {
        public int idArtist { get; set; }
        public string Nickname { get; set; }

        public ICollection<ArtistEvent> Artist_event { get; set; }
    }
}
