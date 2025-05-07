using SchedulinAPI.Models;

namespace SchedulinAPI.Services.Interfaces;

/// <summary>
/// Services / tools for managing DateTimeRange
/// </summary>
public interface IDateTimeRangeService
{

    /// <summary>
    /// Checks if two time ranges overlap each other
    /// </summary>
    /// <param name="range">An other DateTimeRange</param>
    /// <returns>True if overlap, flase otherweise</returns>
    /// </summary>
    public bool IsOverlap(DateTimeRange range);
}
