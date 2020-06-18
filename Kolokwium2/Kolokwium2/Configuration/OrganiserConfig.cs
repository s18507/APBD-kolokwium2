using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Configuration
{
    public class OrganiserConfig : IEntityTypeConfiguration<Organiser>
    {
        public void Configure(EntityTypeBuilder<Organiser> builder)
        {
            builder.HasKey(e => e.IdOrganiser);
            builder.Property(e => e.Name);
            builder.ToTable("Organiser");

            builder.HasMany(organiser => organiser.Event_Organiser)
                .WithOne(conficorg => conficorg.organiser)
                .HasForeignKey(organiserEvent => organiserEvent.IdOrganiser)
                .IsRequired();


        }
    }
}
