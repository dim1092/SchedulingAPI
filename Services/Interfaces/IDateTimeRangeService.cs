using SchedulinAPI.Models;
using SchedulinAPI.Models.Interfaces;

namespace SchedulinAPI.Services.Interfaces;

/// <summary>
/// Services / tools for managing DateTimeRange
/// </summary>
public interface IDateTimeRangeService
{
    /// <summary>
    /// Checks if two time ranges overlap each other
    /// </summary>
    /// <param name="range1">First time range</param>
    /// <param name="range2">Second time range</param>
    /// <returns>True if overlap, flase otherweise</returns>
    public abstract static bool IsOverlap(DateTimeRange range1, DateTimeRange range2);
}
