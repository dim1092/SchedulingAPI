namespace SchedulinAPI.Models;

public class Shop
{
    public long Id { get; set; }
    public String? Name { get; set; }
    public List<Activity> Activities { get; set; } = new();
    public List<User> Staf { get; set; } = new();
    public String? Address { get; set; }
}
