using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Configuration
{
    public class EventOrganiserConfig : IEntityTypeConfiguration<EventOrganiser>

    {
        public void Configure(EntityTypeBuilder<EventOrganiser> builder)
        {
            builder.HasKey(e => new { e.IdEvent, e.IdOrganiser });
            builder.ToTable("EventOrganiser");

        }
    }
}

