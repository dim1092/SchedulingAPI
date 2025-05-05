namespace SchedulinAPI.Services;

using SchedulinAPI.Models;
using SchedulinAPI.Services.Interfaces;

public class DateTimeRangeService : IDateTimeRangeService
{
    public static bool IsOverlap(DateTimeRange range1, DateTimeRange range2)
    {
        return range1.Start >= range2.Start && range1.Start < range2.end || range1.end > range2.Start && range1.end <= range2.end;
    }
}
