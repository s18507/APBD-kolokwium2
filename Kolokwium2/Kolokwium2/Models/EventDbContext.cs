using Kolokwium2.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Models
{
    public class EventDbContext : DbContext
    {
        public EventDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public EventDbContext()
        {

        }

        public DbSet<Artist> Artists{ get; set; }
        public DbSet<ArtistEvent> Artist_event { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventOrganiser> OrganisersEvent { get; set; }
        public DbSet<Organiser> Organisers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ArtystConfig());
            modelBuilder.ApplyConfiguration(new EventConfig());
            modelBuilder.ApplyConfiguration(new ArtistEventConfig());
            modelBuilder.ApplyConfiguration(new OrganiserConfig());
            modelBuilder.ApplyConfiguration(new EventOrganiserConfig());

            //Seed Data
            modelBuilder.Seed();
         }

    }
}
