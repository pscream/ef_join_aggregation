using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApi.Models.Database;

namespace WebApi.DataContext.Configs
{
    public class SlaConfiguration : IEntityTypeConfiguration<Sla>
    {

        public void Configure(EntityTypeBuilder<Sla> builder)
        {

            builder.ToTable("Slas");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasColumnType("nvarchar(100)");
            builder.HasOne(e => e.CreatedBy)
                .WithMany().HasForeignKey(e => e.CreatedById)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.UpdatedBy)
                .WithMany().HasForeignKey(e => e.UpdatedById)
                .OnDelete(DeleteBehavior.NoAction);

        }

    }
}
