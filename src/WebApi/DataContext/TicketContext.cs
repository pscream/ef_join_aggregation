using Microsoft.EntityFrameworkCore;

using WebApi.Models.Database;
using WebApi.DataContext.Configs;

namespace WebApi.DataContext
{

    public class TicketContext : DbContext
    {

        public TicketContext(DbContextOptions<TicketContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ResourceConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            modelBuilder.ApplyConfiguration(new SlaConfiguration());
            modelBuilder.ApplyConfiguration(new TicketSlaConfiguration());
            modelBuilder.ApplyConfiguration(new TicketSlaCacheConfiguration());
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Sla> Slas { get; set; }
        public DbSet<TicketSla> TicketSlas { get; set; }
        public DbSet<TicketSlaCache> TicketSlaCaches { get; set; }

    }

}
