using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApi.Models.Database;

namespace WebApi.DataContext.Configs
{

    public class ResourceConfiguration : IEntityTypeConfiguration<Resource>
    {


        public void Configure(EntityTypeBuilder<Resource> builder)
        {

            builder.ToTable("Resources");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.FirstName).HasColumnType("nvarchar(100)");
            builder.Property(e => e.LastName).HasColumnType("nvarchar(100)");
            builder.HasOne(e => e.User)
                .WithMany().HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.NoAction);

        }

    }

}