using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WebApi.Models.Database;

namespace WebApi.DataContext.Configs
{

    public class TicketSlaCacheConfiguration : IEntityTypeConfiguration<TicketSlaCache>
    {

        public void Configure(EntityTypeBuilder<TicketSlaCache> builder)
        {

            builder.ToTable("TicketSlaCache");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.TicketSlaId).HasColumnType("uniqueidentifier");
            builder.HasOne(e => e.TicketSla)
                .WithMany().HasForeignKey(e => e.TicketSlaId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.Property(e => e.StartDate).HasColumnName("StartDate")
                    .HasConversion(e => e, e => DateTime.SpecifyKind(e, DateTimeKind.Utc));
            builder.Property(e => e.EndDate).HasColumnName("EndDate")
                    .HasConversion(e => e, e => DateTime.SpecifyKind(e, DateTimeKind.Utc));
            builder.Property(e => e.Timer1SlaMins)
                   .HasColumnName("Timer1SlaMins")
                   .HasColumnType("int");
            builder.Property(e => e.Timer1StartMins)
                   .HasColumnName("Timer1StartMins")
                   .HasColumnType("int");
            builder.Property(e => e.Timer1EndMins)
                   .HasColumnName("Timer1EndMins")
                   .HasColumnType("int");
            builder.Property(e => e.Timer2SlaMins)
                   .HasColumnName("Timer2SlaMins")
                   .HasColumnType("int");
            builder.Property(e => e.Timer2StartMins)
                   .HasColumnName("Timer2StartMins")
                   .HasColumnType("int");
            builder.Property(e => e.Timer2EndMins)
                   .HasColumnName("Timer2EndMins")
                   .HasColumnType("int");
            builder.HasOne(e => e.CreatedBy)
                .WithMany().HasForeignKey(e => e.CreatedById)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.UpdatedBy)
                .WithMany().HasForeignKey(e => e.UpdatedById)
                .OnDelete(DeleteBehavior.NoAction);

        }

    }

}
