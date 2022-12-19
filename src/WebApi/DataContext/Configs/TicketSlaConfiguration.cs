using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApi.Models.Database;

namespace WebApi.DataContext.Configs
{

    public class TicketSlaConfiguration : IEntityTypeConfiguration<TicketSla>
    {

        public void Configure(EntityTypeBuilder<TicketSla> builder)
        {

            builder.ToTable("TicketSlas");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.TicketId).HasColumnType("uniqueidentifier");
            builder.HasOne(e => e.Ticket)
                .WithMany().HasForeignKey(e => e.TicketId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.Property(e => e.SlaId).HasColumnType("uniqueidentifier");
            builder.HasOne(e => e.Sla)
                .WithMany().HasForeignKey(e => e.SlaId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.CreatedBy)
                .WithMany().HasForeignKey(e => e.CreatedById)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.UpdatedBy)
                .WithMany().HasForeignKey(e => e.UpdatedById)
                .OnDelete(DeleteBehavior.NoAction);

        }

    }

}
