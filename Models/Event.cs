using SchedulinAPI.Models.Interfaces;

namespace SchedulinAPI.Models;

public class Event : IEvent
{
    public long  Id { get; set; }
    public String? Name {  get; set; }
    public DateTime Start { get; set; }
    public DateTime end { get; set; }
    public String Location { get; set; }
    public List<User> joining { get; set; } = new();
    public Activity Activity{ get; set; }

    public bool CanJoin => throw new NotImplementedException();
}

