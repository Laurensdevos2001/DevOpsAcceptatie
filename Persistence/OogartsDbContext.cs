using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Oogarts.Domain.Appointments;
using Oogarts.Domain.Diseases;
using Oogarts.Persistence.Triggers;
using Oogarts.Domain.Posts;
using Oogarts.Domain.Businesses;
using Oogarts.Domain.Patients;
using Oogarts.Domain.Accounts;
using Oogarts.Domain.Chats;
using Oogarts.Domain.Staffs;
using Oogarts.Domain.OpeningHours;
using Oogarts.Domain.Jobs;

namespace Oogarts.Persistence
{
    public class OogartsDbContext : DbContext
    {
        public DbSet<Staff> Staffs => Set<Staff>();
        public DbSet<Appointment> Appointments => Set<Appointment>();
        public DbSet<Disease> Diseases => Set<Disease>();
        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<Post> Posts => Set<Post>();
        public DbSet<Business> Businesses => Set<Business>();
        public DbSet<Account> Accounts => Set<Account>();
        public DbSet<Chat> Chats => Set<Chat>();

        public DbSet<OpeningHour> OpeningHours => Set<OpeningHour>();

        public DbSet<Job> Jobs => Set<Job>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableDetailedErrors();
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlServer("Server=.;Database=oogarts;Integrated Security=SSPI;TrustServerCertificate=True;");
            optionsBuilder.UseTriggers(optionsBuilder =>
            {
                optionsBuilder.AddTrigger<EntityBeforeSaveTrigger>();
            });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // Apply all configurations from this assembly
        }
    }
}