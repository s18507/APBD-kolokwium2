using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Models
{
    public class ArtistEvent
    {
        public int IdArtist { get; set; }

        //FK + PK
        public int IdEvent { get; set; }

        public DateTime PerformanceDate { get; set; }
        public Event evento { get; set; }
        public Artist artist { get; set; }

       

    }
}
