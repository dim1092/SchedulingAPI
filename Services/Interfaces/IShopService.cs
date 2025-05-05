using SchedulinAPI.Models;
using SchedulinAPI.Models.Interfaces;

namespace SchedulinAPI.Services.Interfaces;

public interface IShopService
{
    public List<IEvent> GetEventForActivity(Activity activity);
}
