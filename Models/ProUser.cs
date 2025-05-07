using SchedulinAPI.Models.Interfaces;

namespace SchedulinAPI.Models;

public class ProUser : User
{
    public List<Shop> OwnedShops { get; set; } = new();
    public List<Shop> WorksAt { get; set; } = new();
    public List<OperatingHours> OperatingHours { get; set; } = new();
    public List<IBookable> Bookables { get; set; } = new();
}
