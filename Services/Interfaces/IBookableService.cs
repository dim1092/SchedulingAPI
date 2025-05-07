using SchedulinAPI.Models;
using SchedulinAPI.Models.Interfaces;

namespace SchedulinAPI.Services.Interfaces;

public interface IBookableService
{
    IBookable Bookable { get; }

    /// <summary>
    /// Checks if the event can be created, and does so if it can
    /// </summary>
    /// <returns>True if the event was created, false otherwise</returns>
    public bool CreateEvent();

}
