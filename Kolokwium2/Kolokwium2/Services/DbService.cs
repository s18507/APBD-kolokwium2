using Kolokwium2.DTOs.Response;
using Kolokwium2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Kolokwium2.Services
{
    public class DbService : IdbService
    {
        private readonly EventDbContext _context;
        public DbService(EventDbContext context)
        {
            _context = context;
        }

        public IEnumerable<GetEventResponse> GetEvents(string Nickname)
        {
            var responseList = new List<GetEventResponse>();

            if (!Nickname.Equals(""))
            {
                var artist = _context.Artists.Where(c => c.Nickname.Equals(Nickname)).FirstOrDefault();
                if(artist is null)
                {
                    return null;
                }
                

        
             
            }
            return responseList;
        }
}
 }

    

