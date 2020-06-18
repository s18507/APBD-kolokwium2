using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Configuration
{
    public class ArtystConfig : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasKey(e => e.idArtist);
            builder.Property(e => e.idArtist).ValueGeneratedOnAdd();
            builder.Property(e => e.Nickname).HasMaxLength(30).IsRequired();
            builder.ToTable("Artist");

            builder.HasMany(artist => artist.Artist_event)
                 .WithOne(conficEvent => conficEvent.artist)
                 .HasForeignKey(conficEvent => conficEvent.IdArtist)
                 .IsRequired();



        }

    }
}
