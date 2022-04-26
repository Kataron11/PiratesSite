using Microsoft.EntityFrameworkCore;
using Project6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6.Model
{
    public class PirateDBContext : DbContext
    {
        public DbSet<Account> Account { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<AccountBoat> AccountBoat { get; set; }
        public DbSet<Boat> Boat { get; set; }
        public PirateDBContext(DbContextOptions<PirateDBContext> options):
            base(options)
        {

        }

        public PirateDBContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PirateDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        // Metoda pozwala na konfigurację modelu przy wykorzystaniu Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);


        /*public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            int result = base.SaveChanges(acceptAllChangesOnSuccess);
            if (ClearTrackingOnSaveChanges)
            {
                foreach (Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry item in ChangeTracker.Entries())
                {
                    item.State = EntityState.Detached;
                }
            }
            return result;
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            int result = await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
            if (ClearTrackingOnSaveChanges)
            {
                foreach (Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry item in ChangeTracker.Entries())
                {
                    item.State = EntityState.Detached;
                }
            }
            return result;
        }*/
    }
}
