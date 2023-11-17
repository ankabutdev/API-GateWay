using Microsoft.EntityFrameworkCore;
using User.API.Models;

namespace User.API.Data;

public class StudentDbContext : DbContext
{
    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

    public virtual DbSet<StudentModel> Students { get; set; }
}
