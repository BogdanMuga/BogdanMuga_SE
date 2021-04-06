using SEProject.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace SEProject.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Solution>()
             .HasKey(bc => new { bc.AssignmentId, bc.StudentId});
            builder.Entity<Solution>()
                .HasOne(bc => bc.Student)
                .WithMany(b => b.Solutions)
                .HasForeignKey(bc => bc.StudentId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Solution>()
                .HasOne(bc => bc.Assignment)
                .WithMany(c => c.Solutions)
                .HasForeignKey(bc => bc.AssignmentId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<StudentCourse>()
             .HasKey(bc => new { bc.StudentId, bc.CourseId});
            builder.Entity<StudentCourse>()
                .HasOne(bc => bc.Student)
                .WithMany(b => b.Courses)
                .HasForeignKey(bc => bc.StudentId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<StudentCourse>()
                .HasOne(bc => bc.Course)
                .WithMany(c => c.StudentsEnrolled)
                .HasForeignKey(bc => bc.CourseId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Solution>()
                .Property(x => x.Grade).HasColumnType("decimal(4,2)");
        }

    }
}
