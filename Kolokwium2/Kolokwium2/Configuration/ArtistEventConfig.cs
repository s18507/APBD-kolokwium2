using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Configuration
{
    public class ArtistEventConfig : IEntityTypeConfiguration<ArtistEvent>
    {
        public void Configure(EntityTypeBuilder<ArtistEvent> builder)
        {
            builder.HasKey(e => new { e.IdArtist, e.IdEvent });
            builder.ToTable("ArtistEvent");

        }
    }
}
