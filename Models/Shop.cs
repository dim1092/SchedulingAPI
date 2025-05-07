using SchedulinAPI.Models.Interfaces;

namespace SchedulinAPI.Models;

public class Shop
{
    public long Id { get; set; }
    public String Name { get; set; }
    public List<IBookable> Bookables { get; set; } = new();
    public List<User> Staff { get; set; } = new();
    public String? Address { get; set; }
}
