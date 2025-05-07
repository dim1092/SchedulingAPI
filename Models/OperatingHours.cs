using SchedulinAPI.Utils;

namespace SchedulinAPI.Models;

public class OperatingHours
{
    public long Id { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public List<TimeFrame> TimeFrames { get; set; } = new();
}

