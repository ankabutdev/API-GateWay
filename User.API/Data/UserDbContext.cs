using Microsoft.EntityFrameworkCore;
using User.API.Models;

namespace User.API.Data;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

    public virtual DbSet<UserModel> Users { get; set; }
}
