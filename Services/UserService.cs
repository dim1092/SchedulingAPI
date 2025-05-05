using SchedulinAPI.Models;
using SchedulinAPI.Models.Interfaces;
using SchedulinAPI.Services.Interfaces;

namespace SchedulinAPI.Services;

public class UserService : IUserService
{
    public bool CanAddEvent(User user, IEvent ev)
    {
        throw new NotImplementedException();

        // Check if user can join the event
        if (!ev.CanJoin(user))
        {
            return false;
        }

        // Check if user dosn't have other events in the same time
        foreach (IEvent userEvent in user.Events)
        {
            if (DateTimeRangeService.IsOverlap(userEvent.DateTimeRange, ev.DateTimeRange))
            {
                return false;
            }
        }
        return true;
    }

    public List<DateTimeRange> GetNonAvailability(User performingUser, long eventType)
    {
        List<DateTimeRange> unavailibilities = new ();
        foreach (IEvent userEvent in performingUser.Events)
        {
            if (userEvent.EventType != eventType) // User has other event, can't join an other one
            {
                unavailibilities.Add(userEvent.DateTimeRange);
            } else
            {
                if
            }
        }
    }
}
