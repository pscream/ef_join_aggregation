using Microsoft.EntityFrameworkCore;

using WebApi.Models.Database;
using WebApi.DataContext.Configs;

namespace WebApi.DataContext
{

    public class TimesheetContext : DbContext
    {

        public TimesheetContext(DbContextOptions<TimesheetContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ResourceConfiguration());
            modelBuilder.ApplyConfiguration(new StatusConfiguration());
            modelBuilder.ApplyConfiguration(new EngagementConfiguration());
            modelBuilder.ApplyConfiguration(new TimesheetConfiguration());
            modelBuilder.ApplyConfiguration(new TimesheetRowConfiguration());
            modelBuilder.ApplyConfiguration(new TimesheetWeekConfiguration());
        }

        public DbSet<Timesheet> Timesheets { get; set; }
        public DbSet<TimesheetRow> TimesheetRows { get; set; }
        public DbSet<TimesheetWeek> TimesheetWeeks { get; set; }

    }

}