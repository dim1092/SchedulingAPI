using SchedulinAPI.Models.Interfaces;
using SchedulinAPI.Services.Interfaces;

namespace SchedulinAPI.Services;

public class BookableService : IBookableService
{
    IBookable Bookable { get; }
    public BookableService(IBookable bookable)
    {
        Bookable = bookable;
    }
}
