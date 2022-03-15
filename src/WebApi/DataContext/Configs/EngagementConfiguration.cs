using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApi.Models.Database;

namespace WebApi.DataContext.Configs
{

    public class EngagementConfiguration : IEntityTypeConfiguration<Engagement>
    {

        public void Configure(EntityTypeBuilder<Engagement> builder)
        {

            builder.ToTable("Engagements");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasColumnType("nvarchar(256)");

        }

    }

}