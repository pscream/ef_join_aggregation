using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApi.Models.Database;

namespace WebApi.DataContext.Configs
{

    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {

        public void Configure(EntityTypeBuilder<Status> builder)
        {

            builder.ToTable("Statuses");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasColumnType("nvarchar(50)");

        }

    }

}