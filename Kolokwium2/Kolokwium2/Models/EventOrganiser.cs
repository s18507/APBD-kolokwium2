using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Models
{
    public class EventOrganiser
    {
        public int IdOrganiser { get; set; }
        public int IdEvent { get; set; }
        public Organiser organiser { get; set; }
        public Event evento { get;set; }
    }
}
