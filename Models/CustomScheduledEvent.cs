using SchedulinAPI.Models.Interfaces;

namespace SchedulinAPI.Models;

public class CustomScheduledEvent : IScheduledEvent
{
    public long Id { get; set; }
    public string Name { get; set; }
    public User Owner { get; set; }
    public List<User> Participants { get; set; } = new ();
    public List<User> Invited {  get; set; } = new ();
    public DateTimeRange DateTimeRange { get; set; }
    public IBookable Bookable { get; set; }

}
