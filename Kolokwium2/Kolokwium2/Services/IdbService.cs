using Kolokwium2.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Services
{
    public class IdbService
    {
        public IEnumerable<GetEventResponse> GetEvents(string Nickname);
    }
}
