using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApi.Models.Database;

namespace WebApi.DataContext.Configs
{

    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {

        public void Configure(EntityTypeBuilder<Ticket> builder)
        {

            builder.ToTable("Tickets");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Code).HasColumnType("nvarchar(100)");
            builder.Property(e => e.OpenedById).HasColumnType("uniqueidentifier");
            builder.HasOne(e => e.OpenedBy)
                .WithMany().HasForeignKey(e => e.OpenedById)
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
