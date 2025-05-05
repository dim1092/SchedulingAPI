namespace SchedulinAPI.Models.Interfaces;

public interface IEvent
{
    long Id { get; }
    string Name { get; }
    DateTimeRange DateTimeRange { get; }
    long EventType { get; } // bookable id
    public bool CanJoin(User user);
}
