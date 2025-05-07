namespace SchedulinAPI.Services.Interfaces;

using SchedulinAPI.Models;
using SchedulinAPI.Models.Interfaces;

public interface IScheduledEventService
{
    /// <summary>
    /// Removes the ScheduledEvent from user and Calls
    /// </summary>
    public void Delete();

    /// <summary>
    /// Checks if a user can join the event
    /// </summary>
    /// <param name="userService">User service that contains the user to be added</param>
    /// <returns>true if the user can be added, false otherwise</returns>
    /// </summary>
    public bool CanJoin(User userService);
}
