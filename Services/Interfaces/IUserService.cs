namespace SchedulinAPI.Services.Interfaces;

using SchedulinAPI.Models;
using SchedulinAPI.Models.Interfaces;

public interface IUserService
{
    /// <summary>
    /// Check if a specific user can be added to a specific event
    /// </summary>
    /// <param name="user">The user that would like to be added to the event</param>
    /// <param name="ev">the event to wich the user would like to be added to</param>
    /// <returns>true if it can join fals otherwise</returns>
    bool CanAddEvent(User user, IEvent ev);

    /// <summary>
    /// Gets a list of DateTimeRange where the user is not available for a specific event type for a specifc of a DateTimeRange
    /// </summary>
    /// <param name="user">The user to check the availabilty of</param>
    /// <param name="eventType">the activity type to check. This is the id of a Bookable</param>
    /// <returns></returns>
    List<Availability> GetNonAvailability(User user, long eventType);
}
