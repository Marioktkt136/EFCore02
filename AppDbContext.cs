using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02
{
    public class AppDbContext : DbContext
    {
        public DbSet<OrganizerClass> Organizers;
        public DbSet<OrgnizerProfileClass> OrganizerProfiles;
        public DbSet<Event> Events;
        public DbSet<AttendeeClass> Attendees;
        public DbSet<BadgeClass> Badges;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.;Database=EventHubDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            modelBuilder.Entity<BadgeClass>(builder =>
            {
                builder.HasKey(b => b.BadgeId);
                builder.Property(b => b.BadgeNumber)
                       .IsRequired()
                       .HasMaxLength(50);
                builder.Property(b => b.IssuedDate)
                       .IsRequired();
                builder.Property(b => b.Tier)
                       .IsRequired()
                       .HasConversion<string>()
                       .HasMaxLength(20);

                builder.HasOne(b => b.Attendee)
                       .WithOne(o => o.badge)
                       .HasForeignKey<BadgeClass>(b => b.AttendeeId)
                       .IsRequired()
                       .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
