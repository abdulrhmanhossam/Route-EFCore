using EFCore.Entities;
using EFCore02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace EFCore02.Data;

//  A DbContext instance represents a session with the database and can be used to
//  query and save instances of your entities. DbContext is a combination of the
//  Unit Of Work and Repository patterns.
public class AppDbContext : DbContext
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }
    public DbSet<CourseInstructor> CourseInstructors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // build config file
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        // get the value from constr
        var connectionString = configuration
            .GetSection("ConnectionString").Value;

        // use value from constr to open session with the database
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
