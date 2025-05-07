using SchedulinAPI.Models;
using SchedulinAPI.Models.Interfaces;
using SchedulinAPI.Services.Interfaces;
using System.ComponentModel;

namespace SchedulinAPI.Services;

public class UserService : IUserService
{
    User User { get; }
    public UserService(User user)
    {
        User = user;
    }

    /// <inheritdoc />
    public bool CanAddEvent(IScheduledEvent scheduledEvent)
    {
        // Check if user doesn't have other events at the same time
        foreach (IScheduledEvent userEvent in User.ScheduledEvents)
        {
            if (DateTimeRangeService.IsOverlap(scheduledEvent.DateTimeRange, userEvent.DateTimeRange))
            {
                return false;
            }
        }
        return true;
    }

    /// <inheritdoc />
    public List<DateTimeRange> GetNonAvailability(User performingUser, IBookable bookable)
    {
        List<DateTimeRange> unavailibilities = new ();
        foreach (IScheduledEvent userEvent in performingUser.ScheduledEvents)
        {
            // User has other event, can't join an other one
            if (userEvent.Bookable != bookable) 
            {
                unavailibilities.Add(userEvent.DateTimeRange);
            }
        }
        return unavailibilities;
    }

    /// <inheritdoc />
    public bool AddEvent(IScheduledEvent scheduledEvent)
    {
        if (!CanAddEvent(scheduledEvent)) 
        {
            return false;
        }
        User.ScheduledEvents.Add(scheduledEvent);
        return true;
    }

    /// <inheritdoc />
    public void RemoveEvent(IScheduledEvent ScheduledEvent)
    {
        User.ScheduledEvents.Remove(ScheduledEvent);
    }

    /// <inheritdoc />
    public List<IScheduledEvent> GetEvents(DateTimeRange? timeRange = null, IBookable? bookable = null)
    {
        List<IScheduledEvent> result = new ();
        foreach (IScheduledEvent scheduledEvent in User.ScheduledEvents)
        {
            if (timeRange != null && DateTimeRangeService.IsOverlap(scheduledEvent.DateTimeRange, timeRange))
            {
                continue;
            }
            if (bookable != null && scheduledEvent.Bookable != bookable)
            {
                continue;
            }
            result.Add(scheduledEvent);
        }

        return result;
    }

    /// <inheritdoc />
    public ProUser MakeUserProUser()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public List<DateTimeRange> GetEvents(DateTimeRangeService? timeRange = null, IBookableService? bookable = null)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool AddEvent(IScheduledEventService ScheduledEvent)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public void RemoveEvent(IScheduledEventService ScheduledEvent)
    {
        throw new NotImplementedException();
    }
}
