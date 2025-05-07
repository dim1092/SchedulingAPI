namespace SchedulinAPI.Models.Interfaces;

public interface IScheduledEvent
{
    long Id { get; }
    string Name { get; }
    User Owner { get; }
    DateTimeRange DateTimeRange { get; }
    IBookable? Bookable { get; } 
}
