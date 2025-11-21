using Microsoft.EntityFrameworkCore;

namespace DemoApi_Tutorial.Models;

public class SchoolContext: DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
    {
    }
}