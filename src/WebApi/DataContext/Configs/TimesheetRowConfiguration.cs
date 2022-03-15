using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApi.Models.Database;

namespace WebApi.DataContext.Configs
{

    public class TimesheetRowConfiguration : IEntityTypeConfiguration<TimesheetRow>
    {

        public void Configure(EntityTypeBuilder<TimesheetRow> builder)
        {

            builder.ToTable("TimesheetRows");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.TimesheetId).HasColumnType("uniqueidentifier");
            builder.HasOne(e => e.Timesheet)
                .WithMany().HasForeignKey(e => e.TimesheetId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.Property(e => e.EngagementId).HasColumnType("uniqueidentifier");
            builder.HasOne(e => e.Engagement)
                .WithMany().HasForeignKey(e => e.EngagementId)
                .OnDelete(DeleteBehavior.NoAction);
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