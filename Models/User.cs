using SchedulinAPI.Models.Interfaces;

namespace SchedulinAPI.Models;

public class User
{
    public long Id { get; set; }
    public String Name { get; set; }
    public String Email { get; set; }
    public List<IEvent> Events { get; set; } = new();
    public List<Availability> Availability { get; set; } = new();
}
