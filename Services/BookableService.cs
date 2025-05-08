using SchedulinAPI.Models.Interfaces;
using SchedulinAPI.Services.Interfaces;

namespace SchedulinAPI.Services;

public class BookableService : IBookableService
{
    IBookable Bookable { get; }

    IBookable IBookableService.Bookable => Bookable;

    public BookableService(IBookable bookable)
    {
        Bookable = bookable;
    }

    public bool CreateEvent()
    {
        throw new NotImplementedException();
    }
}
