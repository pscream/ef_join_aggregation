using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApi.Models.Database;

namespace WebApi.DataContext.Configs
{

    public class TimesheetConfiguration : IEntityTypeConfiguration<Timesheet>
    {


        public void Configure(EntityTypeBuilder<Timesheet> builder)
        {

            builder.ToTable("Timesheets");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.ResourceId).HasColumnType("uniqueidentifier");
            builder.HasOne(e => e.Resource)
                .WithMany().HasForeignKey(e => e.ResourceId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.Property(e => e.StartDate).HasColumnType("date");
            builder.Property(e => e.EndDate).HasColumnType("date");
            builder.Property(e => e.StatusId).HasColumnType("uniqueidentifier");
            builder.HasOne(e => e.Status)
                .WithMany().HasForeignKey(e => e.StatusId)
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