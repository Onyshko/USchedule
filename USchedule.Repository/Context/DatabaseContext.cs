using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection.Emit;
using USchedule.Domain.Entities;
using USchedule.Repository.Utility.SeedConfiguration;

namespace USchedule.Repository.Context
{
    public class DatabaseContext : IdentityDbContext<User, Role, Guid>
    {
        public DatabaseContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<TeacherSubjectGroup> TeacherSubjectGroups { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Entry> Entries { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new FacultyConfiguration());

            builder.Entity<Group>()
                .HasIndex(g => g.Name)
                .IsUnique();

            builder.Entity<Subject>()
                .HasIndex(s => s.Name)
                .IsUnique();

            builder.Entity<Faculty>()
                .HasIndex(b => b.Name)
                .IsUnique();

            builder.Entity<Entry>()
                .HasOne(e => e.Faculty)
                .WithMany()
                .HasForeignKey(e => e.FacultyId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
