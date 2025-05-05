namespace SchedulinAPI.Models;

public class Availability
{
    public long Id { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public List<TimeFrame> TimeFrames { get; set; } = new();
}

