using Microsoft.EntityFrameworkCore;

namespace lms_platform.Infrastructure;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> option) : base(option)
    {
    }

    public DbSet<User> Users => Set<User>();
}