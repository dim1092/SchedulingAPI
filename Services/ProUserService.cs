using SchedulinAPI.Models;
using SchedulinAPI.Models.Interfaces;
using SchedulinAPI.Services.Interfaces;

namespace SchedulinAPI.Services;

public class ProUserService : UserService, IProUserService
{
    ProUser User { get; }

    public ProUserService(ProUser user) : base(user)
    {
        User = user;
    }

    /// <inheritdoc />
    public bool AddBookable(IBookable bookable)
    {
        foreach (var shop in User.WorksAt)
        {
            if (shop.Bookables.Contains(bookable))
            {
                shop.Bookables.Add(bookable);
                return true;
            }
        }
        return false;
    }

    /// <inheritdoc />
    public void AddOwnedShop(Shop shop)
    {
        User.OwnedShops.Add(shop);
    }

    /// <inheritdoc />
    public List<IBookable> GetBookables()
    {
        return User.Bookables;
    }

    /// <inheritdoc />
    public List<Shop> GetOwnedShop()
    {
        return User.OwnedShops;
    }

    /// <inheritdoc />
    public void RemoveBookable(IBookable bookable)
    {
        User.Bookables.Remove(bookable);
    }

    /// <inheritdoc />
    public void RemoveOwnedShop(Shop shop)
    {
        User.OwnedShops.Remove(shop);
    }

    /// <inheritdoc />
    public void AddWorksAt(Shop worksAt)
    {
        User.WorksAt.Add(worksAt);
    }

    /// <inheritdoc />
    public void RemoveWorksAt(Shop worksAt)
    {
        User.WorksAt.Remove(worksAt);
    }
}
