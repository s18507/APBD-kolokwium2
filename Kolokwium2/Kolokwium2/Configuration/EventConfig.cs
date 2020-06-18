using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Configuration
{
    public class EventConfig : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.IdEvent);
            builder.Property(e => e.Name);
            builder.ToTable("Event");

            builder.HasMany(artist => artist.Artist_event)
                .WithOne(conficEvent => conficEvent.evento)
                .HasForeignKey(conficEvent => conficEvent.IdEvent)
                .IsRequired();


        }
    }
}

