using Microsoft.EntityFrameworkCore;
using SchedulinAPI.Models.Interfaces;

namespace SchedulinAPI.Models;

public class ScheduleContext : DbContext
{
    public ScheduleContext(DbContextOptions<ScheduleContext> options)
        : base(options)
    {
    }

    public DbSet<IBookable> Bookable { get; set; } = null!;
    public DbSet<OperatingHours> Availabilities { get; set; } = null!;
    public DbSet<IScheduledEvent> Events { get; set; } = null!;
    public DbSet<Shop> Shops { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
}
