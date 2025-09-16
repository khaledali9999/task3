using Microsoft.EntityFrameworkCore;

using task3.Models;




namespace task3
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=.;Database=StudentSystem;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

          
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, Name = "Ali", RegisteredOn = DateTime.Now, PhoneNumber = "0101234567" },
                new Student { StudentId = 2, Name = "Sara", RegisteredOn = DateTime.Now, Birthday = new DateTime(2000, 5, 20) }
            );

         
            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, Name = "C# Basics", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(3), Price = 200 },
                new Course { CourseId = 2, Name = "Entity Framework Core", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(2), Price = 300 }
            );

         
         

            base.OnModelCreating(modelBuilder);
        }
    }
}
