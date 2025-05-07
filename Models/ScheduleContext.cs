using Microsoft.EntityFrameworkCore;

namespace SchedulinAPI.Models;

public class ScheduleContext : DbContext
{
    public ScheduleContext(DbContextOptions<ScheduleContext> options)
        : base(options)
    {
    }

    public DbSet<Activity> Activities { get; set; } = null!;
    public DbSet<OperatingHours> Availabilities { get; set; } = null!;
    public DbSet<Event> Events { get; set; } = null!;
    public DbSet<Shop> Shops { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
}
