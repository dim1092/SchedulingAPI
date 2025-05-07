namespace SchedulinAPI.Services;

using SchedulinAPI.Models;
using SchedulinAPI.Services.Interfaces;

public class DateTimeRangeService : IDateTimeRangeService
{

    DateTimeRange Range { get; }
    public DateTimeRangeService(DateTimeRange range)
    {
        Range = range;
    }

    /// <inheritdoc />
    public static bool IsOverlap(DateTimeRange range1, DateTimeRange range2)
    {
        return range1.Start >= range2.Start && range1.Start < range2.End || range1.End > range2.Start && range1.End <= range2.End;
    }
}
