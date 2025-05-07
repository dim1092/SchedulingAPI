namespace SchedulinAPI.Services.Interfaces;

using SchedulinAPI.Models;
using SchedulinAPI.Models.Interfaces;

public interface IUserService
{
    /// <summary>
    /// Check if a specific user can be added to a specific event
    /// </summary>
    /// <param name="scheduledEvent">the event to wich the user would like to be added to</param>
    /// <returns>true if it can join fals otherwise</returns>
    /// </summary>
    public bool CanAddEvent(IScheduledEvent scheduledEvent);

    /// <summary>
    /// Gets a list of DateTimeRange where the user is not available for a specific event type for a specifc of a DateTimeRange
    /// </summary>
    /// <param name="Bookable">the activity IBookable to check, If null all Sheduled events will be retuned</param>
    /// <param name="timeRange">Date and time start and end for witch to limit the list to, If null all Sheduled events will be retuned</param>
    /// <returns>List of DateTimeRange where the user has other obligations</returns>
    /// <remarks>This list can NOT be used by itself to check if a user is available for an event.
    /// The Availability needs to be taken in account too. The Availability is the weekly / 
    /// daily schedule when he accpets to participate to an event</remarks>
    /// </summary>
    public List<DateTimeRange> GetEvents(DateTimeRange? timeRange = null, IBookable? bookable = null);


    /// <summary>
    /// Add event to user. Data consistency is respected.
    /// </summary>
    /// <param name="ScheduledEvent">The event to be added</param>
    /// <returns>True if the event has been added successfully</returns>
    /// </summary>
    bool AddEvent(IScheduledEvent ScheduledEvent);

    /// <summary>
    /// Delete event from user and if its the owner of the event, call EventServices.rRmoveOwner.
    /// </summary>
    /// <param name="ScheduledEvent"></param>
    /// </summary>
    void RemoveEvent(IScheduledEvent ScheduledEvent);

    /// <summary>
    /// Turns a non pro user to a pro user so it will have extra functionalities for managing shops or managing 
    /// schedule as staff
    /// </summary>
    /// <returns></returns>
    /// </summary>
    ProUser MakeUserProUser();
}
