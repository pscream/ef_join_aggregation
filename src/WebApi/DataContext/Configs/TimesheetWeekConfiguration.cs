using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApi.Models.Database;

namespace WebApi.DataContext.Configs
{

    public class TimesheetWeekConfiguration : IEntityTypeConfiguration<TimesheetWeek>
    {


        public void Configure(EntityTypeBuilder<TimesheetWeek> builder)
        {

            builder.ToTable("TimesheetWeeks");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.StartDate).HasColumnType("date");
            builder.Property(e => e.EndDate).HasColumnType("date");
            builder.HasOne(e => e.CreatedBy)
                .WithMany().HasForeignKey(e => e.CreatedById)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.UpdatedBy)
                .WithMany().HasForeignKey(e => e.UpdatedById)
                .OnDelete(DeleteBehavior.NoAction);

        }

    }

}