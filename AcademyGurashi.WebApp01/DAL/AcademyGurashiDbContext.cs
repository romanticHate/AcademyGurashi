using AcademyGurashi.WebApp01.Models;
using Microsoft.EntityFrameworkCore;

namespace AcademyGurashi.WebApp01.DAL
{
    public class AcademyGurashiDbContext : DbContext
    {       
        public AcademyGurashiDbContext(DbContextOptions<AcademyGurashiDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Course>().ToTable("Course");
        //    modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
        //    modelBuilder.Entity<Student>().ToTable("Student");
        //}
    }
}
